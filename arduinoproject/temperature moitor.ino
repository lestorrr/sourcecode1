#include "DHT.h"
#define DHTPIN 4
#define DHTTYPE DHT11
DHT dht(DHTPIN, DHTTYPE);
#include <LiquidCrystal_I2C.h>
LiquidCrystal_I2C lcd(0x27, 16, 2);
void setup() {
 dht.begin();
 lcd.backlight();
 lcd.init();
}
void loop() {
 lcd.clear();
   lcd.setCursor(0,0);
   lcd.print("Humidity=");
   lcd.print((float)dht.readHumidity());
   lcd.print("%");
   lcd.setCursor(0,1);
   lcd.print("Temp=");
   lcd.print((float)dht.readTemperature());
   lcd.print("Celsius");
   delay(2000);
   lcd.clear();
}