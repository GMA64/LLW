/*
* 06_Funktionen.cpp
*
* Created: 29.06.2020 13:31:22
* Author : lwngrmc
*/
#define F_CPU 12000000UL
#include <avr/io.h>
#include <util/delay.h>

// Prototyp
unsigned char addition(unsigned char a, unsigned char b);
void swap(unsigned char *a, unsigned char *b);

int main(void)
{
	// PORTC auf ausgang setzen
	DDRC = 0xff;	
	
	while (1)
	{
		unsigned char x = 10;
		unsigned char y = 20;
		
		_delay_ms(2000);
		
		PORTC = addition(x,y);
		
		_delay_ms(2000);
		
		swap(&x, &y);
		
		PORTC = x;
		_delay_ms(2000);
	}
}

// Funktion
// Call by Value
unsigned char addition(unsigned char x, unsigned char y)
{
	return x+y;
}

void swap(unsigned char *a, unsigned char *b)
{
	unsigned char temp = *a;
	*a = *b;
	*b = temp;
}
