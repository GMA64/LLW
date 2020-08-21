/*
 * uebnung.c
 *
 * Created: 20.08.2020 09:27:20
 * Author : lwngrmc
 */ 
#define F_CPU 12000000UL

#include <util/delay.h>
#include <avr/io.h>


int main(void)
{
	DDRC = 0xff;
	PORTC = 0x01;
	
	DDRA = 0x00;
	PORTA = 0xff;
	
    while (1) 
    {
		PORTC = (PORTC>>7) | (PORTC<<1);
		
		_delay_ms(700);

    }
}

