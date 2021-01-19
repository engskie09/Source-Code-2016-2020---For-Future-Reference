package com.masallo.user01.masalloprefinalsquiz;

import android.content.DialogInterface;
import android.support.v7.app.AlertDialog;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.RadioButton;
import android.widget.RadioGroup;
import android.widget.TextView;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity {

    private Integer set_currentScore = 0 ;
    private Integer set_currentQuestion = 0 ;

    private String set_correctAnswerSelected;

    TextView tv_setQuestion;

    RadioButton rdbtn_getAnswerA, rdbtn_getAnswerB, rdbtn_getAnswerC, rdbtn_getAnswerD, rdbtn_getAnswerSelected;

    RadioGroup rdgrp_getAnswer;

    Button btn_Answer;

    int selectedId;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);


        tv_setQuestion = (TextView)findViewById(R.id.tv_setQuestion);


        rdbtn_getAnswerA = (RadioButton)findViewById(R.id.rdbtn_getAnswerA);
        rdbtn_getAnswerB = (RadioButton)findViewById(R.id.rdbtn_getAnswerB);
        rdbtn_getAnswerC = (RadioButton)findViewById(R.id.rdbtn_getAnswerC);
        rdbtn_getAnswerD = (RadioButton)findViewById(R.id.rdbtn_getAnswerD);

        rdgrp_getAnswer = (RadioGroup)findViewById(R.id.rdgrp_getAnswer);

        btn_Answer = (Button)findViewById(R.id.btn_Answer);


        set_Question();

        btn_Answer.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {

                if (btn_Answer.getText().toString().equals("Done"))
                {
                    set_currentScore = 0;
                    set_currentQuestion = 0;

                    set_Question();

                    btn_Answer.setText("Next");

                    return;
                }

                selectedId = rdgrp_getAnswer.getCheckedRadioButtonId();

                rdbtn_getAnswerSelected = (RadioButton)findViewById(selectedId);

                set_Answer(rdbtn_getAnswerSelected.getText().toString());

                set_Question();

            }
        });
    }

    private void set_Questioner(String set_Question, String set_AnswerA, String set_AnswerB, String set_AnswerC, String set_AnswerD, String set_CorrectAnswer)
    {
        tv_setQuestion.setText(set_Question);

        rdbtn_getAnswerA.setText(set_AnswerA);
        rdbtn_getAnswerB.setText(set_AnswerB);
        rdbtn_getAnswerC.setText(set_AnswerC);
        rdbtn_getAnswerD.setText(set_AnswerD);

        set_correctAnswerSelected = set_CorrectAnswer;

        set_currentQuestion++;

        //Toast.makeText(this, set_currentQuestion.toString(), Toast.LENGTH_SHORT).show();
    }

    private void set_Answer(String set_currentAnswer)
    {
        if (set_currentAnswer.equals(set_correctAnswerSelected))
        {
            set_currentScore++;
            Toast.makeText(this, "Correct", Toast.LENGTH_SHORT).show();
        }

        else
            Toast.makeText(this, "Wrong", Toast.LENGTH_SHORT).show();

    }

    private void set_Question()
    {

        /*//MasalloPrefinalsQuiz
        if (set_currentQuestion == 0)
            set_Questioner("How Many people in the phelepens?", "Many Many", "So Many People", "Basta Marameeee", "So Many Filipinosss!", "Many Many");

        else if (set_currentQuestion == 1)
            set_Questioner("Who`s delima first Crush?", "Nori", "Dayang", "Duterteee", "Jonellll", "Jonellll");

        else if (set_currentQuestion  == 2)
            set_Questioner("Pogi ba si sir Nava?", "Oo", "Hindi", "Oo", "Hindi", "Oo");

        else if (set_currentQuestion  == 3)
            set_Questioner("Ano mas nauna itlog o Manok?", "Manok", "Itlog", "Sir Nava", "Wala sa nabanggit", "Sir Nava");

        else if (set_currentQuestion  == 4)
            set_Questioner("Anong title ng pambansang awit ng Pilipinas?", "Bayang Magiliw", "Lupang Hinirang", "Sir Nava", "Wala sa nabanggit", "Lupang Hinirang");

        else if (set_currentQuestion  == 5)
            set_Questioner("May pasok ba Multisys?", "Malamang", "Oo meron", "Siguro", "Huwag kana Pumasok.", "Malamang");

        else if (set_currentQuestion  == 6)
            set_Questioner("Sino ang Dean ng BSIT?", "Sir Nava", "Maam Claour", "Maam Dafon", "Dean Masallo", "Maam Claour");

        else if (set_currentQuestion  == 7)
            set_Questioner("Mataas kapag nakatayo, mababa kapag nakaupo.", "Aso", "Tao", "Sir Nava", "Wala sa nabanggit", "Sir Nava");

        else if (set_currentQuestion  == 8)
            set_Questioner("5x5=?", "25", "30", "40", "70", "25");

        else if (set_currentQuestion  == 9)
            set_Questioner("Dalawang batong maitim, malayo ang dinarating.", "Ilong", "Mata", "Tainga", "Pisngi", "Mata");

        else if (set_currentQuestion  == 10)
            set_Questioner("Pinakamagaling na Prof sa STI?", "Sir Nava", "Sir Nava", "Sir Nava", "Sir Nava", "Sir Nava");

*/

        //DennisGloria
        /*if (set_currentQuestion == 0)
            set_Questioner("Diariong Tagalog was founded by", "Marcelo del Pilar", "Juan Luna", "Pedro Laktaw", "Gregorio Sanciano", "Marcelo del Pilar");

        else if (set_currentQuestion == 1)
            set_Questioner("Who was the president of the Associacion La Solidaridad?", "Jose Ma. Panganiban", "Mariano Ponce", "Manuel Sta. Maria", "Galiciano Apacible", "Galiciano Apacible");

        else if (set_currentQuestion == 2)
            set_Questioner("The political section of the Asociacion Hispano-Filipino was under the charge of", "Jose Rizal", "Marcelo del Pilar", "Dominador Gomez", "Tomas Arejola", "Marcelo del Pilar");

        else if (set_currentQuestion == 3)
            set_Questioner("The rightist wing of La Liga came to be called", "Cuerpos de Propagandistas", "Cuerpos de Compromisarios", "Cuerpos de Militantes", "Cuerpos de la Revolucionarios", "Cuerpos de Compromisarios");

        else if (set_currentQuestion == 4)
            set_Questioner("The pen name Taga-Ilog was associated with", "Antonio Luna", "Mariano Ponce", "Jose Ma. Panganiban", "Juan Luna", "Juan Luna");

        else if (set_currentQuestion == 5)
            set_Questioner("Who was the founder of the KKK?", "Emilio Aguinaldo", "Jose Rizal", "Andres Bonifacio", "Confederate Army", "Andres Bonifacio");

        else if (set_currentQuestion == 6)
            set_Questioner("Considered as the first Philippine hero.", "Ferdinand Magellan", "Lapu-Lapu", "King Philip II of Spain", "Jose Rizal", "Lapu-Lapu");

        else if (set_currentQuestion == 7)
            set_Questioner("What is the Smallest living organism?", "Ant", "Ant", "Mycoplasma", "None of the Above", "Mycoplasma");

        else if (set_currentQuestion == 8)
            set_Questioner("where does  STI college caloocan  located?", "Valenzuela", "Quezon", "Caloocan", "None of the Above", "Caloocan");

        else if (set_currentQuestion == 9)
            set_Questioner("What is The software use to make this application?", "Mobile legends", "Dota2", "Counter Strike GO", "Android Studio", "Android Studio");


*/


            //Kierbs

        if (set_currentQuestion == 0)
            set_Questioner("Who is the Author of Florante at Laura?", "Francisco Balagtas", "Jose Rizal", "Andres Bonifacio", "None of the Above", "Francisco Balagtas");

        else if (set_currentQuestion == 1)
            set_Questioner("Who is our National Hero?", "Jose Rizal", "Emilio Aguinaldo", "Juan Luna", "None of the Above", "Jose Rizal");

        else if (set_currentQuestion == 2)
            set_Questioner("What is our National Anthem?", "Bayang Magiliw", "Kung di rin lang ikaw", "Lupang Hinirang", "None of the Above", "Lupang Hinirang");

        else if (set_currentQuestion == 3)
            set_Questioner("What is The software use to make this application?", "Mobile legends", "Dota2", "Counter Strike GO", "Android Studio", "Android Studio");

        else if (set_currentQuestion == 4)
            set_Questioner("who is the richest man in the world?", "Mark Zuckerberg", "Jeff Bezos", "Henry Sy", "None of the Above", "Jeff Bezos");

        else if (set_currentQuestion == 5)
            set_Questioner("What is the hardest mineral?", "Topaz", "Diamond", "Quartz", "Gypsum", "Diamond");

        else if (set_currentQuestion == 6)
            set_Questioner("What is the tallest Building in the world?", "Eiffel Tower", "Mia Khalifa", "Burj Khalifa", "Shanghai Tower", "Burj Khalifa");

        else if (set_currentQuestion == 7)
            set_Questioner("What is the Smallest living organism?", "Ant", "Ant", "Mycoplasma", "None of the Above", "Mycoplasma");

        else if (set_currentQuestion == 8)
            set_Questioner("where does  STI college caloocan  located?", "Valenzuela", "Quezon", "Caloocan", "None of the Above", "Caloocan");

        else if (set_currentQuestion == 9)
            set_Questioner("Who is the most subscribed youtuber in the world?", "PewDiePie", "Filthy Frank", "Jamill", "None of the Above", "PewDiePie");

        else if (set_currentQuestion == 10)
            set_Questioner("What is the nearest planet to Sun?", "Venus", "Saturn", "Pluto", "Uranus", "Venus");



        /*if (set_currentQuestion == 0)
            set_Questioner("he is the first commonwealth president of the philippines", "MANUEL L QUEZON", "Diosdado macapagal", "Joneeellll", "carlo p garcia", "MANUEL L QUEZON");

        else if (set_currentQuestion == 1)
            set_Questioner("how many island does philippines had?", "1100", "2107", "1107", "107", "1107");

        else if (set_currentQuestion == 2)
            set_Questioner("largest country in the world?", "america", "RUSSIA", "china", "russia", "RUSSIA");

        else if (set_currentQuestion == 3)
            set_Questioner("the coldest part of earth", "antartica", "siberia", "america", "NORTH POLE", "NORTH POLE");

        else if (set_currentQuestion == 4)
            set_Questioner("where did the first nuclear bomb drop?", "HIROSHIMA", "germany", "africa", "italy", "HIROSHIMA");

        else if (set_currentQuestion == 5)
            set_Questioner("Which of the following has not occurred as a result of Social Networking?", "Rape", "Loss of jobs", "Suspension/Expulsion from school", "All of the above have occured", "Loss of jobs");

        else if (set_currentQuestion == 6)
            set_Questioner("Which of the following is the most popular social networking site on the internet?", "MySpace", "Facebook ", "Orkut", "Friendster", "Facebook");

        else if (set_currentQuestion == 7)
            set_Questioner("Social Network sites use which media for communication?", "Video", "Audio", "Text", "All of the above", "Text");

        else if (set_currentQuestion == 8)
            set_Questioner("where did the first nuclear bomb drop?", "HIROSHIMA", "germany", "africa", "italy", "HIROSHIMA");

        else if (set_currentQuestion == 9)
            set_Questioner("where did the 2nd nuclear bomb drop?", "NAGASAKI", "germany", "africa", "italy", "NAGASAKI");

        /*if (set_currentQuestion == 0)
            set_Questioner("Who founded STI?", "Augusto C. Lagman", "Matt Mullenweg", "Mark Betuen", "Dennis Nava", "Augusto C. Lagman");

        else if (set_currentQuestion == 4)
            set_Questioner("Which of the following is the most popular social networking site on the internet?", "MySpace", "Facebook ", "Orkut", "Friendster", "Facebook");

        else if (set_currentQuestion == 9)
            set_Questioner("Who founded MySpace?", "Tom Anderson", "Rupert Murdoch", "Will DeWolfe", "Marc Andressen", "Tom Anderson");

        else if (set_currentQuestion == 6)
            set_Questioner("Which of the following is safe to post on a social networking site?", "Your location", "Your birthday", "An alias", "A picture of you with your friends", "A picture of you with your friends");

        else if (set_currentQuestion == 1)
            set_Questioner("Which of the following types of people can you find on Social Networking sites?", "Musicians", "Politicians", "Criminals", "All of the above", "Politicians");

        else if (set_currentQuestion == 5)
            set_Questioner("Which of the following has not occurred as a result of Social Networking?", "Rape", "Loss of jobs", "Suspension/Expulsion from school", "All of the above have occured", "Loss of jobs");

        else if (set_currentQuestion == 3)
            set_Questioner("When was the term social networking first used?", "1994", "1954", "2004", "1974", "1994");

        else if (set_currentQuestion == 7)
            set_Questioner("Social Networking involves communication between _________", "Two computers", "A computer and a router", "A human and a computer", "Two or more people", "Two or more people");

        else if (set_currentQuestion == 8)
            set_Questioner("Social Networking first became popular online when?", "1977", "1999", "2003", "1988", "1999");

        else if (set_currentQuestion == 2)
            set_Questioner("Social Network sites use which media for communication?", "Video", "Audio", "Text", "All of the above", "Text");

*/
        else if (set_currentQuestion == 11)
        {

            btn_Answer.setText("Done");
            AlertDialog alertDialog = new AlertDialog.Builder(MainActivity.this).create();
            alertDialog.setTitle("Bhoxzs Kierbyyyy");
            alertDialog.setMessage("Your score is " + set_currentScore.toString());
            alertDialog.setButton(AlertDialog.BUTTON_NEUTRAL, "OK", new DialogInterface.OnClickListener() {
                @Override
                public void onClick(DialogInterface dialog, int which) {

                    set_currentScore = 0;
                    set_currentQuestion = 0;

                    set_Question();
                }
            });
            alertDialog.show();

        }
    }
}
