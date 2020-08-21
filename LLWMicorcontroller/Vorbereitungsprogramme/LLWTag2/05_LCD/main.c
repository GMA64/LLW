/*
 * 05_LCD.c
 *
 * Created: 30.06.2020 08:52:33
 * Author : lwngrmc
 */ 

#include <avr/io.h>
#include "lcd.h"

int main(void)
{
	lcd_init();

    while (1) 
    {
		double zahl = 123.456;
		lcd_home();
		
		// (zahl)(l�nger der zahl)(pr�zission(wie viele nachkommazahlen dargestellt werden soll))
		lcd_d2ascii(zahl, 7, 3);
		
		// lcd_d2ascii
		// parameter
		// * Zahl
		// * l�nger der zahl (inl. komma)
		// * anzahl der Kommastellen
    }
}

