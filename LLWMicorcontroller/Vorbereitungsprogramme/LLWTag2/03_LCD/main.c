/*
 * 03_LCD.c
 *
 * Created: 30.06.2020 08:48:07
 * Author : lwngrmc
 */ 

#include <avr/io.h>
#include "lcd.h"

int main(void)
{
	lcd_init();
	
	while (1)
	{
		unsigned char x = 10;
		
		lcd_home();
		lcd_string("0b");
		// 1. Zeile
		// (Zahl, Radix, l�nge der zahl im Dipsplay)	(x=10)(2 = bin�r)(l�nge der zahl = 4 (1010))
		lcd_ul2ascii(x,2, 4);
		
		// 2.Zeile
		lcd_cursor(0,1);
		lcd_string("0x");
		// (Zahl, Radix, l�nge der zahl im Dipsplay)	(x=10)(16 = Hexadezimal)(l�nge der zahl = 1 (a))
		lcd_ul2ascii(x,16,1);
		lcd_char(' ');
		// (Zahl, Radix, l�nge der zahl im Dipsplay)	(x=10)(10 = Dezimal)(l�nger der zahl = 2 (10))
		lcd_ul2ascii(x, 10, 2);

		//y die funktion ul2ascii wandelt eine zahl in eine ascii zeichenfolge um
		//
		// ul2ascii unterst�zt 3 verschiedene Radix
		// * 2		bin�r
		// * 10		dezimal
		// * 16		hexadezimal
		//
		// Die l�nge gibt an wieviel platz ide zahl auf dem display ben�tigt
	}
}

