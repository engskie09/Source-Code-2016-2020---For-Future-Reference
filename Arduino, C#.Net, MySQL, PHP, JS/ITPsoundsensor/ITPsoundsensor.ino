int getAnalogVal;

int led;

float db;

void setup() {
  Serial.begin(9600);
  pinMode(led, OUTPUT);
}


void loop() {
  

  getAnalogVal = analogRead(A0)/2;
  
  led = random(11,14);
  
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

  delay(getAnalogVal); 
  
  
  
  
  
  

}
