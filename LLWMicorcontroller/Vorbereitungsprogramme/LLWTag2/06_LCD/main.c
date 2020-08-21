
/*
* 06_LCD.c
*
* Created: 30.06.2020 09:16:24
* Author : lwngrmc
*/

#include <avr/io.h>
#include <stdlib.h>
#include "lcd.h"

int main(void)
{
	lcd_init();
	char buffer[100];

	while (1)
	{
		// C Unterstüzt von ASCII --> Zahlen und von Zahlen --> ASCII
		
		unsigned int zahl = 20;
		
		// unsigned interger to ascii (geht auch mit char)
		// schreibt die ascii zeichen in den buffer -> steht nach der umwandlung buffer = '2*', '0', '\0'
		utoa(zahl, buffer, 10);
		
		lcd_home();
		lcd_string(buffer);
		
		signed int szahl = -20;
		
		// integer to ascii (geht auch mit char)
		// buffer = '-', '2', '0', '\0'
		itoa(szahl, buffer, 10);

		lcd_cursor(0,1);
		lcd_string(buffer);
		
		//// umgekehrt
		//char iazahl[] "-1234";
		//zahl = atoi(iazahl);
		//
		//char iazahl2[] "1234";
		//zahl = (unsigned char)atoi(iazahl2);
	}
}

