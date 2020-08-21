/*
 * 01_LCD.c
 *
 * Created: 30.06.2020 08:47:02
 * Author : lwngrmc
 */ 

#include <avr/io.h>
#include "lcd.h"

int main(void)
{
    // initialisieren vom Display
    lcd_init();

    while (1)
    {
	    // Curser auf 0 Position Setzen
	    lcd_home();
	    
	    // String ausgabe für Display
	    lcd_string("Hallo");
	    
	    // 0 = aligment curser nach links
	    // 1 = zeile 1 auswählen
	    lcd_cursor(0,1);
	    
	    char text[] = "Hallo2";
	    lcd_string(text);			// Automatisch pointer nehmen
	    //lcd_string(&text[0]);		// array ausgeben mit &pointer übergeben

	    
    }
}

