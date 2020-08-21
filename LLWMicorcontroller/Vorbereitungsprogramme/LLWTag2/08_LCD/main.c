/*
* 08_LCD.c
*
* Created: 30.06.2020 09:55:09
* Author : lwngrmc
*/
#define F_CPU 12000000UL

#include <util/delay.h>
#include <avr/io.h>
#include "lcd.h"

int main(void)
{
	lcd_init();

	lcd_home();
	
	// Pro zeile können maximal ? Zeichen eingegeben werden!!!
	lcd_string("Hello World, test programm for lcd");

	while (1)
	{
		
		// 0 = rechts - links schieben
		// 1 = links - rechts schieben
		lcd_shift(1);
		_delay_ms(800);
	}
}

