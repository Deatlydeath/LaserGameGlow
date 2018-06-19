bool read(){
  int output = analogRead(ldrPin);

  if (output > 300){
    return false;
  }
  else {
    return true;
  }
}

