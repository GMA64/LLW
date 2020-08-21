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
		
		// (zahl)(länger der zahl)(präzission(wie viele nachkommazahlen dargestellt werden soll))
		lcd_d2ascii(zahl, 7, 3);
		
		// lcd_d2ascii
		// parameter
		// * Zahl
		// * länger der zahl (inl. komma)
		// * anzahl der Kommastellen
    }
}

