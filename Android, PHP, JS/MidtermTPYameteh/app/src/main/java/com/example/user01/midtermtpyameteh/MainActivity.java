package com.example.user01.midtermtpyameteh;

import android.content.Context;
import android.media.MediaPlayer;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.view.animation.Animation;
import android.view.animation.AnimationUtils;
import android.widget.ImageButton;

public class MainActivity extends AppCompatActivity {

    ImageButton imgbtn_1, imgbtn_2, imgbtn_3, imgbtn_4, imgbtn_5, imgbtn_6, imgbtn_7, imgbtn_8;
    MediaPlayer mediaPlayer;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        set_control();

        imgbtn_1.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                stopAudio();
                playAssetSound(MainActivity.this, R.raw.audio_1);

                Animation myAnim = AnimationUtils.loadAnimation(MainActivity.this, R.anim.fadeout);
                imgbtn_1.startAnimation(myAnim);


            }
        });

        imgbtn_2.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                stopAudio();
                playAssetSound(MainActivity.this, R.raw.audio_2);

                Animation myAnim = AnimationUtils.loadAnimation(MainActivity.this, R.anim.bounce);
                imgbtn_2.startAnimation(myAnim);


            }
        });

        imgbtn_3.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                stopAudio();
                playAssetSound(MainActivity.this, R.raw.audio_3);

                Animation myAnim = AnimationUtils.loadAnimation(MainActivity.this, R.anim.fadein);
                imgbtn_3.startAnimation(myAnim);


            }
        });

        imgbtn_4.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                stopAudio();
                playAssetSound(MainActivity.this, R.raw.audio_4);

                Animation myAnim = AnimationUtils.loadAnimation(MainActivity.this, R.anim.push_left_out);
                imgbtn_4.startAnimation(myAnim);


            }
        });

        imgbtn_5.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                stopAudio();
                playAssetSound(MainActivity.this, R.raw.audio_5);

                Animation myAnim = AnimationUtils.loadAnimation(MainActivity.this, R.anim.push_down);
                imgbtn_5.startAnimation(myAnim);


            }
        });






        imgbtn_6.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                stopAudio();
                playAssetSound(MainActivity.this, R.raw.audio_6);

                Animation myAnim = AnimationUtils.loadAnimation(MainActivity.this, R.anim.push_right_out);
                imgbtn_6.startAnimation(myAnim);


            }
        });

        imgbtn_7.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                stopAudio();
                playAssetSound(MainActivity.this, R.raw.audio_7);

                Animation myAnim = AnimationUtils.loadAnimation(MainActivity.this, R.anim.push_left_out);
                imgbtn_7.startAnimation(myAnim);


            }
        });


        imgbtn_8.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                stopAudio();
                playAssetSound(MainActivity.this, R.raw.audio_8);

                Animation myAnim = AnimationUtils.loadAnimation(MainActivity.this, R.anim.bounce);
                imgbtn_8.startAnimation(myAnim);


            }
        });


    }

    private void set_control()
    {
        imgbtn_1 = (ImageButton)findViewById(R.id.imgbtn_1);
        imgbtn_2 = (ImageButton)findViewById(R.id.imgbtn_2);
        imgbtn_3 = (ImageButton)findViewById(R.id.imgbtn_3);
        imgbtn_4 = (ImageButton)findViewById(R.id.imgbtn_4);
        imgbtn_5 = (ImageButton)findViewById(R.id.imgbtn_5);

        imgbtn_6 = (ImageButton)findViewById(R.id.imgbtn_6);
        imgbtn_7 = (ImageButton)findViewById(R.id.imgbtn_7);
        imgbtn_8 = (ImageButton)findViewById(R.id.imgbtn_8);
    }

    private void playAssetSound(Context context, int raw) {
        try {
            mediaPlayer = new MediaPlayer();

            mediaPlayer = MediaPlayer.create(context, raw);


            mediaPlayer.start();
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    private void stopAudio()
    {
        if (mediaPlayer != null)
        {
            mediaPlayer.stop();
            mediaPlayer.release();
            mediaPlayer = null;
        }
    }
}