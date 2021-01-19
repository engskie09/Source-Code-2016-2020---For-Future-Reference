package com.devglan.sqlitedatabase.database;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;
import android.util.Log;

import com.devglan.sqlitedatabase.datamodel.RegistrationDataModel;

import java.util.ArrayList;

/**
 * Created by sanjeevksaroj on 4/4/17.
 */

public class DataBaseHelper extends SQLiteOpenHelper {
    Context mContext;

    //data base version
    private static final int DATABASE_VERSION = 1;
    // Database Name
    private static final String DATABASE_NAME = "devglan_database.db";
    //data base field name
    private static final String FULL_NAME = "full_name";
    private static final String EMAIL_ADDRESS = "email_address";
    private static final String _ADDRESS = "_address";
    private static final String PHONE_NUMBER = "phone";

    //table name
    private static final String REG_TABLE = " reg_table";
    private static final String _ID = "_id";


    public DataBaseHelper(Context context) {
        super(context, DATABASE_NAME, null, DATABASE_VERSION);
        mContext = context;
    }

    private static final String CREATE_TABLE_TBL_REGISTRATION = "CREATE TABLE" + REG_TABLE + "" +
            "(" + _ID + " INTEGER PRIMARY KEY AUTOINCREMENT ," + FULL_NAME + " TEXT NOT NULL,"
            + EMAIL_ADDRESS + " TEXT NOT NULL,"  + _ADDRESS + " TEXT NOT NULL," + PHONE_NUMBER + " TEXT NOT NULL"+ ")";


    @Override
    public void onCreate(SQLiteDatabase sqLiteDatabase) {
        sqLiteDatabase.execSQL(CREATE_TABLE_TBL_REGISTRATION);
    }

    @Override
    public void onUpgrade(SQLiteDatabase sqLiteDatabase, int oldversion, int newversion) {
        sqLiteDatabase.execSQL("DROP TABLE IF EXISTS" + CREATE_TABLE_TBL_REGISTRATION);

        onCreate(sqLiteDatabase);
    }

    public  void addRegistrationData(RegistrationDataModel registrationDataModel){

        SQLiteDatabase db = this.getWritableDatabase();
        ContentValues cv=new ContentValues();
        cv.put(FULL_NAME,registrationDataModel.getName());
        cv.put(EMAIL_ADDRESS,registrationDataModel.getEmail());
        cv.put(_ADDRESS,registrationDataModel.getAddress());
        cv.put(PHONE_NUMBER,registrationDataModel.getPhone());
        // Inserting Row
        db.insert(REG_TABLE, null, cv);
        db.close(); // Closing database connection

    }

    public ArrayList<RegistrationDataModel> getRegistrationData(){
        String selectQuery = "SELECT  * FROM " + REG_TABLE;
        SQLiteDatabase db = this.getReadableDatabase();

        Cursor cursor = db.rawQuery(selectQuery,null,null);
        ArrayList<RegistrationDataModel> dataModelArrayList = new ArrayList<RegistrationDataModel>();
        if(cursor.moveToFirst()){
            do {
                RegistrationDataModel regdm=new RegistrationDataModel();
                regdm.setName(cursor.getString(cursor.getColumnIndex(FULL_NAME)));
                regdm.setEmail(cursor.getString(cursor.getColumnIndex(EMAIL_ADDRESS)));
                regdm.setAddress(cursor.getString(cursor.getColumnIndex(_ADDRESS)));
                regdm.setPhone(cursor.getString(cursor.getColumnIndex(PHONE_NUMBER)));
                regdm.setId(cursor.getString(cursor.getColumnIndex(_ID)));
                dataModelArrayList.add(regdm);

            } while (cursor.moveToNext());

        }
        cursor.close();
        db.close();


        return dataModelArrayList;
    }


    public void updateRegistrationdata(RegistrationDataModel registrationDataModel) {
        SQLiteDatabase db = this.getWritableDatabase();
        ContentValues contentValues = new ContentValues();
        contentValues.put(FULL_NAME, registrationDataModel.getName());
        contentValues.put(EMAIL_ADDRESS, registrationDataModel.getEmail());
        contentValues.put(_ADDRESS, registrationDataModel.getAddress());
        contentValues.put(PHONE_NUMBER, registrationDataModel.getPhone());

        db.update(REG_TABLE, contentValues, _ID + " = ?", new String[]{"" + registrationDataModel.getId()});

        db.close();
    }
    public void deleteRegdata() {
        SQLiteDatabase db = this.getReadableDatabase();
        db.delete(REG_TABLE, null, null);
        db.close();
    }


}
