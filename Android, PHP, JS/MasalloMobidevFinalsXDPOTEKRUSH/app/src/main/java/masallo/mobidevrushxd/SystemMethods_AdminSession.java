package masallo.mobidevrushxd;

import android.app.Activity;
import android.widget.Toast;

import com.android.volley.AuthFailureError;
import com.android.volley.Request;
import com.android.volley.RequestQueue;
import com.android.volley.Response;
import com.android.volley.VolleyError;
import com.android.volley.toolbox.StringRequest;
import com.android.volley.toolbox.Volley;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

public class SystemMethods_AdminSession {

    public static String httpLocation = "ginagawamue.000webhostapp.com";

    public static String URL_SystemMethods_GeneralSession = "http://" + httpLocation + "/MasalloSystemMethodsXD/MasalloSystemMethods_GeneralSessionBukasNaPotek.php";

    public static Boolean get_product_order_information = false;

    public static List<String> get_OrderID = new ArrayList<>();
    public static List<String> get_OrderProductName = new ArrayList<>();
    public static List<String> get_OrderProductQuantity = new ArrayList<>();
    public static List<String> get_ProductImage = new ArrayList<>();

    public static Boolean get_product_information(final Activity activity)
    {
        StringRequest stringRequest = new StringRequest(Request.Method.POST, URL_SystemMethods_GeneralSession,

                new Response.Listener<String>() {
                    @Override
                    public void onResponse(String response) {

                        get_OrderID.clear();
                        get_OrderProductName.clear();
                        get_OrderProductQuantity.clear();
                        get_ProductImage.clear();

                        try
                        {
                            JSONObject jsonObject = new JSONObject(response);
                            JSONArray jsonArray = jsonObject.getJSONArray("Products");
                            for (int i = 0; i < jsonArray.length(); i++)
                            {
                                JSONObject get_jsonProducts = jsonArray.getJSONObject(i);

                                get_OrderID.add(get_jsonProducts.getString("order_ID"));;
                                get_OrderProductName.add(get_jsonProducts.getString("product_Name"));;
                                get_OrderProductQuantity.add(get_jsonProducts.getString("product_Quantity"));;
                                get_ProductImage.add(get_jsonProducts.getString("product_Image"));
                            }

                            get_product_order_information = true;

                        }

                        catch (JSONException e)
                        {
                            //Toast.makeText(activity, e.toString(), Toast.LENGTH_SHORT).show();
                            get_product_order_information = false;
                        }

                    }
                }, new Response.ErrorListener() {
            @Override
            public void onErrorResponse(VolleyError error) {

                Toast.makeText(activity, "Volley_Error: General-001 " + error.toString(), Toast.LENGTH_LONG).show();
                get_product_order_information = false;
            }
        }){
            @Override
            protected Map<String, String> getParams() throws AuthFailureError
            {
                Map<String, String> params = new HashMap<String, String>();

                params.put("Admin", "get_product_order_information_mobile");

                return params;
            }
        };

        RequestQueue requestQueue = Volley.newRequestQueue(activity);
        requestQueue.add(stringRequest);

        if (get_product_order_information)
            return true;
        else
            return false;
    }

    public static void accept_product_order_information(final String set_OrderID, final Activity activity)
    {
        StringRequest stringRequest = new StringRequest(Request.Method.POST, URL_SystemMethods_GeneralSession,

                new Response.Listener<String>() {
                    @Override
                    public void onResponse(String response) {

                        Toast.makeText(activity, "Success", Toast.LENGTH_SHORT).show();

                    }
                }, new Response.ErrorListener() {
            @Override
            public void onErrorResponse(VolleyError error) {

                Toast.makeText(activity, "Volley_Error: General-002 " + error.toString(), Toast.LENGTH_LONG).show();
                get_product_order_information = false;
            }
        }){
            @Override
            protected Map<String, String> getParams() throws AuthFailureError
            {
                Map<String, String> params = new HashMap<String, String>();

                params.put("Admin", "accept_product_order_information");
                params.put("set_OrderID", set_OrderID);

                return params;
            }
        };

        RequestQueue requestQueue = Volley.newRequestQueue(activity);
        requestQueue.add(stringRequest);

    }

    public static void decline_product_order_information(final String set_OrderID, final Activity activity)
    {
        StringRequest stringRequest = new StringRequest(Request.Method.POST, URL_SystemMethods_GeneralSession,

                new Response.Listener<String>() {
                    @Override
                    public void onResponse(String response) {

                        Toast.makeText(activity, "Success", Toast.LENGTH_SHORT).show();


                    }
                }, new Response.ErrorListener() {
            @Override
            public void onErrorResponse(VolleyError error) {

                Toast.makeText(activity, "Volley_Error: General-003 " + error.toString(), Toast.LENGTH_LONG).show();
                get_product_order_information = false;
            }
        }){
            @Override
            protected Map<String, String> getParams() throws AuthFailureError
            {
                Map<String, String> params = new HashMap<String, String>();

                params.put("Admin", "accept_product_order_information");
                params.put("set_OrderID", set_OrderID);

                return params;
            }
        };

        RequestQueue requestQueue = Volley.newRequestQueue(activity);
        requestQueue.add(stringRequest);

    }

    public static void delete_product_order_information(final String set_OrderID, final Activity activity)
    {
        StringRequest stringRequest = new StringRequest(Request.Method.POST, URL_SystemMethods_GeneralSession,

                new Response.Listener<String>() {
                    @Override
                    public void onResponse(String response) {

                        Toast.makeText(activity, "Success", Toast.LENGTH_SHORT).show();


                    }
                }, new Response.ErrorListener() {
            @Override
            public void onErrorResponse(VolleyError error) {

                Toast.makeText(activity, "Volley_Error: General-004 " + error.toString(), Toast.LENGTH_LONG).show();
                get_product_order_information = false;
            }
        }){
            @Override
            protected Map<String, String> getParams() throws AuthFailureError
            {
                Map<String, String> params = new HashMap<String, String>();

                params.put("Admin", "delete_product_order_information");
                params.put("set_OrderID", set_OrderID);

                return params;
            }
        };

        RequestQueue requestQueue = Volley.newRequestQueue(activity);
        requestQueue.add(stringRequest);

    }
}
