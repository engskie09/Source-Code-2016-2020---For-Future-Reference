int getAnalogVal;

int led;

String get_currentAction = "";



void setup() {
  Serial.begin(9600);
  pinMode(led, OUTPUT);
}

float calculateDecibels(int x)
{
  float decibelsCalculated;
  
  decibelsCalculated = 20 * log10(x/100);


  
  return (decibelsCalculated);
}


void loop() {
  

  getAnalogVal = analogRead(A0);

  //ADC
  //get analog voltage
  float analogVoltage = getAnalogVal * (5.0/1023.0);
  //convert Analog to Digital
  float adc = analogVoltage * (1023.0/5.0);  

  //float db = (adc + 83.2073) / 11.003;
  //float db = 20*log10(getAnalogVal);

  //float db =  20.0  * log10 (getAnalogVal  +1);


  //dBm = 10 log10(10/6) + 20 log10(V).
  //float db = 10*log10(10/6) + 20 * log10(analogVoltage);


  //float db =  20 * log10(5 / analogVoltage);

  //float db = 20 * log(getAnalogVal/100) + 60;

  float db = 60 + calculateDecibels(getAnalogVal);
    
//Serial.println(getAnalogVal);

 
 
 if (db > 60)
 {
  
  led = random(11,14);

  analogWrite(led, 150);
  
  Serial.println(db); 
 
  
 }

 if (get_currentAction == "tae")
 {
  led = random(11,14);
  
  analogWrite(led, 0);
  Serial.println(get_currentAction);
  
  delay(1000);
  
    
 }  


/*
  if ((db > 30) && (db < 60) && (getAnalogVal > 30))
  {    
    Serial.println(db);  

      delay(300);

  }*/
  
  /*led = random(11,14);
  
  if (getAnalogVal >= 30)
  {
    analogWrite(led, 150);
    Serial.println(getAnalogVal);
    getAnalogVal = 0;
  } 
  
  else
  {    
    analogWrite(led, 0);       
  }

  delay(getAnalogVal); */  
  
  
  
  
  
  

}
