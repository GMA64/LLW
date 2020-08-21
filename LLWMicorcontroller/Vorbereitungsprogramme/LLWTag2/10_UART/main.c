/*
 * 10_UART.c
 *
 * Created: 30.06.2020 14:54:52
 * Author : lwngrmc
 */ 

#define F_CPU 12000000UL

#include <avr/io.h>
#include <util/delay.h>
#include "uart.h"

int main(void)
{
	uart_init();

	unsigned char i = 0;

    while (1) 
    {
		printf("[%u]: Hallo! \n\r", (i++));
		_delay_ms(100);
    }
}

