package com.example.user01.mobidev_finals_tp;

import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.os.Handler;
import android.support.annotation.NonNull;
import android.support.design.widget.NavigationView;
import android.support.design.widget.Snackbar;
import android.support.v4.view.GravityCompat;
import android.support.v4.widget.DrawerLayout;
import android.support.v7.app.ActionBarDrawerToggle;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Base64;
import android.view.MenuItem;
import android.widget.ArrayAdapter;
import android.widget.ImageView;
import android.widget.ListView;
import android.widget.SimpleAdapter;
import android.widget.Toast;

import com.android.volley.Response;
import com.android.volley.VolleyError;
import com.android.volley.toolbox.JsonArrayRequest;
import com.android.volley.toolbox.Volley;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import java.lang.reflect.Array;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.HashMap;
import java.util.List;

public class CustomerSession_Main extends AppCompatActivity implements NavigationView.OnNavigationItemSelectedListener {


    private DrawerLayout mDrawerLayout;
    private ActionBarDrawerToggle mToggle;
    private NavigationView navigationView;

    private ListView lv_getproducts;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_customer_session__main);

        set_product_information();


        //----------------------------------Drawer----------------------------------------
        mDrawerLayout = (DrawerLayout) findViewById(R.id.drawer);
        mDrawerLayout.addDrawerListener(mToggle);
        mToggle = new ActionBarDrawerToggle(this, mDrawerLayout, R.string.open, R.string.close);
        mToggle.syncState();

        getSupportActionBar().setDisplayHomeAsUpEnabled(true);

        navigationView = findViewById(R.id.nav_view);
        navigationView.setNavigationItemSelectedListener(this);

        if (savedInstanceState == null)
        {

            getSupportFragmentManager().beginTransaction().replace(R.id.fragment_container,
                    new CustomerSession_MyAccount()).commit();
            navigationView.setCheckedItem(R.id.itm_MyAccount);
        }
        //----------------------------------Drawer----------------------------------------



    }

    //----------------------------------Drawer Event----------------------------------
    @Override
    public boolean onOptionsItemSelected(MenuItem item)
    {
        if (mToggle.onOptionsItemSelected(item))
        {
            return true;
        }
        return super.onOptionsItemSelected(item);
    }

    @Override
    public boolean onNavigationItemSelected(@NonNull MenuItem menuItem)
    {

        switch (menuItem.getItemId())
        {
            case R.id.itm_MyAccount:
                getSupportFragmentManager().beginTransaction().replace(R.id.fragment_container,
                        new CustomerSession_MyAccount()).commit();
                break;

            case R.id.itm_Order:
                getSupportFragmentManager().beginTransaction().replace(R.id.fragment_container,
                        new CustomerSession_Order()).commit();
                break;

            case R.id.itm_Cart:
                getSupportFragmentManager().beginTransaction().replace(R.id.fragment_container,
                        new CustomerSession_Cart()).commit();
                break;
        }

        mDrawerLayout.closeDrawer(GravityCompat.START);
        return true;
    }
    //----------------------------------Drawer Event----------------------------------

    private void set_product_information()
    {
        SystemMethods_General.get_product_information(this);




        final Handler handler = new Handler();
        handler.postDelayed(new Runnable() {
            @Override
            public void run() {

                if (SystemMethods_General.get_ProductName.size() == 0)
                {
                    Toast.makeText(CustomerSession_Main.this, "Empty", Toast.LENGTH_SHORT).show();
                }

                // Array of strings for ListView Title
                String[] listviewTitle = new String[SystemMethods_General.get_ProductName.size()];
                SystemMethods_General.get_ProductName.toArray(listviewTitle);



                byte [] xD  = Base64.decode(SystemMethods_General.get_ProductPicture.get(0).toString(), Base64.DEFAULT);
                Bitmap bmp = BitmapFactory.decodeByteArray(xD, 0 , xD.length);
                ImageView tae = (ImageView) findViewById(R.id.imageView2);
                tae.setImageBitmap(bmp);

                Toast.makeText(CustomerSession_Main.this, SystemMethods_General.get_ProductPicture.get(0).toString(), Toast.LENGTH_SHORT).show();


                Bitmap[] listviewImage = new Bitmap[]{
                        bmp
                };

                String[] listviewShortDescription = new String[]{
                        "paeng1"
                };

                List<HashMap<String, Object>> aList = new ArrayList<HashMap<String, Object  >>();

                for (int i = 0; i < 1; i++) {
                    HashMap<String, Object> hm = new HashMap<String, Object>();
                    hm.put("listview_title", listviewTitle[i]);
                    hm.put("listview_discription", listviewShortDescription[i]);
                    hm.put("listview_image", listviewImage[i]);
                    aList.add(hm);
                }

                String[] from = {"listview_image", "listview_title", "listview_discription"};
                int[] to = {R.id.listview_image, R.id.listview_item_title, R.id.listview_item_short_description};

                SimpleAdapter simpleAdapter = new SimpleAdapter(getBaseContext(), aList, R.layout.listview_products, from, to);
                ListView androidListView = (ListView) findViewById(R.id.lv_getproducts);
                androidListView.setAdapter(simpleAdapter);

                ImageView pwe = (ImageView) findViewById(R.id.listview_image);
                //pwe.setImageBitmap(bmp);

            }
        }, 100);




    }


}
