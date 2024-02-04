# Hexas Memory

Hexa's Memory Version 1.0.0 for LogicWorld 0.91.2.

## Memory8bit

A simple 8 bit memory component that resembles a D-Latch. Has a 16 bit address for a total of 65,536 bytes.

## HexRom8bit

A read only memory component that allows hexadecimal to be entered just like a Label. 16 bit address allows for up to 65,536 bytes. The least significant bit is on the bottom left and bottom right for the address and output respectively.
The address points to the 2nth character in the text. That character and the one after is converted into a byte.

## AsmRom8bit

A read only memory component with built in assembler. Instructions with corresponding machine code is specified, along with some configuration parameters, and allow basic assembly language to be converted into different architectures. For more information, refer to the AsmROM manual.
