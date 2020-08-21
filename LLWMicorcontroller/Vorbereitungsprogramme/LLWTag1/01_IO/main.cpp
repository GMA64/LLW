/*
* 01_IO.cpp
*
* Created: 29.06.2020 08:44:47
* Author : lwngrmc
*/
#define F_CPU 12000000UL
#define  S0 PINA0
#define  S1 PINA1
#define  S2 PINA2
#define  S3 PINA3

#include <avr/io.h>
#include <util/delay.h>



int main(void)
{
	// DDR? -> Data Dirction Register (A-?)
	// Bit 1 -> Ausgang
	// Bit 0 -> Eingang
	// DDRC = 0b11111111;
	// DDRC = 255;
	DDRC = 0xff;

	//DDRC = (1<<PINC0);

	//DDRC;					// 8 Bit register
	//PORTC;					// 8 Bit register
	//unsigned char temp;		// 8 Bit register

	DDRA = 0x00;	// Standardmäßig auf eingang geschalten
	// Bit 0 -> eingang
	//PORTA = 0x01;
	// Bit 1 -> Pullup-Widerstand einschalten
	PORTA = 0x0f;
	

	while (1)
	{
		// Output
		// 0b00000000;
		//~0b11111111;
		
		//PORTC = ~PORTC;	// ~ invertieren
		//PORTC ^= 0b00001111;	// ^XOR
		//_delay_ms(500); // Funktion in <until/delay.h>
		
		// Input
		
		// PINA zustand der einzelnen Bits am PORT
		// PINA		 0x01
		//			& 0x01
		//			-------
		//			= 0x01
		//
		//if (PINA & 0x01)
		//{
		//PORTC = 0b00000001;
		//PORTC = 0x01;
		//}
		//else
		//{
		//PORTC = 0b00000000;
		////PORTC = 0x00;
		//}
		//
		//if (PINA & 0b00000010)
		//{
		//PORTC = 0b00000010;
		//}
		//else
		//{
		//PORTC = 0b00000000;
		//}

		
		//if (PINA & (1<<S0))
		//{
			//PORTC = 0x0f;
		//}
		//else
		//{
			//PORTC = 0xf0;
		//}
		
		// Abfrage ob S0 gedrückt -> low ist
		// PINA -> 0bxxxxxxx?
		//		 ? 0b00000001
		//		 ------------
		//		 = 0b0000000?
		// If !(true)  wenn ?== 1
		// IF !(false) wenn ? == 0

		PORTC = ~PORTC;

		if (!(PINA & (1<<S0)))
		{
			_delay_ms(500);
		}
		else if (!(PINA & (1<<S1)))
		{
			_delay_ms(1000);
		}
		else if (!(PINA & (1<<S2)))
		{
			_delay_ms(2000);
		}
		else if (!(PINA & (1<<S3)))
		{
			_delay_ms(4000);
		}
		else
		{
			_delay_ms(250);
		}

	}
}

