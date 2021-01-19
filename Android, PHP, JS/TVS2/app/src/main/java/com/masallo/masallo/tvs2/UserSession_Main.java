package com.masallo.masallo.tvs2;

import android.content.Intent;
import android.net.Uri;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.Button;
import android.widget.Spinner;

public class UserSession_Main extends AppCompatActivity {

    Button btn_Online, btn_Offline;



    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.layout_usersession_main);

        btn_Online = (Button)findViewById(R.id.btn_Online);
        btn_Offline = (Button)findViewById(R.id.btn_Offline);
        btn_Online.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                /*Intent intent = new Intent(getBaseContext(), UserSession_WebView.class);
                startActivity(intent);*/

                Intent browserIntent = new Intent(
                        Intent.ACTION_VIEW,
                        Uri.parse("http://trafficviolationsystem.com/"));
                startActivity(browserIntent);

            }
        });

        btn_Offline.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intent = new Intent(getBaseContext(), UserSession_OffenseEntry.class);
                startActivity(intent);
            }
        });

    }

}
