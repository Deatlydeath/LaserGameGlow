int laserpinR = 3;
  int laserpinG = 5;
  int laserpinB = 6;
  int valR;
  int valG;
  int valB;

void setup() {
  // put your setup code here, to run once:
  pinMode(laserpinR,OUTPUT);
  pinMode(laserpinG,OUTPUT);
  pinMode(laserpinB,OUTPUT);
}

void loop() {
  // put your main code here, to run repeatedly:
  valR=50; valG=50; valB=0;
  analogWrite(laserpinR, valR);
  analogWrite(laserpinG, valG);
  analogWrite(laserpinB, valB);
}

