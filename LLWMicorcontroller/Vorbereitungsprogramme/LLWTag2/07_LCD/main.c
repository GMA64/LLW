/*
* 07_LCD.c
*
* Created: 30.06.2020 09:33:40
* Author : lwngrmc
*/

#define F_CPU 12000000UL

#include <util/delay.h>
#include <avr/io.h>
#include "lcd.h"

int main(void)
{
	lcd_init();
	unsigned char pattern_bell[] ={
		0b01110,
		0b01110,
		0b01110,
		0b00100,
		0b11111,
		0b00100,
		0b01010,
		0b10001,
	};
	
	unsigned char pattern_balken[] ={
		0b11111,
		0b11111,
		0b11111,
		0b11111,
		0b11111,
		0b11111,
		0b11111,
		0b11111,
	};

	lcd_pattern(LCD_CGADDR_CHAR0, pattern_bell);
	lcd_pattern(LCD_CGADDR_CHAR1, pattern_balken);

	while (1)
	{
		lcd_home();
		lcd_char(LCD_CGADDR_CHAR0);
		lcd_char(LCD_CGADDR_CHAR0);

		lcd_cursor(4,0);
		lcd_char(LCD_CGADDR_CHAR1);
		lcd_char(LCD_CGADDR_CHAR1);
		
		lcd_cursor(0,1);
		for (unsigned char i=0; i < 8; i++)
		{
			lcd_char(LCD_CGADDR_CHAR1);
			_delay_ms(1000);
		}
		
		lcd_clear();
	}
}

