/*III) Realizar una aplicación de cliente que simule un pequeño juego entre dos jugadores.
Cada jugador sacará diez cartas de la baraja y se irán comparando de una en una en turno
rotatorio. Si son del mismo palo se comparan las cartas y se lleva un punto el que tenga la
carta más alta (y el primero pasa a ser el otro). Si son de distinto palo gana el punto quien
sacó la primera carta*/

using System;
using System.IO;
using libreria;
class MainClass
{
    public static void Main(string[] args)
    {  
    	Deck d1 = new Deck();
        d1.barajar();
        d1.asignar();
        Card[] mazo = d1.getArray();
        Card[] player = new Card[10];
        Card[] dealer = new Card[10];

        //Cada jugador escoge 10 cartas de la baraja mezclada	
        for (int x=0; x < 10; x++) {
        	player[x] = mazo[x];
        	dealer[x] = mazo[10+x];
        }
        int a=0, b=0, c=0, d=0, e=0, f=0, g=0, h=0, i=0;
        int A=10, B=10, C=10, D=10, E=10, F=10, G=10, H=10, I=10;
//        d1.mostrar();
//        Console.WriteLine();
        	//Muestra la mano del jugador
        		Console.WriteLine("Jugador");
       	 		for (; a < A; a++) 
                    player[a].parte1();              
                
                Console.WriteLine();
                for (; b < B; b++) 
                    player[b].parte2();

                Console.WriteLine();
                for (; c < C; c++) 
                    player[c].parte3();
                
                Console.WriteLine();
                for (; d < D; d++) 
                    player[d].parte4();

                Console.WriteLine();
                for (; e < E; e++) 
                    player[e].parte5();

                Console.WriteLine();
                for (; f < F; f++) 
                    player[f].parte6();

                Console.WriteLine();
                for (; g < G; g++) 
                    player[g].parte7();
 
                Console.WriteLine();
                for (; h < H; h++) 
                    player[h].parte8();
  
                Console.WriteLine();
                for (; i < I; i++) 
                    player[i].parte9();
                
                Console.WriteLine();
                
                a=0;b=0;c=0;d=0;e=0;f=0;g=0;h=0;i=0;
        
                //Muestra la mano del rival
                Console.WriteLine("Rival");
             	for (; a < A; a++) 
                    dealer[a].parte1();              
                
                Console.WriteLine();
                for (; b < B; b++) 
                    dealer[b].parte2();

                Console.WriteLine();
                for (; c < C; c++) 
                    dealer[c].parte3();
                
                Console.WriteLine();
                for (; d < D; d++) 
                    dealer[d].parte4();

                Console.WriteLine();
                for (; e < E; e++) 
                    dealer[e].parte5();

                Console.WriteLine();
                for (; f < F; f++) 
                    dealer[f].parte6();

                Console.WriteLine();
                for (; g < G; g++) 
                    dealer[g].parte7();
 
                Console.WriteLine();
                for (; h < H; h++) 
                    dealer[h].parte8();
  
                Console.WriteLine();
                for (; i < I; i++) 
                    dealer[i].parte9();
                
                Console.WriteLine();

                //Empieza la partida
                int puntosP=0, puntosD=0;
                bool turno = true;
                int k=0;
                while (k < 10) {
					if ((player[k].palo != dealer[k].palo) && (turno == true)) {
						puntosP++;
						turno = false;
					}
					else
				    	if ((player[k].palo != dealer[k].palo) && (turno == false)) {
				    		puntosD++;
				    		turno = true;
				    	}
				    	else
				        	if (player[k].palo == dealer[k].palo) {
				        		if (player[k].valor > dealer[k].valor) {
				        			puntosP++;
				        			turno = false;
				        		}
				        		else
				            		if (player[k].valor < dealer[k].valor) {
				            			puntosD++;
				            			turno = true;
				            		}
				        	}
					k++;
				}
                Console.WriteLine("MARCADOR FINAL\n" + "Jugador: " + puntosP + " puntos.\n" + "Rival: " + puntosD + " puntos.");
    }
}