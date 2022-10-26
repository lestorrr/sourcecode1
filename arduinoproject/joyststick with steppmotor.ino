int s1 = 5;
int s2 = 6;
int s3 = 7;
int s4 = 8;
int x;
void setup() {
  pinMode(s1, OUTPUT);
  pinMode(s2, OUTPUT);
  pinMode(s3, OUTPUT);
  pinMode(s4, OUTPUT);
  pinMode(A0, INPUT);
 }
void loop() {
  x = analogRead(A0);
  
  if(x<500)
  {
 digitalWrite(s1, HIGH);
 digitalWrite(s2, LOW);
 digitalWrite(s3, LOW);
 digitalWrite(s4, LOW);
 delay(3);
 digitalWrite(s1, LOW);
 digitalWrite(s2, HIGH);
 digitalWrite(s3, LOW);
 digitalWrite(s4, LOW);
 delay(3);
 digitalWrite(s1, LOW);
 digitalWrite(s2, LOW);
 digitalWrite(s3, HIGH);
 digitalWrite(s4, LOW);
 delay(3);
 digitalWrite(s1, LOW);
 digitalWrite(s2, LOW);
 digitalWrite(s3, LOW);
 digitalWrite(s4, HIGH);
 delay(3);
 }
 else if(x>550)
 {
  digitalWrite(s1, LOW);
 digitalWrite(s2, LOW);
 digitalWrite(s3, LOW);
 digitalWrite(s4, HIGH);
 delay(3);
 digitalWrite(s1, LOW);
 digitalWrite(s2, LOW);
 digitalWrite(s3, HIGH);
 digitalWrite(s4, LOW);
 delay(3);
 digitalWrite(s1, LOW);
 digitalWrite(s2, HIGH);
 digitalWrite(s3, LOW);
 digitalWrite(s4, LOW);
 delay(3);
 digitalWrite(s1, HIGH);
 digitalWrite(s2, LOW);
 digitalWrite(s3, LOW);
 digitalWrite(s4, LOW);
 delay(3);
 }
 else if(x > 500 && x < 550)
 {
 digitalWrite(s1, LOW);
 digitalWrite(s2, LOW);
 digitalWrite(s3, LOW);
 digitalWrite(s4, LOW);
 }
}
