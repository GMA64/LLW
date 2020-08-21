/*
 * 07_Analog.cpp
 *
 * Created: 29.06.2020 14:11:13
 * Author : lwngrmc
 */ 

#include <avr/io.h>
#include "adc.h"
#include "adc.c"

int main(void)
{
	// PORTC als Ausgang
	DDRC = 0xff;
	
	// ADC inititalisieren
	adc_init();
	adc_channel(5);

    while (1) 
    {
		unsigned int data = adc_read();
		
		// Ergebnis des AD Converter ist 10 Bit groß
		// umwandlung auf 8 Bit notwendig
		data = (data>>2);
		
		
		PORTC = data;
    }
}

