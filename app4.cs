/*IV) Juego de dos jugadores donde se escoge una carta aleatoria y se van robando cartas de una en una en turno rotatorio hasta dar con la carta inicial. Gana el jugador que le toca dicha carta*/

using System;
using System.IO;
using System.Linq;
using libreria;
class MainClass
{
    public static void Main(string[] args)
    {  
    	Deck d1 = new Deck();
        d1.barajar();
        d1.asignar();
        int ronda = 1;
        Card[] mazo = d1.getArray();
        //Card player = d1.siguiente();
        //Card dealer = d1.siguiente();
        Random random = new Random();
        Card aleatoria = mazo[random.Next(52)];
        d1.mostrar();
        while (!d1.estaVacia()) 
        {
        	Card player = d1.siguiente();
        	Card dealer = d1.siguiente();
        	Console.WriteLine("=====================================");
        	Console.Write("WANTED\n");
            if (ronda == 26) 
                Console.WriteLine(aleatoria);
            else {
                aleatoria.parte1();Console.Write("\t\t");Console.Write("┌───────────┐");Console.WriteLine();
                aleatoria.parte2();Console.Write("\t\t");Console.Write("│░ ░ ░ ░ ░ ░│");Console.WriteLine();
                aleatoria.parte3();Console.Write("\t\t");Console.Write("│ ░ ░ ░ ░ ░ │");Console.WriteLine();
                aleatoria.parte4();Console.Write("\t\t");Console.Write("│░ ░ ░ ░ ░ ░│");Console.WriteLine();
                aleatoria.parte5();Console.Write("\t\t");Console.Write("│ ░ ░ ░ ░ ░ │");Console.WriteLine();
                aleatoria.parte6();Console.Write("\t\t");Console.Write("│░ ░ ░ ░ ░ ░│");Console.WriteLine();
                aleatoria.parte7();Console.Write("\t\t");Console.Write("│ ░ ░ ░ ░ ░ │");Console.WriteLine();
                aleatoria.parte8();Console.Write("\t\t");Console.Write("│░ ░ ░ ░ ░ ░│");Console.WriteLine();
                aleatoria.parte9();Console.Write("\t\t");Console.Write("└───────────┘");Console.WriteLine();
            }
        	Console.WriteLine("Jugador\t\t\tRival");
        	player.parte1();Console.Write("\t\t");dealer.parte1();Console.WriteLine();
        	player.parte2();Console.Write("\t\t");dealer.parte2();Console.WriteLine();
        	player.parte3();Console.Write("\t\t");dealer.parte3();Console.WriteLine();
        	player.parte4();Console.Write("\t\t");dealer.parte4();Console.WriteLine();
        	player.parte5();Console.Write("\t\t");dealer.parte5();Console.WriteLine();
        	player.parte6();Console.Write("\t\t");dealer.parte6();Console.WriteLine();
        	player.parte7();Console.Write("\t\t");dealer.parte7();Console.WriteLine();
        	player.parte8();Console.Write("\t\t");dealer.parte8();Console.WriteLine();
        	player.parte9();Console.Write("\t\t");dealer.parte9();Console.WriteLine();
        	Console.WriteLine("Quedan: " + (52-(1+d1.getCont())) + " cartas en la baraja.");
        	if (player == aleatoria)
        	{
        		Console.WriteLine("You win");
        		Console.WriteLine("Rondas jugadas: " + ronda);
        		Environment.Exit(0);
        	}
        	if (dealer == aleatoria)
        	{
        		Console.WriteLine("You lose");
        		Console.WriteLine("Rondas jugadas: " + ronda);
        		Environment.Exit(0);
        	}
        	
        	ronda++;
        }
    }
}