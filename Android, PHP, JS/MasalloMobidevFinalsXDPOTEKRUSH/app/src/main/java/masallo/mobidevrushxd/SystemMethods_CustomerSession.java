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

public class SystemMethods_CustomerSession {

    public static String httpLocation = "ginagawamue.000webhostapp.com";


    public static String URL_SystemMethods_GeneralSession = "http://" + httpLocation + "/MasalloSystemMethodsXD/MasalloSystemMethods_CustomerSessionBukasNaPotek.php";


    public static Boolean get_product_information = false;

    public static List<String> get_ProductID = new ArrayList<>();
    public static List<String> get_ProductName = new ArrayList<>();
    public static List<String> get_ProductPrice = new ArrayList<>();
    public static List<String> get_ProductQuantity = new ArrayList<>();
    public static List<String> get_ProductDescription = new ArrayList<>();
    public static List<String> get_ProductImage = new ArrayList<>();

    public static Boolean get_product_information(final Activity activity)
    {
        StringRequest stringRequest = new StringRequest(Request.Method.POST, URL_SystemMethods_GeneralSession,

                new Response.Listener<String>() {
                    @Override
                    public void onResponse(String response) {

                        get_ProductID.clear();
                        get_ProductName.clear();
                        get_ProductPrice.clear();
                        get_ProductQuantity.clear();
                        get_ProductDescription.clear();
                        get_ProductImage.clear();

                        try
                        {
                            JSONObject jsonObject = new JSONObject(response);
                            JSONArray jsonArray = jsonObject.getJSONArray("Products");
                            for (int i = 0; i < jsonArray.length(); i++)
                            {
                                JSONObject get_jsonProducts = jsonArray.getJSONObject(i);

                                get_ProductID.add(get_jsonProducts.getString("product_ID"));
                                get_ProductName.add(get_jsonProducts.getString("product_Name"));
                                get_ProductPrice.add(get_jsonProducts.getString("product_Price"));
                                get_ProductQuantity.add(get_jsonProducts.getString("product_Quantity"));
                                get_ProductDescription.add(get_jsonProducts.getString("product_Description"));
                                get_ProductImage.add(get_jsonProducts.getString("product_Image"));
                            }

                            get_product_information = true;

                        }

                        catch (JSONException e)
                        {
                            //Toast.makeText(activity, e.toString(), Toast.LENGTH_SHORT).show();
                            get_product_information = false;
                        }

                    }
                }, new Response.ErrorListener() {
            @Override
            public void onErrorResponse(VolleyError error) {

                Toast.makeText(activity, "Volley_Error: General-001 " + error.toString(), Toast.LENGTH_LONG).show();
                get_product_information = false;
            }
        }){
            @Override
            protected Map<String, String> getParams() throws AuthFailureError
            {
                Map<String, String> params = new HashMap<String, String>();

                params.put("Customer", "get_product_information");

                return params;
            }
        };

        RequestQueue requestQueue = Volley.newRequestQueue(activity);
        requestQueue.add(stringRequest);

        if (get_product_information)
            return true;
        else
            return false;
    }

    public static void insert_product_order_information(final String set_ProductID, final String set_OrderProductQuantity, final Activity activity)
    {
        StringRequest stringRequest = new StringRequest(Request.Method.POST, URL_SystemMethods_GeneralSession,

                new Response.Listener<String>() {
                    @Override
                    public void onResponse(String response) {

                        Toast.makeText(activity, response, Toast.LENGTH_LONG).show();



                    }
                }, new Response.ErrorListener() {
            @Override
            public void onErrorResponse(VolleyError error) {

                Toast.makeText(activity, "Volley_Error: General-002 " + error.toString(), Toast.LENGTH_LONG).show();

            }
        }){
            @Override
            protected Map<String, String> getParams() throws AuthFailureError
            {
                Map<String, String> params = new HashMap<String, String>();

                params.put("Customer", "insert_product_order_information");
                params.put("set_ProductID", set_ProductID);
                params.put("set_OrderProductQuantity", set_OrderProductQuantity);

                return params;
            }
        };

        RequestQueue requestQueue = Volley.newRequestQueue(activity);
        requestQueue.add(stringRequest);

    }

}
