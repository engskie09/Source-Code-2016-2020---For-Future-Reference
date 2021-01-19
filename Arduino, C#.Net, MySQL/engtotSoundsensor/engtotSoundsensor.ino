
int threshold = 500; //Change This
int volume;
int led = 0;


void setup() {                
  Serial.begin(9600); // For debugging
  pinMode(led, OUTPUT);     
}

void loop() {
  led = random( 11,14);
  volume = analogRead(A0); // Reads the value from the Analog PIN A0
  setBrightness(255);
  
  if(volume>=50){
    digitalWrite(led, HIGH); //Turn ON Led
    Serial.println(volume);
    
  }  
  else{
    digitalWrite(led, LOW); // Turn OFF Led
     
  }

  delay(volume);
}

void setBrightness(byte brightness) // 0 to 255
{
  analogWrite(led, 50-brightness);
}
