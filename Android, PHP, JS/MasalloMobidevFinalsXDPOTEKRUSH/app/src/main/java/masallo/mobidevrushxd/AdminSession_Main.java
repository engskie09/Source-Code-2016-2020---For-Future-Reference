package masallo.mobidevrushxd;

import android.app.AlertDialog;
import android.content.DialogInterface;
import android.content.Intent;
import android.graphics.Bitmap;
import android.os.AsyncTask;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.Button;
import android.widget.EditText;
import android.widget.LinearLayout;
import android.widget.ListView;
import android.widget.Toast;

import com.squareup.picasso.Picasso;

import java.io.IOException;
import java.net.URL;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.concurrent.ExecutionException;

public class AdminSession_Main extends AppCompatActivity {

    Button btn_getHTTPlocation, btn_changeSessionCustomer;
    EditText et_getIpAddress;
    ListView lv_OrderList;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.layout_adminsession_main);

        btn_getHTTPlocation = (Button)findViewById(R.id.btn_getHTTPlocation);
        btn_changeSessionCustomer = (Button)findViewById(R.id.btn_changeSessionCustomer);
        et_getIpAddress = (EditText) findViewById(R.id.et_getIpAddress);
        lv_OrderList = (ListView) findViewById(R.id.lv_OrderList);

        btn_changeSessionCustomer.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                Intent intent =new Intent(AdminSession_Main.this, CustomerSession_Main.class);
                startActivity(intent);

            }
        });

        if(SystemMethods_AdminSession.get_product_information(AdminSession_Main.this))
        {
            set_order_list();

        }

        btn_getHTTPlocation.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                SystemMethods_AdminSession.httpLocation = et_getIpAddress.getText().toString();
                SystemMethods_AdminSession.URL_SystemMethods_GeneralSession = "http://" + SystemMethods_AdminSession.httpLocation + "/MasalloSystemMethodsXD/MasalloSystemMethods_CustomerSessionBukasNaPotek.php";


                if(SystemMethods_AdminSession.get_product_information(AdminSession_Main.this))
                {
                    set_order_list();

                }

            }
        });

        lv_OrderList.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> parent, View view, final int position, long id) {

                AlertDialog alertDialog = new AlertDialog.Builder(AdminSession_Main.this).create();
                alertDialog.setTitle("Transaction");
                alertDialog.setMessage("Select an Action.");
                alertDialog.setButton(AlertDialog.BUTTON_NEUTRAL, "Accept",
                        new DialogInterface.OnClickListener() {
                            @Override
                            public void onClick(DialogInterface dialog, int which) {

                                Toast.makeText(AdminSession_Main.this, "Accept", Toast.LENGTH_SHORT).show();

                                SystemMethods_AdminSession.accept_product_order_information(SystemMethods_AdminSession.get_OrderID.get(position), AdminSession_Main.this);
                                set_order_list();
                            }
                        });

                alertDialog.setButton(AlertDialog.BUTTON_NEGATIVE, "Decline",
                        new DialogInterface.OnClickListener() {
                            @Override
                            public void onClick(DialogInterface dialog, int which) {

                                SystemMethods_AdminSession.decline_product_order_information(SystemMethods_AdminSession.get_OrderID.get(position), AdminSession_Main.this);
                                set_order_list();
                            }
                        });

                alertDialog.setButton(AlertDialog.BUTTON_POSITIVE, "Delete Order",
                        new DialogInterface.OnClickListener() {
                            @Override
                            public void onClick(DialogInterface dialog, int which) {

                                SystemMethods_AdminSession.delete_product_order_information(SystemMethods_AdminSession.get_OrderID.get(position), AdminSession_Main.this);
                                set_order_list();

                            }
                        });
                alertDialog.show();
            }
        });
    }

    private void set_order_list()
    {

        try
        {
            SystemMethods_AdminSession.get_product_information(AdminSession_Main.this);

            List<HashMap<String, Object>> aList; aList = new ArrayList<>();

            for (int i = 0; i < SystemMethods_AdminSession.get_OrderID.size(); i++) {
                HashMap<String, Object> hm = new HashMap<>();

                URL url = new URL("http://" + SystemMethods_AdminSession.httpLocation + "/" + SystemMethods_AdminSession.get_ProductImage.get(i));

                hm.put("get_ProductName", "Name: "+SystemMethods_AdminSession.get_OrderProductName.get(i));
                hm.put("get_ProductQuantity", "Quantity: "+SystemMethods_AdminSession.get_OrderProductQuantity.get(i));
                hm.put("get_ProductImage", getImageBitmapFromURL(url.toString()));
                aList.add(hm);
            }




            String[] from = {"get_ProductName", "get_ProductQuantity", "get_ProductImage"};
            int[] to = {R.id.tv_OrderProductName, R.id.tv_OrderProductQuantity, R.id.imgv_ProductImage};


            ExtendedSimpleAdapter adapter = new ExtendedSimpleAdapter(AdminSession_Main.this, aList, R.layout.lv_orderlist, from, to);
            lv_OrderList.setAdapter(adapter);


        }
        catch (Exception e)
        {
            Toast.makeText(AdminSession_Main.this, e.toString(), Toast.LENGTH_SHORT).show();
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
