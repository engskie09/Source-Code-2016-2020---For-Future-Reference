package masallo.mobidevcrudsqlitepusangggalaaaaaaxd;

import android.app.Activity;
import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.BaseAdapter;
import android.widget.TextView;



import java.util.ArrayList;



public class ListActivityAdapter extends BaseAdapter {
Activity activity;
    ArrayList<RegistrationDataModel> arrayList = new ArrayList<RegistrationDataModel>();
    LayoutInflater layoutInflater = null;

    public  ListActivityAdapter(Activity activity,ArrayList<RegistrationDataModel> dataModelArrayList){
        this.activity=activity;
        this.arrayList=dataModelArrayList;
        layoutInflater = (LayoutInflater) activity.getSystemService(Context.LAYOUT_INFLATER_SERVICE);
    }
    @Override
    public int getCount() {
        return arrayList.size();
    }

    @Override
    public Object getItem(int i) {
        return arrayList.get(i);
    }

    @Override
    public long getItemId(int i) {
        return i;
    }

    public class ViewHolder{
        TextView tv_name,tv_email,tv_address,tv_phone,tv_regid;
    }
    ViewHolder viewHolder = null;

    @Override
    public View getView(int position, View view, ViewGroup viewGroup) {

        View vi=view;
        final int pos = position;
        if(vi == null){

            // create  viewholder object for list_rowcell View.
            viewHolder = new ViewHolder();
            // inflate list_rowcell for each row
            vi = layoutInflater.inflate(R.layout.list_rowcell,null);
            viewHolder.tv_name = (TextView) vi.findViewById(R.id.tv_name);
            viewHolder.tv_email = (TextView) vi.findViewById(R.id.tv_email);
            viewHolder.tv_address = (TextView) vi.findViewById(R.id.tv_address);
            viewHolder.tv_phone = (TextView) vi.findViewById(R.id.tv_phone);
            viewHolder.tv_regid = (TextView) vi.findViewById(R.id.tv_regid);


            vi.setTag(viewHolder);
        }else {

             /* We recycle a View that already exists */
            viewHolder= (ViewHolder) vi.getTag();
        }


        viewHolder.tv_name.setText(arrayList.get(pos).getName());
        viewHolder.tv_phone.setText(arrayList.get(pos).getPhone());
        viewHolder.tv_address.setText(arrayList.get(pos).getAddress());
        viewHolder.tv_email.setText(arrayList.get(pos).getEmail());
        viewHolder.tv_regid.setText(arrayList.get(pos).getId());

        return vi;

    }
}
