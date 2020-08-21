/*
 * 08_ProjektLEDPotenztiometer.cpp
 *
 * Created: 29.06.2020 14:59:43
 * Author : lwngrmc
 */ 

#include <avr/io.h>
#include "adc.h"
#include "adc.c"

int main(void)
{
	// PORTC als LED ausgang
	DDRC = 0xff;
	
	// initialise AD
	adc_init();
	adc_channel(5);
	
    while (1) 
    {	
		unsigned char data = (adc_read()>>7);
		
		PORTC = (1<<data);
    }
}

