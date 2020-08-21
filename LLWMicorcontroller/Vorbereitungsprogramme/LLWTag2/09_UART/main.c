/*
 * 09_UART.c
 *
 * Created: 30.06.2020 14:12:30
 * Author : lwngrmc
 */ 
#define F_CPU 12000000UL

#include <avr/io.h>
#include <util/delay.h>
#include "uart.h"

int main(void)
{
	// Datenübertragung 9600B aud/ 8 Datenbit / kein Paritätbit / 1 Stoppbit
	uart_init();

    while (1) 
    {
		// \n ->new line,  \r return to 0 position
		printf("test \n\r");
		
		_delay_ms(1000);
    }
}

