  
  #define ldrPin A0
  int laserpinR = 3;
  int laserpinG = 5;
  int laserpinB = 6;
  int valR = 5;
  int valG = 5;
  int valB = 5;

int buttonState;
bool lastButtonState = false;
bool reading;

unsigned long lastDebounceTime = 0;
unsigned long debounceDelay = 10;

int LDRValue = 0;


void setup() {
  // put your setup code here, to run once:
  pinMode(laserpinR,OUTPUT);
  pinMode(laserpinG,OUTPUT);
  pinMode(laserpinB,OUTPUT);

  Serial.begin(9600);
  pinMode(ldrPin, INPUT);

  
}

void loop() {
  
  analogWrite(laserpinR, valR);
  analogWrite(laserpinG, valG);
  analogWrite(laserpinB, valB);

  int ldrStatus = analogRead(ldrPin);
  Serial.println(ldrStatus);

  /*if ( ldrStatus>400){
  }
  
  else{
  Serial.print("test");
  }*/

    reading = read();
  
  if (reading != lastButtonState) {
    // reset the debouncing timer
    lastDebounceTime = millis();
  }

  if ((millis() - lastDebounceTime) > debounceDelay) {

    if (reading != buttonState) {
      buttonState = reading;

      if (buttonState == HIGH) {
        Serial.write("L");
      }
      else if(buttonState == LOW) {
        
      }
    }
  lastButtonState = reading;
}











