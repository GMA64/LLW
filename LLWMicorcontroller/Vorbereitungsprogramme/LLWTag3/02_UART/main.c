/*
 * 02_UART.c
 *
 * Created: 01.07.2020 07:50:19
 * Author : lwngrmc
 */ 
#define F_CPU 12000000UL

#include <avr/io.h>
#include <util/delay.h>
#include "uart.h"

int main(void)
{
	uart_init();

	printf("\e[1;1H\e[2J");

    while (1) 
    {
		double zahl;
		
		printf("\n\rEingabe: ");
		if(scanf("%f", &zahl) == 1)
		{
			printf("\n\rAusgabe: ");
			printf("%f", zahl);
		}
		else
		{
			uart_error();
			printf("\n\rError\n\r");
		}
		_delay_ms(1500);
    }
}

