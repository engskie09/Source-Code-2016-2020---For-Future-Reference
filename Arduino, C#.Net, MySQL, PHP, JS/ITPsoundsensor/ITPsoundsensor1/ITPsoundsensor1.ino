int getAnalogVal;

int led;

float db;

const float dBAnalogQuiet = 10; // calibrated value from analog input (48 dB equivalent)
const float dBAnalogMedium = 12;
const float dBAnalogLoud = 17;

void setup() {
  Serial.begin(9600);
  pinMode(led, OUTPUT);
}


void loop() {
  
  int value;
  float decibelsValueQuiet = 49;
  float decibelsValueMedium = 65;
  float decibelsValueLoud = 70;
  getAnalogVal = analogRead(A0);
  
  //led = random(11,14);
  
  /*if (getAnalogVal >= 30)
  {
    analogWrite(led, 150);
    //Serial.println(getAnalogVal);
    getAnalogVal = 0;
  } 
  
  else
  {    
    analogWrite(led, 0);       
  }*/




  if ((getAnalogVal < 13) && (getAnalogVal > 0))
  {
    decibelsValueQuiet += 20 * log10(getAnalogVal/dBAnalogQuiet);
    Serial.println("Tahimik");


    //blue
    led = 11;
    analogWrite(led, 150);

    getAnalogVal = 0;
    
  }

  else if ((getAnalogVal > 13) && (getAnalogVal <= 23))
  {
    decibelsValueMedium += log10(getAnalogVal/dBAnalogMedium);
    Serial.println("Medyo Maingay");


    //red
    led = 12;
    analogWrite(led, 150);


    getAnalogVal = 0;

  }

  else if (getAnalogVal > 22)
  {
    decibelsValueLoud += log10(getAnalogVal/dBAnalogLoud);
    Serial.println("Maingay");


    //green
    led = 13;
    analogWrite(led, 150);

    getAnalogVal = 0;
     

  }

  else 
  
  {
    delay(100); 
    analogWrite(led, 0);

    getAnalogVal = 0;
  }

   
  
  
  
  
  

}
