#define  STX 2
#define  ETX 3
#define  SERIALSTX 0
#define  SERIALETX 1
#define  SERIALRDY 2

// RFID read results
 String card_enrolled;   // = 0 if card is not enrolled = 1 if enrolled and valid
 String  card_addr;      // contains valid card index only if card is enrolled. 
 String  card_type;      // card type identifier
 String  card_number;    // card serial number

byte  serial_state;
String serialinput;
boolean  carddetected=false;



void setup() {
  // initialize serial:
  Serial.begin(9600);
  serial_state=SERIALSTX;
  serialinput="";
  check_RFID();
  
}

void loop() {

  if(check_RFID()==true){
    
    // Replace the following demo codes with your own
    
    // Print the read information
    Serial.println(card_number);   
  }

}


/* Do not modify anything in the following codes unless
  you absolutely know what you are doing :-) */
  
boolean check_RFID(void){

  int  strindex;
  int  strindexe;
  
     if(serial_state==SERIALRDY)
     {    

      strindex=serialinput.indexOf(",");  
      strindex++;
      strindexe=serialinput.indexOf(",",strindex);      
      strindex=strindexe+1;
      strindexe=serialinput.indexOf(",",strindex);      
     
      strindex=strindexe+1;
      strindexe=serialinput.indexOf(",",strindex);
      card_number=serialinput.substring(strindex,strindexe);
      
      // clear received string and ready SERIAL for new stream
      serialinput="";
      serial_state=SERIALSTX;
      return(true);
    }
  return(false);  // return false if RFID data is not available
}


/* This is a interrupt driven serial Rx routine */

void serialEvent() {
  while (Serial.available()) {
    // get the new byte:
    char inChar = (char)Serial.read();
    
    // Wait for the STX character
    if(serial_state==SERIALSTX){
      if(inChar==STX){
        serial_state=SERIALETX;    // STX character detected, enable next phase
        return;
        }
    }
    
    // Store rx character to serial input until ETX is detected
    if(serial_state==SERIALETX){
      if(inChar!=ETX){
        serialinput += inChar;
        return;
        }
    }
    
      // Indicate serial data is ready after ETX is detected
      serial_state=SERIALRDY;
    }
  }
