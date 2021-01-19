package com.devglan.sqlitedatabase;

import android.content.Intent;
import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

import com.devglan.sqlitedatabase.database.DataBaseHelper;
import com.devglan.sqlitedatabase.datamodel.RegistrationDataModel;

import java.util.ArrayList;

public class UpdateActivity extends AppCompatActivity {

    TextView tv_name,tv_email,tv_address,tv_phone,tv_update,tv_regid,tv_delete;
    EditText et_name,et_email,et_address,et_phone,et_regid;
    DataBaseHelper dataBaseHelper;
    String registration="";
    String name="";
    String email="";
    String address="";
    String phone="";
    ArrayList<RegistrationDataModel> registrationDataModelArrayList=new ArrayList<>();
    RegistrationDataModel regDmodel;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_update);
        dataBaseHelper=new DataBaseHelper(this);
        registration=getIntent().getExtras().getString("id");
        name=getIntent().getExtras().getString("name");
        email=getIntent().getExtras().getString("email");
        address=getIntent().getExtras().getString("address");
        phone=getIntent().getExtras().getString("phone");


        initView();
    }


    public void initView(){
        tv_name= (TextView) findViewById(R.id.tv_name);
        tv_email= (TextView) findViewById(R.id.tv_email);
        tv_address= (TextView) findViewById(R.id.tv_address);
        tv_phone= (TextView) findViewById(R.id.tv_phone);
        tv_regid= (TextView) findViewById(R.id.tv_regid);
        tv_update= (TextView) findViewById(R.id.tv_update);
        tv_delete= (TextView) findViewById(R.id.tv_delete);
        et_name= (EditText) findViewById(R.id.et_name);
        et_email= (EditText) findViewById(R.id.et_email);
        et_address= (EditText) findViewById(R.id.et_address);
        et_phone= (EditText) findViewById(R.id.et_phone);
        et_regid= (EditText) findViewById(R.id.et_regid);
        et_regid.setText(registration);
        et_name.setText(name);
        et_email.setText(email);
        et_address.setText(address);
        et_phone.setText(phone);

        tv_update.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {

                // save data in data base
                if(validateField()){
                    String name=et_name.getText().toString();
                    String address=et_address.getText().toString();
                    String phone=et_phone.getText().toString();
                    String email=et_email.getText().toString();
                    String regid=et_regid.getText().toString();
                    regDmodel=new RegistrationDataModel();
                    regDmodel.setName(name);
                    regDmodel.setEmail(email);
                    regDmodel.setAddress(address);
                    regDmodel.setPhone(phone);
                    regDmodel.setId(regid);
                    dataBaseHelper.updateRegistrationdata(regDmodel);
                    registrationDataModelArrayList= dataBaseHelper.getRegistrationData();
                    if(registrationDataModelArrayList.size()>0){
                        Intent intent=new Intent(UpdateActivity.this,ListActivity.class);
                        startActivity(intent);
                        finish();
                    }else {
                        Toast.makeText(UpdateActivity.this,"No Record to Update",Toast.LENGTH_SHORT).show();
                    }




                }
            }
        });

            tv_delete.setOnClickListener(new View.OnClickListener() {
                @Override
                public void onClick(View view) {
                    registrationDataModelArrayList= dataBaseHelper.getRegistrationData();
                    if(registrationDataModelArrayList.size()>0){
                    dataBaseHelper.deleteRegdata();

                }else {
                        Toast.makeText(UpdateActivity.this,"Registration data deleted",Toast.LENGTH_SHORT).show();
                }
                }
            });
        }




    public boolean validateField(){

        boolean isValidationSuccessful = true;

        if(et_name.getText().toString().trim().equalsIgnoreCase("")){
            Toast.makeText(UpdateActivity.this,"Name can't be empty",Toast.LENGTH_SHORT).show();
            isValidationSuccessful=false;

        } else if(et_email.getText().toString().trim().equalsIgnoreCase("")  ){
            Toast.makeText(UpdateActivity.this,"Email  can't be empty", Toast.LENGTH_SHORT).show();
            isValidationSuccessful=false;
        } else   if(et_address.getText().toString().trim().equalsIgnoreCase("")){
            Toast.makeText(UpdateActivity.this,"Address can't be empty",Toast.LENGTH_SHORT).show();
            isValidationSuccessful=false;
        }else   if(et_phone.getText().toString().trim().equalsIgnoreCase("")){
            Toast.makeText(UpdateActivity.this,"Phone can't be empty",Toast.LENGTH_SHORT).show();
            isValidationSuccessful=false;
        }else   if(!isValidEmail(et_email.getText().toString())){
            Toast.makeText(UpdateActivity.this,"Email is not valid",Toast.LENGTH_SHORT).show();
            isValidationSuccessful=false;
        }else if (et_regid.getText().toString().trim().equalsIgnoreCase("")){
            Toast.makeText(UpdateActivity.this,"Registration id can't be empty",Toast.LENGTH_SHORT).show();
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
