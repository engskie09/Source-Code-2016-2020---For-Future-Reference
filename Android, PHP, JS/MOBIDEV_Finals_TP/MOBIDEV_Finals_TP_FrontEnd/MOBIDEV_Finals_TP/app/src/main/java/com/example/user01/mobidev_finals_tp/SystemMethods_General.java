package com.example.user01.mobidev_finals_tp;

import android.app.Activity;
import android.content.Intent;
import android.widget.Toast;

import com.android.volley.Request;
import com.android.volley.RequestQueue;
import com.android.volley.Response;
import com.android.volley.VolleyError;
import com.android.volley.toolbox.JsonObjectRequest;
import com.android.volley.toolbox.Volley;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import java.util.ArrayList;


public class SystemMethods_General  {

    public static void open_sign_up_session(Activity context)
    {
        Intent intent = new Intent(context, SignUpSession.class);
        context.startActivity(intent);
    }

    public static void open_customer_session_main(Activity context)
    {
        Intent intent = new Intent(context, CustomerSession_Main.class);
        context.startActivity(intent);
    }

    private static String url = "http://192.168.1.106/MOBIDEV_Finals_TP_BackEnd/GeneralSession_Order.php";

    public static ArrayList get_ProductID           = new ArrayList<String>();
    public static ArrayList get_ProductName         = new ArrayList<String>();
    public static ArrayList get_ProductQuantity     = new ArrayList<Integer>();
    public static ArrayList get_ProductPrice        = new ArrayList<Integer>();
    public static ArrayList get_ProductDescription  = new ArrayList<String>();
    public static ArrayList get_ProductCategory     = new ArrayList<String>();
    public static ArrayList get_ProductPicture      = new ArrayList<String>();

    public static void get_product_information(final Activity context)
    {
        JsonObjectRequest request = new JsonObjectRequest(Request.Method.GET, url, null,
                new Response.Listener<JSONObject>() {
                    @Override
                    public void onResponse(JSONObject response)
                    {
                        try
                        {
                            JSONArray jsonArray = response.getJSONArray("Products");
                            for (int i = 0; i < jsonArray.length(); i++)
                            {
                                JSONObject products = jsonArray.getJSONObject(i);

                                get_ProductID.add(products.getString("product_id"));
                                get_ProductName.add(products.getString("product_name"));
                                get_ProductQuantity.add(Integer.parseInt(products.getString("product_quantity")));
                                get_ProductPrice.add(Integer.parseInt(products.getString("product_price")));
                                get_ProductDescription.add(products.getString("product_description"));
                                get_ProductCategory.add(products.getString("product_category"));
                                get_ProductPicture.add(products.getString("product_picture"));
                                Toast.makeText(context, get_ProductName.get(0).toString(), Toast.LENGTH_SHORT).show();

                            }
                        } catch (JSONException e)
                        {
                            Toast.makeText(context, e.toString(), Toast.LENGTH_SHORT).show();
                        }

                        Toast.makeText(context, "Have Response", Toast.LENGTH_SHORT).show();
                    }
                }, new Response.ErrorListener() {
            @Override
            public void onErrorResponse(VolleyError error)
            {

                Toast.makeText(context, error.toString(), Toast.LENGTH_SHORT).show();
            }
        });

        RequestQueue mQueue;
        mQueue = Volley.newRequestQueue(context);
        mQueue.add(request);


    }



}
