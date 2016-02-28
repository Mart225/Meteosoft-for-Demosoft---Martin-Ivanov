#include <avr/interrupt.h>
#include <avr/sleep.h>
#include "DHT.h"


int scan;
int piezoSignal = 0;
boolean possibleOff = 0;
boolean isLEDStripOn;
boolean isLaserOn;

#define trigPin 9
#define echoPin 10
long duration, uS;

int lockState = 0;

boolean isGraphOn = 1;

boolean mode = 0;


#define wakePin 2
int sleepStatus = 0;
int sval = 0;


long sensorInterval = 600000;
unsigned long sensorPrev = 0;


long sensorIntervalUpdate = 5000;
unsigned long sensorPrevUpdate = 0;

DHT dht(7, 11);

void setup() {
  pinMode(13, OUTPUT);
  pinMode(wakePin, INPUT);
  digitalWrite(13, LOW);
  pinMode(3, OUTPUT);
  pinMode(5, OUTPUT);
  pinMode(6, OUTPUT);
  pinMode(trigPin, OUTPUT);
  pinMode(echoPin, INPUT);

  dht.begin();

  attachInterrupt(0, wakeUpNow, LOW);


  Serial.begin(250000);

  Serial.print("Mode: ");
  Serial.print(mode);
  Serial.println(" selected.");

  loop();
}

void sleepNow() { // here we put the arduino to sleep

  //  digitalWrite(optPwr, LOW);

  set_sleep_mode(SLEEP_MODE_PWR_DOWN);

  sleep_enable();

  attachInterrupt(0, wakeUpNow, LOW);

  sleep_mode();

  sleep_disable();

  detachInterrupt(0);
  sval = Serial.read();
  if (sval == 'S') {
    delay(200);
    sleepNow();
  } else {
    loop();
  }
}

void wakeUpNow() {
}

void loop() {

  unsigned long currentTime = millis();
  //digitalWrite(optPwr, HIGH);

  sval = Serial.read();

  if (sval == 'S') {
    delay(200);
    sleepNow(); \
  }




  //start of sensor update

  if (currentTime - sensorPrevUpdate > sensorIntervalUpdate) {

    if (mode == 0) {

      int LDRVal = analogRead(A0);
      float light = (LDRVal / 1024.0) * 5.0;


      int LDRValOut = analogRead(A3);
      float lightOut = (LDRValOut / 1024.0) * 5.0;

      int rawvoltagein = analogRead(A1);
      float millivoltsin = (rawvoltagein / 1024.0) * 5000;
      float kelvinin = (millivoltsin / 10);
      float inTemperature = (kelvinin - 273.15) - 3.5;

      float outTemperature = dht.readTemperature();


      if (inTemperature > 40.00) {
        tone(8, 350);
        Serial.print("DANGER: Indoor temperature too HIGH: ");
        Serial.print(inTemperature);
        Serial.println("C");
        analogWrite(6, 225);
        delay(1000);
        Serial.println("POSSIBE FIRE OR MALFUNCTION!");
        delay(10000);
        noTone(8);
        analogWrite(6, 0);
      }
      if (inTemperature < 15.00) {
        analogWrite(5, 225);
        tone(8, 330);
        delay(250);
        noTone(8);
        delay(250);
        tone(8, 320);
        delay(250);
        noTone(8);
        delay(250);
        tone(8, 310);
        delay(250);
        noTone(8);
        delay(250);
        tone(8, 290);
        delay(250);
        noTone(8);
        Serial.print("DANGER: Indoor temperature too LOW: ");
        Serial.print(inTemperature);
        Serial.println("C");
        delay(1000);
        Serial.println("POSSIBLE FREEZING AND MOISTURING THE SYSTEM!");
        delay(10000);
        analogWrite(5, 0);
      }


      if (outTemperature > 55.00) {
        analogWrite(6, 225);
        tone(8, 380);
        Serial.print("DANGER: Outdoor temperature too HIGH: ");
        Serial.print(outTemperature);
        Serial.println("C");
        delay(1000);
        Serial.println("POSSIBLE FIRE OR THEAF!");
        delay(10000);
        noTone(8);
        analogWrite(6, 0);
      }
      sensorPrevUpdate = currentTime;
    }
  }
  //End of updating all sensors.


  //Serial update of all sensors begin.

  if (currentTime - sensorPrev > sensorInterval) {

    if (mode == 0) {
      int LDRVal = analogRead(A0);
      float light = (LDRVal / 1024.0) * 5.0;


      int LDRValOut = analogRead(A3);
      float lightOut = (LDRValOut / 1024.0) * 5.0;

      int rawvoltagein = analogRead(A1);
      float millivoltsin = (rawvoltagein / 1024.0) * 5000;
      float kelvinin = (millivoltsin / 10);
      float inTemperature = (kelvinin - 273.15) - 3.5;

      float outTemperature = dht.readTemperature();

      float h = dht.readHumidity();

      Serial.print("MR t.| ");
      Serial.print(inTemperature);
      Serial.print(" | Out t.| ");
      Serial.print(outTemperature);
      Serial.print(" | L(MR):| ");
      Serial.print(light);
      Serial.print(" |");
      Serial.print(" L(OUT):| ");
      Serial.print(lightOut);
      Serial.print(" | ");
      Serial.print("Humidity: | ");
      Serial.print(h);
      Serial.println("% |");

      if (isGraphOn == 1) {
        delay(1000);
        Serial.print("*#");
        Serial.println(inTemperature);
        delay(1000);
        Serial.print("&$");
        Serial.println(outTemperature);
        delay(1000);
        Serial.print("^@");
        Serial.println(light);
        delay(1000);
        Serial.print("%~");
        Serial.println(lightOut);
        delay(100);
        delay(1000);
        Serial.print(">}");
        Serial.println(h);
      }

      sensorPrev = currentTime;
    }
  }


  //End of serial update of all sensors.


  //Serial commands...

  lockState = Serial.read();

  if (lockState == 'U') {
    sensorPrev = 600000;
  }

  if (lockState == 'R') {
    analogWrite(6, 225);
  }

  if (lockState == 'T') {
    digitalWrite(3, 225);
  }

  if (lockState == 'B') {
    digitalWrite(5, 225);
  }

  if (lockState == 'Y') {
    analogWrite(6, 0);
    analogWrite(5, 0);
    analogWrite(3, 0);
  }


  if (lockState == 'G') {

    if (isGraphOn == 1) {
      isGraphOn = 0;
      Serial.println("Graph off.");
    }
    else {
      isGraphOn = 1;
      Serial.println("Graph on.");
    }
  }

  if (lockState == 'I') {
    digitalWrite(trigPin, LOW);
    delayMicroseconds(5);
    digitalWrite(trigPin, HIGH);
    delayMicroseconds(10);
    digitalWrite(trigPin, LOW);
    duration = pulseIn(echoPin, HIGH);
    uS = (duration / 2) / 29.1;

    if (uS < 500) {
      Serial.print("Closest obj: ");
      Serial.print(uS);
      Serial.println("cm.");
    } else {
      Serial.println("Scan completed!");
    }
    duration = 0;
    uS = 0;
    delay(500);
  }

  if (lockState == 'X') {
    if (isLEDStripOn == 0) {
      digitalWrite(4, HIGH);
      delay(1000);
      digitalWrite(4, LOW);
      Serial.println("LED STRIP SHOULD NOW BE ON.");
      isLEDStripOn = 1;
    } else {
      Serial.println("The LED strip is allready ON!");
    }
  }


  if (lockState == 'Z') {
    if (isLEDStripOn == 1) {
      digitalWrite(4, HIGH);
      delay(1000);
      digitalWrite(4, LOW);
      Serial.println("LED STRIP SHOULD NOW BE OFF.");
      isLEDStripOn = 0;
    } else {
      Serial.println("The LED strip is allready OFF.");
    }
  }

  if (lockState == 'M') {
    mode = 0;
    Serial.println("Mode 1(MAC) SELECTED! Calibration successfull!");
    loop;
  }
}
