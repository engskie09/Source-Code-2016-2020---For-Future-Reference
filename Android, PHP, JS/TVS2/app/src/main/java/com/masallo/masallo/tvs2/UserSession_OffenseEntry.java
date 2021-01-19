package com.masallo.masallo.tvs2;

import android.app.Activity;
import android.app.AlertDialog;
import android.app.DatePickerDialog;
import android.app.Dialog;
import android.app.TimePickerDialog;
import android.content.Intent;
import android.database.Cursor;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.text.Editable;
import android.text.TextWatcher;
import android.view.View;
import android.view.ViewGroup;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.DatePicker;
import android.widget.EditText;
import android.widget.Spinner;
import android.widget.TimePicker;
import android.widget.Toast;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import java.lang.reflect.Array;
import java.util.ArrayList;
import java.util.Calendar;
import java.util.Collection;
import java.util.Collections;
import java.util.HashMap;
import java.util.List;
import java.util.zip.Inflater;

public class UserSession_OffenseEntry extends AppCompatActivity {

    public static DatabaseHelper myDB;

    Spinner spn_vehicleType, spn_vehicleStatus, spn_offenseName, spn_offensePenalty, spn_offenseClass ;

    Button btn_offenseDate, btn_Save, btn_SynchData, btn_Print, btn_View;

    String[] array_offenseName, array_offenseFee, array_offenseCode, array_offensePenalty, array_offenseClass,array_vehicleType, array_vehicleStatus;

    EditText et_offenderFirstName, et_offenderMiddleName, et_offenderLastName, et_offenderAddress, et_offenderLicenseNumber, et_offenderPlateNumber,
            et_offenseName, et_offenseFee, et_offenseCode ;

    List<String> list_offenseName = new ArrayList<String>();
    List<String> list_offenseFee = new ArrayList<String>();
    List<String> list_offenseCode = new ArrayList<String>();
    List<String> list_offensePenalty = new ArrayList<String>();
    List<String> list_offenseClass = new ArrayList<String>();


    List<String> list_vehicleType = new ArrayList<String>();
    List<String> list_vehicleStatus = new ArrayList<String>();

    private static final int Date_id = 0;
    private static final int Time_id = 1;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.layout_usersession_offenseentry);

        set_control();
        set_SpinnerLayout();


        myDB = new DatabaseHelper(this);


        btn_offenseDate.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                // Show Date dialog
                showDialog(Date_id);
            }
        });

        spn_offenseName.setOnItemSelectedListener(new AdapterView.OnItemSelectedListener() {
            @Override
            public void onItemSelected(AdapterView<?> parent, View view, int position, long id) {


                et_offenseName.setText(list_offenseName.get(position));
                et_offenseFee.setText(list_offenseFee.get(position));
                et_offenseCode.setText(list_offenseCode.get(position));

            }

            @Override
            public void onNothingSelected(AdapterView<?> parent) {

            }
        });

        et_offenseName.addOnLayoutChangeListener(new View.OnLayoutChangeListener() {
            @Override
            public void onLayoutChange(View v, int left, int top, int right, int bottom, int oldLeft, int oldTop, int oldRight, int oldBottom) {

                if (et_offenseName.getText().toString() != "") {

                    et_offenseName.requestLayout();
                    int get_viewSeperator = et_offenseName.getHeight();

                    View view_seperator1 = findViewById(R.id.view_seperator1);
                    view_seperator1.requestLayout();
                    view_seperator1.getLayoutParams().height = get_viewSeperator;

                }

            }
        });

        btn_Save.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

               boolean chk_Inserted =  myDB.insertData(et_offenderFirstName.getText().toString(), et_offenderMiddleName.getText().toString(), et_offenderLastName.getText().toString(),
                        et_offenderAddress.getText().toString(), et_offenderLicenseNumber.getText().toString(), et_offenderPlateNumber.getText().toString(),
                        spn_vehicleType.getSelectedItem().toString(), spn_vehicleStatus.getSelectedItem().toString(),
                        et_offenseName.getText().toString(), et_offenseFee.getText().toString(), spn_offensePenalty.getSelectedItem().toString(),
                        spn_offenseClass.getSelectedItem().toString(), et_offenseCode.getText().toString(), btn_offenseDate.getText().toString());

                if(chk_Inserted == true)
                    Toast.makeText(getBaseContext(), "Saved Sucessfully!!!", Toast.LENGTH_SHORT).show();
                else
                    Toast.makeText(getBaseContext(), "Please Try Again!!!", Toast.LENGTH_SHORT).show();

                et_offenderFirstName.setText("");
                et_offenderMiddleName.setText("");
                et_offenderLastName.setText("");
                et_offenderAddress.setText("");
                et_offenderLicenseNumber.setText("");
                et_offenderPlateNumber.setText("");
                et_offenseName.setText("");
                et_offenseFee.setText("");
                et_offenseCode.setText("");

                spn_vehicleType.setSelection(0);
                spn_vehicleStatus.setSelection(0);
                spn_offenseName.setSelection(0);
                spn_offensePenalty.setSelection(0);
                spn_offenseClass.setSelection(0);



            }
        });

        btn_SynchData.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {



                if (SystemMethods_UserSession.get_offenderQueueingNumber.size() == 0)
                    return;

                SystemMethods_UserSession.set_ListValue(myDB);


                String get_offenderQueueingNumber = "";
                String get_offenderFirstName = "";
                String get_offenderMiddleName = "";
                String get_offenderLastName = "";
                String get_offenderAddress = "";
                String get_offenderLicenseNumber = "";
                String get_offenderPlateNumber = "";

                String get_vehicleType = "";
                String get_vehicleStatus = "";
                String get_offenseName = "";
                String get_offenseFee = "";
                String get_offensePenalty = "";

                String get_offenseClass = "";
                String get_offenseCode = "";
                String get_offenseDate = "";


                for (int i = 0; i < SystemMethods_UserSession.get_offenderQueueingNumber.size(); i ++)
                {
                    get_offenderQueueingNumber += ","+SystemMethods_UserSession.get_offenderQueueingNumber.get(i);
                    get_offenderFirstName += ","+SystemMethods_UserSession.get_offenderFirstName.get(i);
                    get_offenderMiddleName += ","+SystemMethods_UserSession.get_offenderMiddleName.get(i);
                    get_offenderLastName += ","+SystemMethods_UserSession.get_offenderLastName.get(i);
                    get_offenderAddress += ","+SystemMethods_UserSession.get_offenderAddress.get(i);
                    get_offenderLicenseNumber += ","+SystemMethods_UserSession.get_offenderLicenseNumber.get(i);
                    get_offenderPlateNumber += ","+SystemMethods_UserSession.get_offenderPlateNumber.get(i);

                    get_vehicleType += ","+SystemMethods_UserSession.get_vehicleType.get(i);
                    get_vehicleStatus += ","+SystemMethods_UserSession.get_vehicleStatus.get(i);
                    get_offenseName += ","+SystemMethods_UserSession.get_offenseName.get(i);
                    get_offenseFee += ","+SystemMethods_UserSession.get_offenseFee.get(i);
                    get_offensePenalty += ","+SystemMethods_UserSession.get_offensePenalty.get(i);

                    get_offenseClass += ","+SystemMethods_UserSession.get_offenseClass.get(i);
                    get_offenseCode += ","+SystemMethods_UserSession.get_offenseCode.get(i);
                    get_offenseDate += ","+SystemMethods_UserSession.get_offenseDate.get(i);


                }

                //UserSession_OffenseEntry.this
                String a1 = get_offenderQueueingNumber.substring(1);
                String a2 = get_offenderFirstName.substring(1);
                String a3 = get_offenderMiddleName.substring(1);
                String a4 = get_offenderLastName.substring(1);
                String a5 = get_offenderAddress.substring(1);
                String a6 = get_offenderLicenseNumber.substring(1);
                String a7 = get_offenderPlateNumber.substring(1);
                String a8 = get_vehicleType.substring(1);
                String a9 = get_vehicleStatus.substring(1);

                String a10 = get_offenseName.substring(1);
                String a11 = get_offenseFee.substring(1);
                String a12 = get_offensePenalty.substring(1);
                String a13 = get_offenseClass.substring(1);
                String a14 = get_offenseCode.substring(1);
                String a15 = get_offenseDate.substring(1);

                Toast.makeText(UserSession_OffenseEntry.this, "Please wait", Toast.LENGTH_SHORT).show();

                SystemMethods_UserSession.insert_offender_information(a1 ,a2 ,a3 ,a4 ,a5, a6 ,a7 ,a8 ,a9 ,a10 ,a11 ,a12 ,a13 ,a14 ,a15, UserSession_OffenseEntry.this);
                //Toast.makeText(UserSession_OffenseEntry.this, get_offenderQueueingNumber, Toast.LENGTH_SHORT).show();

                SystemMethods_UserSession.get_offenderQueueingNumber.clear();
                SystemMethods_UserSession.get_offenderFirstName.clear();
                SystemMethods_UserSession.get_offenderMiddleName.clear();
                SystemMethods_UserSession.get_offenderLastName.clear();
                SystemMethods_UserSession.get_offenderAddress.clear();
                SystemMethods_UserSession.get_offenderLicenseNumber.clear();
                SystemMethods_UserSession.get_offenderPlateNumber.clear();
                SystemMethods_UserSession.get_vehicleType.clear();
                SystemMethods_UserSession.get_vehicleStatus.clear();
                SystemMethods_UserSession.get_offenseName.clear();
                SystemMethods_UserSession.get_offenseFee.clear();
                SystemMethods_UserSession.get_offensePenalty.clear();
                SystemMethods_UserSession.get_offenseClass.clear();
                SystemMethods_UserSession.get_offenseCode.clear();
                SystemMethods_UserSession.get_offenseDate.clear();


            }
        });

        btn_View.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                SystemMethods_UserSession.set_ListValue(myDB);
                Intent intent = new Intent(getBaseContext(), UserSession_ListOffender.class);
                startActivity(intent);


            }
        });

        /*btn_Print.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                Intent intent = new Intent(getBaseContext(), UserSession_Print.class);
                startActivity(intent);

                UserSession_Print.get_QueueingNumber = "Queue No. not Added";
                UserSession_Print.get_offenderFullName = et_offenderFirstName.getText().toString() + ", "+ et_offenderMiddleName.getText().toString() + "," + et_offenderLastName.getText().toString();
                UserSession_Print.get_offenderFee = et_offenseFee.getText().toString();
            }
        });*/




    }

    public static void deleteDB(Activity context)
    {
        context.deleteDatabase("db_offender");
        myDB = new DatabaseHelper(context   );
    }

    private void showMessage(String title, String message)
    {

        AlertDialog.Builder builder = new AlertDialog.Builder(this);
        builder.setCancelable(true);
        builder.setTitle(title);
        builder.setMessage(message);
        builder.show();


    }


    private void set_control()
    {
        spn_vehicleType = (Spinner)findViewById(R.id.spn_vehicleType);
        spn_vehicleStatus = (Spinner)findViewById(R.id.spn_vehicleStatus);
        spn_offenseName = (Spinner)findViewById(R.id.spn_offenseName);
        spn_offensePenalty = (Spinner)findViewById(R.id.spn_offensePenalty);
        spn_offenseClass = (Spinner)findViewById(R.id.spn_offenseClass);

        et_offenderFirstName = (EditText)findViewById(R.id.et_offenderFirstName);
        et_offenderMiddleName = (EditText)findViewById(R.id.et_offenderMiddleName);
        et_offenderLastName = (EditText)findViewById(R.id.et_offenderLastName);
        et_offenderAddress = (EditText)findViewById(R.id.et_offenderAddress);
        et_offenderLicenseNumber = (EditText)findViewById(R.id.et_offenderLicenseNumber);
        et_offenderPlateNumber = (EditText)findViewById(R.id.et_offenderPlateNumber);

        et_offenseName = (EditText)findViewById(R.id.et_offenseName);
        et_offenseFee = (EditText)findViewById(R.id.et_offenseFee);
        et_offenseCode = (EditText)findViewById(R.id.et_offenseCode);

        btn_offenseDate = (Button)findViewById(R.id.btn_offenseDate);
        btn_Save = (Button)findViewById(R.id.btn_Save);
        btn_SynchData = (Button)findViewById(R.id.btn_SynchData);
        btn_Print = (Button)findViewById(R.id.btn_Print);
        btn_View = (Button)findViewById(R.id.btn_View);

    }


    private void set_SpinnerLayout()
    {
        array_vehicleType = getResources().getStringArray(R.array.Array_vehicleType);
        array_vehicleStatus = getResources().getStringArray(R.array.Array_vehicleStatus);

        array_offenseName = getResources().getStringArray(R.array.Array_offenseName);
        array_offenseFee = getResources().getStringArray(R.array.Array_offenseFee);
        array_offenseCode = getResources().getStringArray(R.array.Array_offenseCode);
        array_offensePenalty = getResources().getStringArray(R.array.Array_offensePenalty);
        array_offenseClass = getResources().getStringArray(R.array.Array_offenseClass);

        Collections.addAll(list_vehicleType, array_vehicleType);
        Collections.addAll(list_vehicleStatus, array_vehicleStatus);

        Collections.addAll(list_offenseName, array_offenseName);
        Collections.addAll(list_offenseFee, array_offenseFee);
        Collections.addAll(list_offenseCode, array_offenseCode);
        Collections.addAll(list_offensePenalty, array_offensePenalty);
        Collections.addAll(list_offenseClass, array_offenseClass);


        ArrayAdapter<String> AA_vehicleType = new ArrayAdapter<String>(UserSession_OffenseEntry.this, R.layout.spinner_violation, list_vehicleType);
        AA_vehicleType.setDropDownViewResource(R.layout.spinner_violation);
        spn_vehicleType.setAdapter(AA_vehicleType);

        ArrayAdapter<String> AA_vehicleStatus = new ArrayAdapter<String>(UserSession_OffenseEntry.this, R.layout.spinner_violation, list_vehicleStatus);
        AA_vehicleStatus.setDropDownViewResource(R.layout.spinner_violation);
        spn_vehicleStatus.setAdapter(AA_vehicleStatus);

        ArrayAdapter<String> AA_offenseName = new ArrayAdapter<String>(UserSession_OffenseEntry.this, R.layout.spinner_violation, list_offenseName);
        AA_offenseName.setDropDownViewResource(R.layout.spinner_violation);
        spn_offenseName.setAdapter(AA_offenseName);

        ArrayAdapter<String> AA_offensePenalty = new ArrayAdapter<String>(UserSession_OffenseEntry.this, R.layout.spinner_violation, list_offensePenalty);
        AA_offensePenalty.setDropDownViewResource(R.layout.spinner_violation);
        spn_offensePenalty.setAdapter(AA_offensePenalty);

        ArrayAdapter<String> AA_offenseClass = new ArrayAdapter<String>(UserSession_OffenseEntry.this, R.layout.spinner_violation, list_offenseClass);
        AA_offenseClass.setDropDownViewResource(R.layout.spinner_violation);
        spn_offenseClass.setAdapter(AA_offenseClass);


    }

    private void set_List_value()
    {

    }

    protected Dialog onCreateDialog(int id) {

        // Get the calander
        Calendar c = Calendar.getInstance();

        // From calander get the year, month, day, hour, minute
        int year = c.get(Calendar.YEAR);
        int month = c.get(Calendar.MONTH);
        int day = c.get(Calendar.DAY_OF_MONTH);
        int hour = c.get(Calendar.HOUR_OF_DAY);
        int minute = c.get(Calendar.MINUTE);

        switch (id) {
            case Date_id:

                // Open the datepicker dialog
                return new DatePickerDialog(UserSession_OffenseEntry.this, date_listener, year,
                        month, day);
            case Time_id:

                // Open the timepicker dialog
                return new TimePickerDialog(UserSession_OffenseEntry.this, time_listener, hour,
                        minute, false);

        }
        return null;
    }

    // Date picker dialog
    DatePickerDialog.OnDateSetListener date_listener = new DatePickerDialog.OnDateSetListener() {

        @Override
        public void onDateSet(DatePicker view, int year, int month, int day) {
            // store the data in one string and set it to text
            String date1 = String.valueOf(month) + "/" + String.valueOf(day)
                    + "/" + String.valueOf(year);
            btn_offenseDate.setText(date1);
        }
    };
    TimePickerDialog.OnTimeSetListener time_listener = new TimePickerDialog.OnTimeSetListener() {

        @Override
        public void onTimeSet(TimePicker view, int hour, int minute) {
            // store the data in one string and set it to text
            String time1 = String.valueOf(hour) + ":" + String.valueOf(minute);
            //set_time.setText(time1);
        }
    };
}
