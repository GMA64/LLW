/*
* 02_LED.cpp
*
* Created: 29.06.2020 10:35:08
* Author : lwngrmc
*/
#define F_CPU 12000000UL

#include <avr/io.h>
#include <util/delay.h>

int main(void)
{

	PORTA = 0x0F;
	// PROTC (LEDS) auf Ausgang setzen
	DDRC = 0xff;

	// PORTA (Taster) auf Eingang setzen
	DDRA = 0x00;
	
	while (1)
	{
		// Taster 0
		if(!(PINA & 0b00000001))
		{
			//		0b???????0
			//	   |0b00000001
			//	   -----------
			// 	   =0b???????1
			PORTC |= 0b0000001;
		}
		else
		{
			PORTC &= ~0b00000001;
		}
		// Taster 1
		
		if(!(PINA & 0b00000010))
		{
			PORTC |= 0b0000010;
		}
		else
		{
			PORTC &= ~0b00000010;
		}
			// Taster 2
		if(!(PINA & 0b00000100))
		{
			PORTC |= 0b00000100;
		}
		else
		{
			PORTC &= ~0b00000100;
		}
		
			// Taster 3
		if(!(PINA & 0b00001000))
		{
			PORTC |= 0b00001000;
		}
		else
		{
			PORTC &= ~0b00001000;
		}
		
	}
}

