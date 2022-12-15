# NotEnoughPixels

 Not Enough Pixels Version 1.0.0 for LogicWorld 0.91 Preview 608.
 Requires System.IO.Compression.dll to be loaded. Can be done with cheeseloader

## PixelDisplay

A resizable 24 bit color display. The pins on the back from bottom row to top are x,y,r,g,b,control. The control pins from edge to center: clock, floodfill. The display can be resized from a minimum of 3x2 up to 16x16. With 16x16 pixels each square, thats 48x32 to 256x256. Input positions outside current size are ignored. Screen origin(0,0) is on the bottom left. It has a refresh rate of 10 fps.