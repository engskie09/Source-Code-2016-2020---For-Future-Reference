package masallo.mobidevrushxd;

import android.app.Activity;
import android.app.AlertDialog;
import android.content.Context;
import android.content.DialogInterface;
import android.content.Intent;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.graphics.Canvas;
import android.graphics.ColorMatrix;
import android.graphics.ColorMatrixColorFilter;
import android.graphics.Paint;
import android.graphics.drawable.BitmapDrawable;
import android.graphics.drawable.Drawable;
import android.graphics.drawable.DrawableWrapper;
import android.os.AsyncTask;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.AdapterView;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ImageView;
import android.widget.LinearLayout;
import android.widget.ListView;
import android.widget.Toast;

import com.squareup.picasso.Picasso;
import com.squareup.picasso.Target;

import java.io.BufferedInputStream;
import java.io.IOException;
import java.io.InputStream;
import java.net.HttpURLConnection;
import java.net.MalformedURLException;
import java.net.URI;
import java.net.URL;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.concurrent.ExecutionException;

public class CustomerSession_Main extends AppCompatActivity {

    Button btn_getHTTPlocation, btn_changeSessionAdmin;
    EditText et_getIpAddress;
    ListView lv_ProductList;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.layout_customersession_main);

        btn_getHTTPlocation = (Button)findViewById(R.id.btn_getHTTPlocation);
        btn_changeSessionAdmin = (Button)findViewById(R.id.btn_changeSessionAdmin);
        et_getIpAddress = (EditText) findViewById(R.id.et_getIpAddress);
        lv_ProductList = (ListView) findViewById(R.id.lv_ProductList);

        btn_changeSessionAdmin.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                Intent intent = new Intent(CustomerSession_Main.this, AdminSession_Main.class);
                startActivity(intent);

            }
        });


        if(SystemMethods_CustomerSession.get_product_information(CustomerSession_Main.this))
        {
            set_product_list();
        }

        btn_getHTTPlocation.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                SystemMethods_CustomerSession.httpLocation = et_getIpAddress.getText().toString();
                SystemMethods_CustomerSession.URL_SystemMethods_GeneralSession = "http://" + SystemMethods_CustomerSession.httpLocation + "/MasalloSystemMethodsXD/MasalloSystemMethods_CustomerSessionBukasNaPotek.php";


                if(SystemMethods_CustomerSession.get_product_information(CustomerSession_Main.this))
                {
                    set_product_list();

                }

            }
        });

        lv_ProductList.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> parent, View view, final int position, long id) {


                AlertDialog alertDialog = new AlertDialog.Builder(CustomerSession_Main.this).create();

                final EditText input = new EditText(CustomerSession_Main.this);
                LinearLayout.LayoutParams lp = new LinearLayout.LayoutParams(
                        LinearLayout.LayoutParams.MATCH_PARENT,
                        LinearLayout.LayoutParams.MATCH_PARENT);
                input.setLayoutParams(lp);
                alertDialog.setView(input);

                alertDialog.setTitle("Order");
                alertDialog.setMessage("Do you want to order this product?");
                alertDialog.setButton(AlertDialog.BUTTON_POSITIVE, "Order",
                        new DialogInterface.OnClickListener() {
                            @Override
                            public void onClick(DialogInterface dialog, int which) {

                                String get_OrderProductID = SystemMethods_CustomerSession.get_ProductID.get(position);
                                String get_OrderProductQuantity = input.getText().toString();

                                SystemMethods_CustomerSession.insert_product_order_information(get_OrderProductID, get_OrderProductQuantity, CustomerSession_Main.this);

                            }
                        });

                alertDialog.setButton(AlertDialog.BUTTON_NEGATIVE, "Cancel",
                        new DialogInterface.OnClickListener() {
                            @Override
                            public void onClick(DialogInterface dialog, int which) {

                                Toast.makeText(CustomerSession_Main.this, "Cancel", Toast.LENGTH_SHORT).show();

                            }
                        });
                alertDialog.show();
            }
        });
    }


    private void set_product_list()
    {

        try
        {
            SystemMethods_CustomerSession.get_product_information(CustomerSession_Main.this);

            List<HashMap<String, Object>> aList; aList = new ArrayList<>();

            for (int i = 0; i < SystemMethods_CustomerSession.get_ProductID.size(); i++) {
                HashMap<String, Object> hm = new HashMap<>();

                URL url = new URL("http://" + SystemMethods_CustomerSession.httpLocation + "/" + SystemMethods_CustomerSession.get_ProductImage.get(i));

                hm.put("get_ProductName", "Name: "+SystemMethods_CustomerSession.get_ProductName.get(i));
                hm.put("get_ProductPrice", "Price: "+SystemMethods_CustomerSession.get_ProductPrice.get(i));
                hm.put("get_ProductImage", getImageBitmapFromURL(url.toString()));
                aList.add(hm);
            }




            String[] from = {"get_ProductName", "get_ProductPrice", "get_ProductImage"};
            int[] to = {R.id.tv_ProductName, R.id.tv_ProductPrice, R.id.imgv_ProductImage};


            ExtendedSimpleAdapter adapter = new ExtendedSimpleAdapter(CustomerSession_Main.this, aList, R.layout.lv_productlist, from, to);
            lv_ProductList.setAdapter(adapter);


        }
        catch (Exception e)
        {
            Toast.makeText(CustomerSession_Main.this, e.toString(), Toast.LENGTH_SHORT).show();
        }

    }


    public static Bitmap getImageBitmapFromURL(final String imageUrl){
        Bitmap imageBitmap = null;
        try {
            imageBitmap = new AsyncTask<Void, Void, Bitmap>() {
                @Override
                protected Bitmap doInBackground(Void... params) {
                    try {
                        int targetHeight = 200;
                        int targetWidth = 200;

                        return Picasso.get().load(String.valueOf(imageUrl))
                                //.resize(targetWidth, targetHeight)
                                .placeholder(R.drawable.ic_launcher_background)
                                .error(R.drawable.ic_launcher_background)
                                .get();
                    } catch (IOException e) {
                        e.printStackTrace();
                    }
                    return null;
                }
            }.execute().get();
        } catch (InterruptedException e) {
            e.printStackTrace();
        } catch (ExecutionException e) {
            e.printStackTrace();
        }
        return imageBitmap;
    }




}
