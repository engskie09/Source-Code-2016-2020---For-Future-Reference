package com.devglan.sqlitedatabase;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

import com.devglan.sqlitedatabase.database.DataBaseHelper;
import com.devglan.sqlitedatabase.datamodel.RegistrationDataModel;

import java.util.ArrayList;

public class MainActivity extends AppCompatActivity {

    TextView tv_name,tv_email,tv_address,tv_phone,tv_submit,tv_show,tv_regid;
    EditText et_name,et_email,et_address,et_phone,et_regid;
   DataBaseHelper dataBaseHelper;
    ArrayList<RegistrationDataModel> registrationDataModelArrayList=new ArrayList<>();

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
       dataBaseHelper=new DataBaseHelper(this);

        initView();
    }


    public void initView(){
        tv_name= (TextView) findViewById(R.id.tv_name);
        tv_email= (TextView) findViewById(R.id.tv_email);
        tv_address= (TextView) findViewById(R.id.tv_address);
        tv_phone= (TextView) findViewById(R.id.tv_phone);
        tv_regid= (TextView) findViewById(R.id.tv_regid);
        tv_submit= (TextView) findViewById(R.id.tv_submit);
        et_name= (EditText) findViewById(R.id.et_name);
        et_email= (EditText) findViewById(R.id.et_email);
        et_address= (EditText) findViewById(R.id.et_address);
        et_phone= (EditText) findViewById(R.id.et_phone);
        et_regid= (EditText) findViewById(R.id.et_regid);
        tv_show= (TextView) findViewById(R.id.tv_show);
        tv_submit.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {

                // save data in data base
                if(validateField()){
                    String name=et_name.getText().toString();
                    String address=et_address.getText().toString();
                    String phone=et_phone.getText().toString();
                    String email=et_email.getText().toString();



                    RegistrationDataModel regDmodel=new RegistrationDataModel();
                    regDmodel.setName(name);
                    regDmodel.setEmail(email);
                    regDmodel.setAddress(address);
                    regDmodel.setPhone(phone);
                    dataBaseHelper.addRegistrationData(regDmodel);
                    Toast.makeText(MainActivity.this,"Data Inserted successfully",Toast.LENGTH_SHORT).show();




                }
            }
        });

            tv_show.setOnClickListener(new View.OnClickListener() {
                @Override
                public void onClick(View view) {
                    registrationDataModelArrayList= dataBaseHelper.getRegistrationData();
                    if(registrationDataModelArrayList.size()>0){
                        Intent intent=new Intent(MainActivity.this,ListActivity.class);
                        startActivity(intent);
                    }else {
                        Toast.makeText(MainActivity.this,"No data found in table",Toast.LENGTH_SHORT).show();
                    }

                }
            });


    }

    public boolean validateField(){

        boolean isValidationSuccessful = true;

        if(et_name.getText().toString().trim().equalsIgnoreCase("")){
            Toast.makeText(MainActivity.this,"Name can't be empty",Toast.LENGTH_SHORT).show();
            isValidationSuccessful=false;

        } else if(et_email.getText().toString().trim().equalsIgnoreCase("")  ){
          Toast.makeText(MainActivity.this,"Email  can't be empty", Toast.LENGTH_SHORT).show();
            isValidationSuccessful=false;
        } else   if(et_address.getText().toString().trim().equalsIgnoreCase("")){
           Toast.makeText(MainActivity.this,"Address can't be empty",Toast.LENGTH_SHORT).show();
            isValidationSuccessful=false;
        }else   if(et_phone.getText().toString().trim().equalsIgnoreCase("")){
           Toast.makeText(MainActivity.this,"Phone can't be empty",Toast.LENGTH_SHORT).show();
            isValidationSuccessful=false;
        }else   if(!isValidEmail(et_email.getText().toString())){
           Toast.makeText(MainActivity.this,"Email is not valid",Toast.LENGTH_SHORT).show();
            isValidationSuccessful=false;
        }
        return isValidationSuccessful;
    }

    public boolean isValidEmail(CharSequence target) {
        if (target == null) {
            return false;
        } else {
            return android.util.Patterns.EMAIL_ADDRESS.matcher(target).matches();
        }
    }
}
