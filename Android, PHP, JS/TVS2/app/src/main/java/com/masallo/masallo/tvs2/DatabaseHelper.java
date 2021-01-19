package com.masallo.masallo.tvs2;

import android.content.ContentValues;
import android.content.Context;
import android.database.Cursor;
import android.database.sqlite.SQLiteDatabase;
import android.database.sqlite.SQLiteOpenHelper;

public class DatabaseHelper extends SQLiteOpenHelper {
    public static final String database_name = "db_offender";
    public static final String table_name = "tbl_offender";
    public static final String column_1 = "offender_FirstName";
    public static final String column_2 = "offender_MiddleName";
    public static final String column_3 = "offender_LastName";

    public static final String column_4 = "offender_Address";
    public static final String column_5 = "offender_LicenseNumber";
    public static final String column_6 = "offender_PlateNumber";

    public static final String column_7 = "vehicle_Type";
    public static final String column_8 = "vehicle_Status";

    public static final String column_9 = "offense_Name";
    public static final String column_10 = "offense_Fee";
    public static final String column_11 = "offense_Penalty";
    public static final String column_12 = "offense_Class";
    public static final String column_13 = "offense_Code";
    public static final String column_14 = "offense_Date";

    public DatabaseHelper(Context context)
    {
        super(context, database_name, null, 1);
        SQLiteDatabase db = this.getWritableDatabase();
    }

    @Override
    public void onCreate(SQLiteDatabase db) {
        db.execSQL("CREATE TABLE " + table_name + " (ID INTEGER PRIMARY KEY AUTOINCREMENT, offender_FirstName TEXT, offender_MiddleName TEXT, offender_LastName TEXT, " +
                   "offender_Address TEXT, offender_LicenseNumber TEXT, offender_PlateNumber TEXT, vehicle_Type TEXT, vehicle_Status TEXT, " +
                   "offense_Name TEXT, offense_Fee TEXT, offense_Penalty TEXT, offense_Class TEXT, offense_Code TEXT, offense_Date TEXT)");
    }

    @Override
    public void onUpgrade(SQLiteDatabase db, int oldVersion, int newVersion) {
        db.execSQL("DROP TABLE IF EXISTS " + table_name);
        onCreate(db);
    }

    public boolean insertData(String row_1, String row_2, String row_3, String row_4, String row_5, String row_6, String row_7, String row_8, String row_9,
                              String row_10, String row_11, String row_12, String row_13, String row_14)
    {
        SQLiteDatabase db = this.getWritableDatabase();

        ContentValues contentValues = new ContentValues();
        contentValues.put(column_1, row_1);
        contentValues.put(column_2, row_2);
        contentValues.put(column_3, row_3);
        contentValues.put(column_4, row_4);
        contentValues.put(column_5, row_5);
        contentValues.put(column_6, row_6);
        contentValues.put(column_7, row_7);
        contentValues.put(column_8, row_8);
        contentValues.put(column_9, row_9);
        contentValues.put(column_10, row_10);
        contentValues.put(column_11, row_11);
        contentValues.put(column_12, row_12);
        contentValues.put(column_13, row_13);
        contentValues.put(column_14, row_14);

        long result = db.insert(table_name, null, contentValues);

        if (result == -1)
            return false;
        else
            return true;
    }

    public Cursor getAllData()
    {
        SQLiteDatabase db = this.getWritableDatabase();
        Cursor cursor = db.rawQuery("SELECT * FROM " + table_name, null);
        return cursor;
    }



}
