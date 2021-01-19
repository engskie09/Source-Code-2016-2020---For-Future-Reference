package com.example.user01.mobidev_finals_tp;

import android.content.Context;
import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.ListView;
import android.widget.SimpleAdapter;
import android.widget.Toast;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;

public class LoginSession extends AppCompatActivity {

    private Button btn_Login;
    private Button btn_Signup;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_login_session);

        btn_Login = (Button) findViewById(R.id.btn_Login);
        btn_Signup = (Button) findViewById(R.id.btn_Signup);

        btn_Login.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                SystemMethods_General.open_customer_session_main(LoginSession.this);



            }
        });

        btn_Signup.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                SystemMethods_General.open_sign_up_session(LoginSession.this);

            }
        });

    }


}
