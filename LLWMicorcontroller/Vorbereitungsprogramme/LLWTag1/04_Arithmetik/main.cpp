/*
 * 04_Arithmetik.cpp
 *
 * Created: 29.06.2020 12:46:11
 * Author : lwngrmc
 */ 
#define  F_CPU 12000000UL

#include <avr/io.h>
#include <util/delay.h>

int main(void)
{
	// PORTC LEDS auf Ausgang setzen
	DDRC = 0xff;
    while (1) 
    {
		//_delay_ms(500);
		// Inkrementieren
		//PORTC ++;
		//PORTC --;

		unsigned char x = 10;
		x += 20;
		
		// Vorsicht
		// Datentyp usnigned char hat 256 Zustände (0-255)
		x+= 255;
		
		_delay_ms(50);
    }
}

