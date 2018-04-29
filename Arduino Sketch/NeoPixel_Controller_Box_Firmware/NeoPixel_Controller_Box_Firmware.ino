//MIT License
//
//Copyright (c) 2017 Angelo Pescarini (aka EEPblog)
//
//Permission is hereby granted, free of charge, to any person obtaining a copy
//of this software and associated documentation files (the "Software"), to deal
//in the Software without restriction, including without limitation the rights
//to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//copies of the Software, and to permit persons to whom the Software is
//furnished to do so, subject to the following conditions:
//
//The above copyright notice and this permission notice shall be included in all
//copies or substantial portions of the Software.
//
//THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//SOFTWARE.
//===========================================================================================================
#include <Adafruit_NeoPixel.h>
//#include <SoftwareSerial.h>

#define STAT 8                       //status pin from the Bluetooth module

int mode = 100;                      //define everything global
int spd, red, grn, blu, showVolts;
bool newData = 0;
int lastmode = 0;

Adafruit_NeoPixel strip = Adafruit_NeoPixel(119, 6, NEO_GRB + NEO_KHZ800); //Start the strip with 36 LEDs on pin 6
//SoftwareSerial debug(10, 11); //RX, TX

//===========================================================================================================
void setup() {
  strip.begin();                                    //begin the NeoPixel strip
  strip.show();
  Serial.begin(9600);
  //debug.begin(9600);

  bootAnimation();                                  //play a little boot animation
  strip.show();

  delay(50);

  //debug.println("Online!");
}
//===========================================================================================================

void loop() {



  strip.setBrightness(255);                       //resets the strip brightness

  switch (mode) {                                 //checks the current mode and sets up the animations accordingly
    default:
      for (int j = 0; j < strip.numPixels(); j++) {         //this animation shows, that something's not quite right :/
        strip.setPixelColor(j, 0, 0, 0); //clears the strip
      }
      ring(8, 0, 0);
      break;
    case 100:                                              //this is the "first power-on" animation, it is saying, that
      ring(92, 71, 52);                                 //it is definitely ready to receive commands
      break;
    case 1:                                                //mode 1: spectrum effect (or hue effect), ignores R, G, B values
      hue();
      break;
    case 2:                                                //mode 2: static color, ignores the speed (spd) value
      ring(red, grn, blu);
      break;
    case 3:                                                //mode 3: breathing effect
      breathe();
      break;
    case 4:                                                //mode 4: beacon effect
      cop();
      break;
    case 5:                                                //mode 5: theater style lights, changes colors throughout, ignores R, G, B values
      theaterChaseRainbow(spd);
      break;
    case 6:                                                //mode 6: gradually changes the colors, not all colors of the spectrum are shown at the same time,
      hue2();                                           //you'll se what i mean... ignores R, G, B values; currently unsupported in the official app.
      break;
    case 7:                                                //mode 7: same as mode 5, except it has user definable color; currently unsupported in the official app.
      theaterChase(spd, red, grn, blu);
      break;
    case 8:                                                //mode 8: Knight Rider, not the best one, but eh does the job i guess
      knightRider();
      break;
    case 9:
      audioVU();
      break;
  }
}
//===========================================================================================================

//-------------------------------------------------------------------------------------MODE 1: Color Spectrum
void hue() {
  uint16_t i, j;

  for (j = 0; j < 256 * 5; j++) { // 5 cycles of all colors on wheel
    for (i = 0; i < strip.numPixels(); i++) {
      strip.setPixelColor(i, Wheel(((i * 256 / strip.numPixels()) + j) & 255));
    }
    strip.show();
    receive();
    if (newData) {
      return;
    }
    delay(spd);
  }
}
//-------------------------------------------------------------------------------------MODE 6: Color Spectrum 2
void hue2() {
  uint16_t i, j;

  for (j = 0; j < 256; j++) {
    for (i = 0; i < strip.numPixels(); i++) {
      strip.setPixelColor(i, Wheel((i + j) & 255));
    }
    strip.show();
    if (receive()) {
      return;
    }
    delay(spd);
  }
}
//-------------------------------------------------------------------------------------Color changing FX generator
uint32_t Wheel(byte WheelPos) {
  WheelPos = 255 - WheelPos;
  if (WheelPos < 85) {
    return strip.Color(255 - WheelPos * 3, 0, WheelPos * 3);
  }
  if (WheelPos < 170) {
    WheelPos -= 85;
    return strip.Color(0, WheelPos * 3, 255 - WheelPos * 3);
  }
  WheelPos -= 170;
  return strip.Color(WheelPos * 3, 255 - WheelPos * 3, 0);
}
//-------------------------------------------------------------------------------------MODE 4: Beacon
void cop() {
  for (int i = 0; i < strip.numPixels(); i++) {
    for (int j = 0; j < strip.numPixels(); j++) {
      strip.setPixelColor(j, 0, 0, 0); //clears the strip
    }
    strip.setPixelColor(i, red, grn, blu);
    strip.setPixelColor(i - 1, red, grn, blu);
    strip.setPixelColor(i - 2, red, grn, blu);
    strip.setPixelColor(i - 3, red, grn, blu);
    strip.setPixelColor(i - 4, red, grn, blu);
    for (int j = 0; j < (4 - i); j++) {
      strip.setPixelColor(strip.numPixels() - j, red, grn, blu);
    }
    if (receive()) {
      return;
    }
    strip.show();
    delay(spd);
  }
}
//-------------------------------------------------------------------------------------MODE 2: Static Color
void ring(int r, int g, int b) {
  for (int i = 0; i < strip.numPixels(); i++) {
    strip.setPixelColor(i, r, g, b);

  } strip.show();
  receive();
}
//-------------------------------------------------------------------------------------MODE 3: Breathing Effect
void breathe() {

  for (int i = 0; i <= 255; i++) {
    strip.setBrightness(i); //clears the strip
    for (int j = 0; j < strip.numPixels(); j++) {
      strip.setPixelColor(j, red, grn, blu);
    }
    strip.show();
    receive();
    delay(spd);
  }
  for (int i = 255; i >= 0; i--) {
    strip.setBrightness(i); //clears the strip
    for (int j = 0; j < strip.numPixels(); j++) {
      strip.setPixelColor(j, red, grn, blu);
    }
    strip.show();
    if (receive()) {
      return;
    }
    delay(spd);
  }
}
//-------------------------------------------------------------------------------------MODE 5: Rainbow Theatre Effect
void theaterChaseRainbow(int wait) {
  for (int j = 0; j < 256; j++) {   // cycle all 256 colors in the wheel
    for (int q = 0; q < 3; q++) {
      for (uint16_t i = 0; i < strip.numPixels(); i = i + 3) {
        strip.setPixelColor(i + q, Wheel( (i + j) % 255)); //turn every third pixel on
      }
      strip.show();

      delay(spd);
      if (receive()) {
        return;
      }
      for (uint16_t i = 0; i < strip.numPixels(); i = i + 3) {
        strip.setPixelColor(i + q, 0);      //turn every third pixel off
      }
    }
  }
}
//-------------------------------------------------------------------------------------MODE 7: Static COlor Theatre Effect
void theaterChase(uint8_t sp, int r, int g, int b) {

  for (int q = 0; q < 3; q++) {
    for (uint16_t i = 0; i < strip.numPixels(); i = i + 3) {
      strip.setPixelColor(i + q, red, grn, blu);  //turn every third pixel on
    }
    strip.show();
    if (receive()) {
      return;
    }
    delay(spd);

    for (uint16_t i = 0; i < strip.numPixels(); i = i + 3) {
      strip.setPixelColor(i + q, 0);      //turn every third pixel off
    }
  }
}
//-------------------------------------------------------------------------------------MODE 8: Knight Rider
void knightRider() {
  for (int i = 0; i < strip.numPixels(); i++) {
    for (int j = 0; j < strip.numPixels(); j++) {
      strip.setPixelColor(j, 0, 0, 0); //clears the strip
    }
    strip.setPixelColor(i, red, grn, blu);
    strip.setPixelColor(i - 1, red, grn, blu);
    strip.setPixelColor(i - 2, red, grn, blu);
    strip.setPixelColor(i - 3, red, grn, blu);
    strip.setPixelColor(i - 4, red, grn, blu);
    if (receive()) {
      return;
    }
    strip.show();
    delay(spd);
  }
  for (int i = strip.numPixels(); i > 0 ; i--) {
    for (int j = 0; j < strip.numPixels(); j++) {
      strip.setPixelColor(j, 0, 0, 0); //clears the strip
    }
    strip.setPixelColor(i, red, grn, blu);
    strip.setPixelColor(i - 1, red, grn, blu);
    strip.setPixelColor(i - 2, red, grn, blu);
    strip.setPixelColor(i - 3, red, grn, blu);
    strip.setPixelColor(i - 4, red, grn, blu);
    if (receive()) {
      return;
    }
    strip.show();
    delay(spd);
  }
}
//-------------------------------------------------------------------------------------MODE 9: Audio VU meter
int val;                                                                       //note: Was ported from my other project, it is
int color = 0;                                                                 //      expected to be used with a proper analog frontend.
bool change = 0;                                                               //      Spd = color change, r = scale, g = threshold, b = hysterisis
void audioVU() {
  int analog = analogRead(A0);  //connect the Audio Source here, for best results use an OP amp front end.
  int scale = red;              //this ultimately sets the sensitivity, basically the high point for the VUmeter
  int threshold = grn;          //if the signal crosses this point, the VUmeter will change color
  int hysterisis = blu;         //the hysterisis is necessary, since it determins the reset value before another color change



  val = map(analog, 0, scale, 1, strip.numPixels()); //this scales the Audio source to the amount of pixels in our strip
  if ((analog > threshold) && (change == 1)) {       //this advances to the next color whenever it peaks over the threshold.
    color++;
    if (color > 4) {
      color = 0;
    }
    change = 0;
  }
  if ((analog < hysterisis) && (spd == 1)) {         //this allows the change of the color for the next peak
    change = 1;
  }
  for (byte i = 0; i < strip.numPixels(); i++) {     //this draws the palette for our strip depending on the color variable
    switch (color) {
      case 4:
        strip.setPixelColor(i, map(i, 0, strip.numPixels(), 0, 255), map(i, 0, strip.numPixels(), 160, 0), 0);
        break;
      case 1:
        strip.setPixelColor(i, map(i, 0, strip.numPixels(), 0, 255), 0,  map(i, 0, strip.numPixels(), 255, 0));
        break;
      case 2:
        strip.setPixelColor(i, 0,  map(i, 0, strip.numPixels(), 0, 255), map(i, 0, strip.numPixels(), 255, 0));
        break;
      case 3:
        strip.setPixelColor(i, map(i, 0, strip.numPixels(), 0, 255), map(i, 0, strip.numPixels(), 255, 0), map(i, 0, strip.numPixels(), 0, 255));
        break;
      case 0:
        strip.setPixelColor(i, map(i, 0, strip.numPixels(), 0, 255),  map(i, 0, strip.numPixels(), 0, 255),  map(i, 0, strip.numPixels(), 255, 0));
        break;
    }
  }
  receive();
  for (int i = strip.numPixels(); i > val; i--) {  //this then disables the pixels that don't need to be on
    strip.setPixelColor(i, 0, 0, 0);
  }
  strip.show();                                   //here we draw the result onto the actual LED strip
}
//-------------------------------------------------------------------------------------Data receive handler

bool receive() {
  while (Serial.available() > 0) {
    //debug.println("*DATA IN BUFFER*");
    int amode, aspd, ared, agrn, ablu;
    while (Serial.read() != 'S') {}
    showVolts = Serial.parseInt();
    amode = Serial.parseInt();
    aspd = Serial.parseInt();
    ared = Serial.parseInt();
    agrn = Serial.parseInt();
    ablu = Serial.parseInt();


    while (Serial.read() != '\n') {}
    if (!showVolts) {   //it is supported not having to send the whole data format for data requests
      mode = amode;     //therefore this prevents the data to be overwritten by zeros, so the show can go on
      spd = aspd;
      red = ared;
      grn = agrn;
      blu = ablu;
    }
  }
  //  debug.print("current data: ");            //debug port
  //  debug.print(mode); debug.print(", ");
  //  debug.print(spd); debug.print(", ");
  //  debug.print(red); debug.print(", ");
  //  debug.print(grn); debug.print(", ");
  //  debug.print(blu); debug.print("; ");
  //  debug.println(newData);
  if ((lastmode == mode) && (showVolts == 0)) {
    newData = 0;
  } else {
    newData = 1;
  }
  if (showVolts == 1) {
    int lenval = 30;
    for (int i = 0; i < strip.numPixels(); i++) {
      for (int j = 0; j < strip.numPixels(); j++) {
        strip.setPixelColor(j, 0, 0, 0); //clears the strip
      }
      for (int j = 0; j < lenval; j++) {
        strip.setPixelColor(i - j, 0, 50, 200);
      }
      strip.show();
      delay(20);
    }
    for (int i = strip.numPixels(); i > 0 ; i--) {
      for (int j = 0; j < strip.numPixels(); j++) {
        strip.setPixelColor(j, 0, 0, 0); //clears the strip
      }
      for (int j = 0; j < lenval; j++) {
        strip.setPixelColor(i - j, 0, 50, 200);
      }
      strip.show();
      delay(20);
    }
  }
  if (showVolts == 2) {                           //if there was a request for debug info,
    Serial.print("current setting: ");            //send it.
    Serial.print(mode); Serial.print(", ");
    Serial.print(spd); Serial.print(", ");
    Serial.print(red); Serial.print(", ");
    Serial.print(grn); Serial.print(", ");
    Serial.println(blu);
  }
  showVolts = 0;                                  //resets the request integer so it doesn't flood the terminal
  lastmode = mode;
  return newData;
}
//-------------------------------------------------------------------------------------Boot Animation
void bootAnimation() {

  strip.setBrightness(0);
  for (int i = 0; i <= 255; i++) {
    strip.setBrightness(i); //clears the strip
    for (int j = 0; j < strip.numPixels(); j++) {
      strip.setPixelColor(j, 92, 71, 52);
    }
    strip.show();
    receive();
    delay(15);
  }
}

