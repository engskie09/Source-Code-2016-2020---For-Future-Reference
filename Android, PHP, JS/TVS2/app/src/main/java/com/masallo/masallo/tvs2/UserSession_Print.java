package com.masallo.masallo.tvs2;

import android.app.Activity;
import android.app.ProgressDialog;
import android.bluetooth.BluetoothAdapter;
import android.bluetooth.BluetoothDevice;
import android.bluetooth.BluetoothSocket;
import android.content.Intent;
import android.graphics.Color;
import android.os.Bundle;
import android.os.Handler;
import android.os.Message;
import android.support.v7.app.AlertDialog;
import android.support.v7.app.AppCompatActivity;
import android.util.Log;
import android.view.View;
import android.view.WindowManager;
import android.widget.Button;
import android.widget.EditText;
import android.widget.LinearLayout;
import android.widget.TextView;
import android.widget.Toast;

import java.io.IOException;
import java.io.OutputStream;
import java.nio.ByteBuffer;
import java.util.Set;
import java.util.UUID;

import me.anwarshahriar.calligrapher.Calligrapher;

public class UserSession_Print extends AppCompatActivity implements Runnable {

    protected static final String TAG = "TAG";
    private static final int REQUEST_CONNECT_DEVICE = 1;
    private static final int REQUEST_ENABLE_BT = 2;
    Button mScan, mPrint;


    BluetoothAdapter mBluetoothAdapter;
    private UUID applicationUUID = UUID
            .fromString("00001101-0000-1000-8000-00805F9B34FB");
    private ProgressDialog mBluetoothConnectProgressDialog;
    private BluetoothSocket mBluetoothSocket;
    BluetoothDevice mBluetoothDevice;


    TextView stat;
    LinearLayout layout;
    TextView tvid;

    TextView tv_offenderQueueingNumber, tv_offenderFullName, tv_offenderFee;

    EditText et_officerName;

    public static String get_QueueingNumber, get_offenderFullName, get_offenderFee;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.layout_usersession_print);

        //Calligrapher calligrapher = new Calligrapher(this);
        //calligrapher.setFont(this,"fonts/abel-regular.ttf", true );
        stat = (TextView)findViewById(R.id.bpstatus);

        getWindow().setSoftInputMode(WindowManager.LayoutParams.SOFT_INPUT_STATE_HIDDEN);


        tv_offenderQueueingNumber = (TextView)findViewById(R.id.tv_offenderQueueingNumber);
        tv_offenderFullName = (TextView)findViewById(R.id.tv_offenderFullName);
        tv_offenderFee = (TextView)findViewById(R.id.tv_offenderFee);
        et_officerName = (EditText) findViewById(R.id.et_officerName);

        tv_offenderQueueingNumber.setText("000"+get_QueueingNumber);
        tv_offenderFullName.setText(get_offenderFullName);
        tv_offenderFee.setText(get_offenderFee);


        mScan = (Button)findViewById(R.id.Scan);
        mScan.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View mView) {

                if(mScan.getText().equals("Connect"))
                {
                    mBluetoothAdapter = BluetoothAdapter.getDefaultAdapter();
                    if (mBluetoothAdapter == null) {
                        Toast.makeText(UserSession_Print.this, "Message1", Toast.LENGTH_SHORT).show();
                    }

                    else {
                        if (!mBluetoothAdapter.isEnabled()) {
                            Intent enableBtIntent = new Intent(
                                    BluetoothAdapter.ACTION_REQUEST_ENABLE);
                            startActivityForResult(enableBtIntent,
                                    REQUEST_ENABLE_BT);
                        }

                        else {
                            ListPairedDevices();
                            Intent connectIntent = new Intent(UserSession_Print.this, DeviceListActivity.class);
                            startActivityForResult(connectIntent, REQUEST_CONNECT_DEVICE);

                        }
                    }

                }
                else if(mScan.getText().equals("Disconnect"))
                {
                    if (mBluetoothAdapter != null)
                        mBluetoothAdapter.disable();
                    stat.setText("");
                    stat.setText("Disconnected");
                    stat.setTextColor(Color.rgb(199, 59, 59));
                    mPrint.setEnabled(false);
                    mScan.setEnabled(true);
                    mScan.setText("Connect");
                }
            }
        });




        mPrint = (Button) findViewById(R.id.mPrint);
        mPrint.setOnClickListener(new View.OnClickListener() {
            public void onClick(View View) {


                p1();

            }
        });

    }



    public void p1(){

        Thread t = new Thread() {
            public void run() {
                try {
                    OutputStream os = mBluetoothSocket
                            .getOutputStream();


                    //os.write("".getBytes());
                    os.write(String.valueOf("================================" + "\n").getBytes());
                    os.write(String.valueOf("================================" + "\n").getBytes());
                    os.write(String.valueOf("***Ordinance Violation Receipt***" + "\n").getBytes());
                    os.write(String.valueOf("Driver Name:" + "\n").getBytes());
                    os.write(String.valueOf(get_offenderFullName + "\n").getBytes());
                    os.write(String.valueOf("Queueing Number:" +"000"+ get_QueueingNumber + "\n").getBytes());
                    os.write(String.valueOf("Fee: " +  get_offenderFee + " Pesos" + "\n").getBytes());
                    os.write(String.valueOf("" + "\n").getBytes());
                    os.write(String.valueOf("" + "\n").getBytes());
                    os.write(String.valueOf("" + "\n").getBytes());
                    os.write(String.valueOf("__________"+et_officerName.getText().toString()+"_________" + "\n").getBytes());
                    os.write(String.valueOf("Signature of Attending Officer" + "\n").getBytes());
                    os.write(String.valueOf("" + "\n").getBytes());
                    os.write(String.valueOf("" + "\n").getBytes());
                    os.write(String.valueOf("" + "\n").getBytes());
                    os.write(String.valueOf("" + "\n").getBytes());


                    //This is printer specific code you can comment ==== > Start

                    // Setting height
                    int gs = 29;
                    os.write(intToByteArray(gs));
                    int h = 104;
                    os.write(intToByteArray(h));
                    int n = 162;
                    os.write(intToByteArray(n));

                    // Setting Width
                    int gs_width = 29;
                    os.write(intToByteArray(gs_width));
                    int w = 119;
                    os.write(intToByteArray(w));
                    int n_width = 2;
                    os.write(intToByteArray(n_width));


                } catch (Exception e) {
                    Log.e("PrintActivity", "Exe ", e);
                }
            }
        };
        t.start();
    }


    @Override
    protected void onDestroy() {
        // TODO Auto-generated method stub
        super.onDestroy();
        try {
            if (mBluetoothSocket != null)
                mBluetoothSocket.close();
        } catch (Exception e) {
            Log.e("Tag", "Exe ", e);
        }
    }


    public void onActivityResult(int mRequestCode, int mResultCode,
                                 Intent mDataIntent) {
        super.onActivityResult(mRequestCode, mResultCode, mDataIntent);

        switch (mRequestCode) {
            case REQUEST_CONNECT_DEVICE:
                if (mResultCode == Activity.RESULT_OK) {
                    Bundle mExtra = mDataIntent.getExtras();
                    String mDeviceAddress = mExtra.getString("DeviceAddress");
                    Log.v(TAG, "Coming incoming address " + mDeviceAddress);
                    mBluetoothDevice = mBluetoothAdapter
                            .getRemoteDevice(mDeviceAddress);
                    mBluetoothConnectProgressDialog = ProgressDialog.show(this,
                            "Connecting...", mBluetoothDevice.getName() + " : "
                                    + mBluetoothDevice.getAddress(), true, false);
                    Thread mBlutoothConnectThread = new Thread(this);
                    mBlutoothConnectThread.start();
                    // pairToDevice(mBluetoothDevice); This method is replaced by
                    // progress dialog with thread
                }
                break;

            case REQUEST_ENABLE_BT:
                if (mResultCode == Activity.RESULT_OK) {
                    ListPairedDevices();
                    Intent connectIntent = new Intent(UserSession_Print.this,
                            DeviceListActivity.class);
                    startActivityForResult(connectIntent, REQUEST_CONNECT_DEVICE);
                } else {
                    Toast.makeText(UserSession_Print.this, "Message", Toast.LENGTH_SHORT).show();
                }
                break;
        }
    }

    private void ListPairedDevices() {
        Set<BluetoothDevice> mPairedDevices = mBluetoothAdapter
                .getBondedDevices();
        if (mPairedDevices.size() > 0) {
            for (BluetoothDevice mDevice : mPairedDevices) {
                Log.v(TAG, "PairedDevices: " + mDevice.getName() + "  "
                        + mDevice.getAddress());
            }
        }
    }

    public void run() {
        try {
            mBluetoothSocket = mBluetoothDevice
                    .createRfcommSocketToServiceRecord(applicationUUID);
            mBluetoothAdapter.cancelDiscovery();
            mBluetoothSocket.connect();
            mHandler.sendEmptyMessage(0);
        } catch (IOException eConnectException) {
            Log.d(TAG, "CouldNotConnectToSocket", eConnectException);
            closeSocket(mBluetoothSocket);
            return;
        }
    }

    private void closeSocket(BluetoothSocket nOpenSocket) {
        try {
            nOpenSocket.close();
            Log.d(TAG, "SocketClosed");
        } catch (IOException ex) {
            Log.d(TAG, "CouldNotCloseSocket");
        }
    }


    private Handler mHandler = new Handler() {
        @Override
        public void handleMessage(Message msg) {
            mBluetoothConnectProgressDialog.dismiss();

            // Snackbar snackbar = Snackbar.make(layout, "Bluetooth Printer is Connected!", Snackbar.LENGTH_LONG);
            // snackbar.show();
            stat.setText("");
            stat.setText("Connected");
            stat.setTextColor(Color.rgb(97, 170, 74));
            mPrint.setEnabled(true);
            mScan.setText("Disconnect");
            //mDisc.setEnabled(true);
            //mDisc.setBackgroundColor(Color.rgb(0, 0, 0));
            //mScan.setEnabled(false);
            //mScan.setBackgroundColor(Color.rgb(161, 161, 161));

        }
    };

    public static byte intToByteArray(int value) {
        byte[] b = ByteBuffer.allocate(4).putInt(value).array();

        for (int k = 0; k < b.length; k++) {
            System.out.println("Selva  [" + k + "] = " + "0x"
                    + UnicodeFormatter.byteToHex(b[k]));
        }

        return b[3];
    }

    public byte[] sel(int val) {
        ByteBuffer buffer = ByteBuffer.allocate(2);
        buffer.putInt(val);
        buffer.flip();
        return buffer.array();
    }





}
