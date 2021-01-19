package com.masallo.masallo.tvs2;

import android.app.Activity;
import android.content.Context;
import android.database.Cursor;
import android.widget.Toast;

import com.android.volley.AuthFailureError;
import com.android.volley.Request;
import com.android.volley.RequestQueue;
import com.android.volley.Response;
import com.android.volley.VolleyError;
import com.android.volley.toolbox.StringRequest;
import com.android.volley.toolbox.Volley;

import org.json.JSONArray;
import org.json.JSONObject;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

public class SystemMethods_UserSession {


    public static List<String> get_offenderQueueingNumber = new ArrayList<String>();

    public static List<String> get_offenderFirstName = new ArrayList<String>();
    public static List<String> get_offenderMiddleName = new ArrayList<String>();
    public static List<String> get_offenderLastName = new ArrayList<String>();

    public static List<String> get_offenderAddress = new ArrayList<String>();
    public static List<String> get_offenderLicenseNumber = new ArrayList<String>();
    public static List<String> get_offenderPlateNumber = new ArrayList<String>();

    public static List<String> get_vehicleType = new ArrayList<String>();
    public static List<String> get_vehicleStatus = new ArrayList<String>();

    public static List<String> get_offenseName = new ArrayList<String>();
    public static List<String> get_offenseFee = new ArrayList<String>();
    public static List<String> get_offensePenalty = new ArrayList<String>();
    public static List<String> get_offenseClass = new ArrayList<String>();
    public static List<String> get_offenseCode = new ArrayList<String>();
    public static List<String> get_offenseDate = new ArrayList<String>();

    public static void set_ListValue(DatabaseHelper myDB)
    {
        Cursor cursor = myDB.getAllData();

        if (cursor.getCount() == 0)
        {
            //showMessage("List", "Nothing Found!!!");
            return;
        }

        get_offenderQueueingNumber.clear();
        get_offenderFirstName.clear();
        get_offenderMiddleName.clear();
        get_offenderLastName.clear();
        get_offenderAddress.clear();
        get_offenderLicenseNumber.clear();
        get_offenderPlateNumber.clear();
        get_vehicleType.clear();
        get_vehicleStatus.clear();
        get_offenseName.clear();
        get_offenseFee.clear();
        get_offensePenalty.clear();
        get_offenseClass.clear();
        get_offenseCode.clear();
        get_offenseDate.clear();

        //StringBuffer stringBuffer = new StringBuffer();

        while (cursor.moveToNext())
        {
                    /*
                    stringBuffer.append(cursor.getString(0)+ "\n");
                    stringBuffer.append(cursor.getString(1)+ "\n");
                    stringBuffer.append(cursor.getString(2)+ "\n");
                    stringBuffer.append(cursor.getString(3)+ "\n");
                    stringBuffer.append(cursor.getString(4)+ "\n");
                    stringBuffer.append(cursor.getString(5)+ "\n");
                    stringBuffer.append(cursor.getString(6)+ "\n");
                    stringBuffer.append(cursor.getString(7)+ "\n");
                    stringBuffer.append(cursor.getString(8)+ "\n");
                    stringBuffer.append(cursor.getString(9)+ "\n");
                    stringBuffer.append(cursor.getString(10)+ "\n");
                    stringBuffer.append(cursor.getString(11)+ "\n");
                    stringBuffer.append(cursor.getString(12)+ "\n");
                    stringBuffer.append(cursor.getString(13)+ "\n");*/

            get_offenderQueueingNumber.add(cursor.getString(0));
            get_offenderFirstName.add(cursor.getString(1));
            get_offenderMiddleName.add(cursor.getString(2));
            get_offenderLastName.add(cursor.getString(3));
            get_offenderAddress.add(cursor.getString(4));
            get_offenderLicenseNumber.add(cursor.getString(5));
            get_offenderPlateNumber.add(cursor.getString(6));
            get_vehicleType.add(cursor.getString(7));
            get_vehicleStatus.add(cursor.getString(8));
            get_offenseName.add(cursor.getString(9));
            get_offenseFee.add(cursor.getString(10));
            get_offensePenalty.add(cursor.getString(11));
            get_offenseClass.add(cursor.getString(12));
            get_offenseCode.add(cursor.getString(13));
            get_offenseDate.add(cursor.getString(14));
        }

        //showMessage("List", stringBuffer.toString());
    }
    public static void insert_offender_information(final String set_offenderQueueingNumber, final String set_offenderFirstName, final String set_offenderMiddleName, final String set_offenderLastName,
                                                   final String set_offenderAddress, final String set_offenderLicenseNumber, final String set_offenderPlateNumber, final String set_vehicleType, final String set_vehicleStatus,
                                                   final String set_offenseName, final String set_offenseFee, final String set_offensePenalty, final String set_offenseClass,
                                                   final String set_offenseCode, final String set_offenseDate,final Context context)
    {
        StringRequest stringRequest = new StringRequest(Request.Method.POST, "http://trafficviolationsystem.com/SystemMethods_UserSession.php", new Response.Listener<String>() {

            @Override
            public void onResponse(String response) {

                Toast.makeText(context, "Success!", Toast.LENGTH_SHORT).show();
                UserSession_OffenseEntry.deleteDB((Activity) context);



            }
        }, new Response.ErrorListener() {
            @Override
            public void onErrorResponse(VolleyError error) {

                Toast.makeText(context, "Volley_Error: User-001 " + error.toString(), Toast.LENGTH_LONG).show();

            }
        }){
            @Override
            protected Map<String, String> getParams() throws AuthFailureError
            {
                Map<String, String> params = new HashMap<String, String>();

                params.put("Offender", "Offender");
                params.put("set_offenderQueueingNumber", set_offenderQueueingNumber);
                params.put("set_offenderFirstName", set_offenderFirstName);
                params.put("set_offenderMiddleName", set_offenderMiddleName);
                params.put("set_offenderLastName", set_offenderLastName);

                params.put("set_offenderAddress", set_offenderAddress);
                params.put("set_offenderLicenseNumber", set_offenderLicenseNumber);
                params.put("set_offenderPlateNumber", set_offenderPlateNumber);
                params.put("set_vehicleType", set_vehicleType);
                params.put("set_vehicleStatus", set_vehicleStatus);


                params.put("set_offenseName", set_offenseName);
                params.put("set_offenseFee", set_offenseFee);
                params.put("set_offensePenalty", set_offensePenalty);
                params.put("set_offenseClass", set_offenseClass);

                params.put("set_offenseCode", set_offenseCode);
                params.put("set_offenseDate", set_offenseDate);



                return params;
            }
        };

        RequestQueue requestQueue = Volley.newRequestQueue(context);
        requestQueue.add(stringRequest);
    }

    public static void asd()
    {
        JSONObject jsonObject = new JSONObject();
        JSONArray jsonArray = new JSONArray();



    }




}
