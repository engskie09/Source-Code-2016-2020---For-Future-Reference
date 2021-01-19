package masallo.mobidevcrudsqlitepusangggalaaaaaaxd;

import android.content.Intent;
import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ListView;



import java.util.ArrayList;

public class ListActivity extends AppCompatActivity {

    ListView show_list;
    DataBaseHelper dataBaseHelper;
    ArrayList<RegistrationDataModel> registrationDataModelArrayList=new ArrayList<>();
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_list);
       dataBaseHelper=new DataBaseHelper(this);

        registrationDataModelArrayList= dataBaseHelper.getRegistrationData();
        show_list= (ListView) findViewById(R.id.show_list);

        ListActivityAdapter listActivityAdapter=new ListActivityAdapter(this,registrationDataModelArrayList);
        show_list.setAdapter(listActivityAdapter);
        show_list.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> adapterView, View view, int i, long l) {
                Intent intent=new Intent(ListActivity.this,UpdateActivity.class);
                intent.putExtra("id",registrationDataModelArrayList.get(i).getId());
                intent.putExtra("name",registrationDataModelArrayList.get(i).getName());
                intent.putExtra("email",registrationDataModelArrayList.get(i).getEmail());
                intent.putExtra("address",registrationDataModelArrayList.get(i).getAddress());
                intent.putExtra("phone",registrationDataModelArrayList.get(i).getPhone());
                startActivity(intent);
                finish();


            }
        });



    }

}
