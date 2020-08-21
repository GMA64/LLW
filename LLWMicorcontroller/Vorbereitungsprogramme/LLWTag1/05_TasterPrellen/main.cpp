/*
 * 05_TasterPrellen.cpp
 *
 * Created: 29.06.2020 13:01:02
 * Author : lwngrmc
 */ 

#define F_CPU 16000000UL
#include <avr/io.h>
#include <util/delay.h>

int main(void)
{
	// PORTC leds auf ausgang
	DDRC = 0xff;

	// PORTA auf eingang
	DDRA = 0x00;
	PORTA = 0x0f;
	unsigned char x = 0;
    while (1) 
    {
		if (!(PINA & (0x01)))
		{
			_delay_ms(5);
			x++;
			PORTC = x;
			while(!(PINA & (0x01)));
			
			_delay_ms(5);
		}
    }
}

