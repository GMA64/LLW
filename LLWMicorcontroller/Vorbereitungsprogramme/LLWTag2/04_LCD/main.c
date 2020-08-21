/*
 * 04_LCD.c
 *
 * Created: 30.06.2020 08:41:24
 * Author : lwngrmc
 */ 

#include <avr/io.h>
#include "lcd.h"

int main(void)
{
	lcd_init();

    while (1) 
    {
		int zahl = -20;
		
		lcd_home();
		
		lcd_sl2ascii(zahl, 2, 8);
		
		lcd_cursor(0,1);

		lcd_string("0x");
		lcd_sl2ascii(zahl, 16, 2);
		
		lcd_string(" ");
		lcd_sl2ascii(zahl, 10, 3);
    }
}

