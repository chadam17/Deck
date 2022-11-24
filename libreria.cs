using System;
using System.IO;
using System.Linq;
//using System.Collections.Generic;
namespace libreria {
	public enum Palo 
	{
		Picas = 0,
		Corazones,
		Treboles,
		Diamantes
	}
	public enum Valor : int
	{
		As = 0,
		Dos,
		Tres,
		Cuatro,
		Cinco,
		Seis,
		Siete,
		Ocho,
		Nueve,
		Diez,
		Jota,
		Caballo,
		Rey
	}
	//Clase para crear cartas
	public class Card 
	{
		//una vez asignado, representará gráficamente el símbolo del palo
		public char icono = ' '; 
		//una vez asignado, representará gráficamente el símbolo del valor 
		public string num = ""; 
		public Palo palo;
		public Valor valor;
		public Card(Palo p, Valor v)
		{
			palo = p;
			valor = v;
		}
		public Palo getPalo()
		{
			return palo;
		}
		public Valor getValor()
		{
			return valor;
		}
		public char getIcono()
		{
			return icono;
		}
		public string getNum()
		{
			return num;
		}
		//Sobreescritura del ToString() para que muestre el dibujo de la carta
		public override string ToString() 
		{
			switch(palo)
			{
				case Palo.Picas: icono = '♠';break;
				case Palo.Corazones: icono = '♥';break;
				case Palo.Treboles: icono = '♣';break;
				case Palo.Diamantes: icono = '♦';break;
			}
			switch(valor)
			{
				case Valor.As: num = "A";break;
				case Valor.Dos: num = "2";break;
				case Valor.Tres: num = "3";break;
				case Valor.Cuatro: num = "4";break;
				case Valor.Cinco: num = "5";break;
				case Valor.Seis: num = "6";break;
				case Valor.Siete: num = "7";break;
				case Valor.Ocho: num = "8";break;
				case Valor.Nueve: num = "9";break;
				case Valor.Diez: num = "10";break;
				case Valor.Jota: num = "J";break;
				case Valor.Caballo: num = "Q";break;
				case Valor.Rey: num = "K";break;
			}
			//Si es un 10 borramos algunos espacios porque es el único valor de 2 dígitos y se descuadra el dibujo
			if (num == "10") 
				return "┌───────────┐\n" + "│ " + num + "        │\n" + "│           │\n" + "│           │\n" + "│     " + icono + "     │\n" + "│           │\n" + "│           │\n" + "│        " + num + " │\n" + "└───────────┘";
			else
				return "┌───────────┐\n" + "│ " + num + "         │\n" + "│           │\n" + "│           │\n" + "│     " + icono + "     │\n" + "│           │\n" + "│           │\n" + "│         " + num + " │\n" + "└───────────┘";		
		}
		//Los siguientes métodos de partes de la carta sirven para ser llamados en bucle y poder generar dibujos de manos de cartas en disposición horizontal
		public void parte1() 
		{
			Console.Write("┌───────────┐");
		}
		public void parte2()
		{
			if (num == "10")
				Console.Write("│ " + getNum() + "        │");
			else
				Console.Write("│ " + getNum() + "         │");
		}
		public void parte3()
		{
			Console.Write("│           │");
		}
		public void parte4()
		{
			Console.Write("│           │");
		}
		public void parte5()
		{
			Console.Write("│     " + getIcono() + "     │");
		}
		public void parte6()
		{
			Console.Write("│           │");
		}
		public void parte7()
		{
			Console.Write("│           │");
		}
		public void parte8()
		{
			//Si es un 10 borramos algunos espacios porque es el único valor de 2 dígitos y se descuadra el dibujo
			if (num == "10") 
				Console.Write("│        " + getNum() + " │");
			else
				Console.Write("│         " + getNum() + " │");
		}
		public void parte9()
		{
			Console.Write("└───────────┘");
		}
	}
	//Clase para crear barajas de 52 cartas (13 de cada uno de los 4 palos)
	public class Deck 
	{
		public Card[] array = new Card[52];
		private int cont = -1;
		
		public Deck() { cargar(); }
		//Va cargando las cartas en la baraja
		public void cargar()  
		{	
			int x=0;
			for (Palo i=0; i <= Palo.Diamantes; i++) {
				for (Valor j=0; j <= Valor.Rey; j++) {					
					array[x] = new Card(i,j);
					x++;
				}
			}					
		}
		//reorganiza la baraja cambiando las cartas de posición (también puede hacerse con una función swap que saque dos posiciones al azar y las intercambie)
		public void barajar() 
		{
			Random random = new Random();

			array = array.OrderBy(x => random.Next(52)).ToArray();
			Console.WriteLine(array[w]);
		}
		//Muestra la siguiente carta de la baraja
		public Card siguiente() 
		{
			if (cont == 51)
				cont = 0;
			else
				cont++;
			return array[cont];	
		}
		// una bandera para denotar que hemos llegado al final de la baraja
		public bool estaVacia() 
		{
			bool vacia=false;
			if(cont==51)
				vacia=true;
			return vacia;	
		}
		public int getCont()
		{
			return cont;
		}
		//Devuelve el array de cartas, útil para instanciar mazos
		public Card[] getArray() 
		{
			return array;
		}
		// Muestra la baraja en 4 filas de 13 cartas cada una
		public void mostrar() 
		{
			int a=0, b=0, c=0, d=0, e=0, f=0, g=0, h=0, i=0;
			int A=13, B=13, C=13, D=13, E=13, F=13, G=13, H=13, I=13;
			int lap=0;

			while (lap < 4) {
				for (; a < A; a++) {
						Console.Write("┌───────────┐");
						if (a == A-1) 
							Console.WriteLine();	
				}
			    
			     for (; i < I; i++) {       
				    switch(array[i].palo)
						{
							case Palo.Picas: array[i].icono = '♠';break;
							case Palo.Corazones: array[i].icono = '♥';break;
							case Palo.Treboles: array[i].icono = '♣';break;
							case Palo.Diamantes: array[i].icono = '♦';break;
						}
						switch(array[i].valor)
						{
							case Valor.As: array[i].num = "A";break;
							case Valor.Dos: array[i].num = "2";break;
							case Valor.Tres: array[i].num = "3";break;
							case Valor.Cuatro: array[i].num = "4";break;
							case Valor.Cinco: array[i].num = "5";break;
							case Valor.Seis: array[i].num = "6";break;
							case Valor.Siete: array[i].num = "7";break;
							case Valor.Ocho: array[i].num = "8";break;
							case Valor.Nueve: array[i].num = "9";break;
							case Valor.Diez: array[i].num = "10";break;
							case Valor.Jota: array[i].num = "J";break;
							case Valor.Caballo: array[i].num = "Q";break;
							case Valor.Rey: array[i].num = "K";break;
						}
						//Si es un 10 borramos algunos espacios porque es el único valor de 2 dígitos y se descuadra el dibujo
						if (array[i].num == "10") 
							Console.Write("│ " + array[i].num + "        │");
						else	
							Console.Write("│ " + array[i].num + "         │");

						if (i == I-1) 
							Console.WriteLine();
				}
				
					for (; c < C; c++) {
						Console.Write("│           │"); 
						if (c == C-1) 
							Console.WriteLine();
					}
		  			for (; d < D; d++) {
						Console.Write("│           │");
						if (d == D-1) 
								Console.WriteLine();
					}
					for (; e < E; e++) {
						Console.Write("│     " + array[e].icono + "     │");
						if (e == E-1) 
							Console.WriteLine();	
					}
					for (; f < F; f++) { 
						Console.Write("│           │");
						if (f == F-1) 
							Console.WriteLine();
					} 
		  			for (; g < G; g++) { 
							Console.Write("│           │");
							if (g == G-1) 
							Console.WriteLine();
					}
					for (; h < H; h++) {
						if (array[h].num == "10")
							Console.Write("│        " + array[h].num + " │");
						else	
							Console.Write("│         " + array[h].num + " │");

							if (h == H-1) 
							Console.WriteLine();
					}

					for (; b < B; b++) { 
						Console.Write("└───────────┘");
						if (b == B-1) 
							Console.WriteLine();	
					}
										A+=13;C+=13;D+=13;E+=13;F+=13;G+=13;H+=13;I+=13;B+=13;
										lap++;
				}
			}
		// Esto es para asignar valores a icono y num y que puedan ser mostrados en terminal, de lo contrario sus valores están vacíos
		public void asignar() 
		{
			int i=0;
			int I=13;
			int lap=0;

		while (lap < 4) {
			for (; i < I; i++) {       
		    switch(array[i].palo)
				{
					case Palo.Picas: array[i].icono = '♠';break;
					case Palo.Corazones: array[i].icono = '♥';break;
					case Palo.Treboles: array[i].icono = '♣';break;
					case Palo.Diamantes: array[i].icono = '♦';break;
				}
				switch(array[i].valor)
				{
					case Valor.As: array[i].num = "A";break;
					case Valor.Dos: array[i].num = "2";break;
					case Valor.Tres: array[i].num = "3";break;
					case Valor.Cuatro: array[i].num = "4";break;
					case Valor.Cinco: array[i].num = "5";break;
					case Valor.Seis: array[i].num = "6";break;
					case Valor.Siete: array[i].num = "7";break;
					case Valor.Ocho: array[i].num = "8";break;
					case Valor.Nueve: array[i].num = "9";break;
					case Valor.Diez: array[i].num = "10";break;
					case Valor.Jota: array[i].num = "J";break;
					case Valor.Caballo: array[i].num = "Q";break;
					case Valor.Rey: array[i].num = "K";break;
				}
		  }
		  I+=13;lap++;
		}
		}
	}
}	
