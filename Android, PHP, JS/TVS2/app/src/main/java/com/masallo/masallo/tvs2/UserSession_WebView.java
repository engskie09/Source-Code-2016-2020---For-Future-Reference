package com.masallo.masallo.tvs2;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.webkit.WebView;
import android.webkit.WebViewClient;

public class UserSession_WebView extends AppCompatActivity {

    WebView wb_webview;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.layout_usersession_webview);

        wb_webview = (WebView)findViewById(R.id.wb_webview);
        wb_webview.setWebViewClient(new WebViewClient());

        wb_webview.loadUrl("http://trafficviolationsystem.com/");





    }
}
