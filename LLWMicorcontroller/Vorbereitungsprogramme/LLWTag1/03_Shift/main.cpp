/*
 * 03_Shift.cpp
 *
 * Created: 29.06.2020 11:17:27
 * Author : lwngrmc
 */ 

#define  F_CPU 12000000UL

#include <avr/io.h>
#include <util/delay.h>

int main(void)
{
	// Portc als Ausgang definieren
	DDRC = 0xff;
	
	// die 0. LED einschalten
	//PORTC = 0x01;
	PORTC = 0x03;
	
    while (1) 
    {
		_delay_ms(1000);
		//// Schieben 1. Stelle
		//
		//// 1. Zyklus
		//// PORTC 0b00000001
		//// <<
		//// 2. Zyklus
		//// PORTC 0b00000010
		//// ...
		//PORTC = (PORTC<<1);
		//
		
		// Rotieren umd 1. stelle
		
		PORTC = (PORTC<<1) | (PORTC>>7);
		
		// Links schieben kann zum multiplizieren Verwendet werden *2, *4, *8, *16, ...
		// rechts schieben kann zum dividieren verwendet werden /2, /4, /8, /16,...
	}
}

