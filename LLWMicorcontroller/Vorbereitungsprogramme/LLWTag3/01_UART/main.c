/*
 * 01_UART.c
 *
 * Created: 01.07.2020 07:25:12
 * Author : lwngrmc
 */ 

#define F_CPU 12000000UL

#include <avr/io.h>
#include <util/delay.h>
#include "uart.h"

int main(void)
{
	uart_init();

    while (1) 
    {
		char buffer[30];
		
		printf("Eingabe: ");
		
		if(scanf("%29s", buffer) != 0)	// letzte zeichen im Array '\0' muss berücksichtig werden
		{
			printf("\nAusgabe: ");
			printf("%s\n\r", buffer);
		}
		else
		{
			uart_error();
			printf("\n\rFehler!\n\r");
		}
    }
}

