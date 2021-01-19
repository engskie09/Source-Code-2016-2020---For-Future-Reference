package com.masallo.masallo.tvs2;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ListView;
import android.widget.SimpleAdapter;
import android.widget.Toast;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;

public class UserSession_ListOffender extends AppCompatActivity {

    List<HashMap<String, Object>> aList;

    ListView lv_offender;

    DatabaseHelper myDB;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.layout_usersession_listoffender);

        lv_offender = (ListView)findViewById(R.id.lv_offender);

        myDB = new DatabaseHelper(this);

        set_offender_list();


        lv_offender.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> parent, View view, int position, long id) {

                Intent intent = new Intent(getBaseContext(), UserSession_Print.class);
                startActivity(intent);

                UserSession_Print.get_QueueingNumber = SystemMethods_UserSession.get_offenderQueueingNumber.get(position);
                UserSession_Print.get_offenderFullName = SystemMethods_UserSession.get_offenderFirstName.get(position) + ", " + SystemMethods_UserSession.get_offenderMiddleName.get(position)
                                                + ", " + SystemMethods_UserSession.get_offenderLastName.get(position);
                UserSession_Print.get_offenderFee = SystemMethods_UserSession.get_offenseFee.get(position);


            }
        });


    }

    private void set_offender_list()
    {
        try
        {
            SystemMethods_UserSession.set_ListValue(myDB);


            aList = new ArrayList<>();

            for (int i = 0; i < SystemMethods_UserSession.get_offenderQueueingNumber.size(); i ++)
            {
                HashMap<String, Object> hashMap = new HashMap<>();

                hashMap.put("get_offenderQueueingNumber", SystemMethods_UserSession.get_offenderQueueingNumber.get(i));
                hashMap.put("get_offenderName", String.valueOf(SystemMethods_UserSession.get_offenderFirstName.get(i) + "," +SystemMethods_UserSession.get_offenderLastName.get(i)));


                aList.add(hashMap);
            }

            String[] from = {"get_offenderQueueingNumber", "get_offenderName"};
            int [] to = {R.id.tv_offenderQueueingNumber, R.id.tv_offenderName};

            SimpleAdapter simpleAdapter = new SimpleAdapter(getBaseContext(), aList, R.layout.gridview_offenders, from, to);

            lv_offender.setAdapter(simpleAdapter);

        }

        catch (Exception e)
        {
            Toast.makeText(getBaseContext(), e.toString(), Toast.LENGTH_SHORT).show();
        }
    }
}
