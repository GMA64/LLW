/*
 * 02_LCD.c
 *
 * Created: 30.06.2020 08:47:46
 * Author : lwngrmc
 */ 

#include <avr/io.h>
#include "lcd.h"

int main(void)
{
	// LCD display initialisieren
	lcd_init();

	while (1)
	{
		// curser auf 0,0 setzen
		lcd_home();
		
		lcd_char('T');
		lcd_char('E');
		lcd_char('S');
		lcd_char('T');
		
		lcd_cursor(3,1);
		
		char test = '1';
		lcd_char(test);
		lcd_char('E');
		lcd_char('S');
		lcd_char('T');
	}
}

