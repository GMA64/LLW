/*
 * 11_UART.c
 *
 * Created: 30.06.2020 15:10:45
 * Author : lwngrmc
 */ 
#define  F_CPU 12000000UL

#include <avr/io.h>
#include <util/delay.h>
#include "uart.h"


int main(void)
{
	uart_init();
	
    while (1) 
    {
		printf("Eingabe: ");
		
		unsigned int data;
		if(scanf("%4u", &data) != 1)
		{
			uart_error();
		}
		
		printf("\n\r%u\n\r");
    }
}

