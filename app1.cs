/*I) Crear una aplicación de cliente que haga uso del módulo de librería que baraje la carta y vaya sacando una a una las cartas mostrando qué carta se ha sacado ( una cadena en modo texto que lo indique)*/
using System;
using System.IO;
using System.Linq;
//using System.Collections.Generic;
using libreria;
 class MainClass
 {
     public static void Main(string[] args)
     {  
        //Instancia una baraja, la mezcla y la muestra
         Deck d1 = new Deck();
         Console.WriteLine("\nMazo ordenado\n");
         d1.mostrar();
         Console.WriteLine("\nMazo barajado\n");
        d1.barajar();
        d1.mostrar();
        //Bucle que va sacando una a una todas las cartas de la baraja
         Console.WriteLine("\nEmpieza a robar cartas\n");
         for(int i=0;i<52;i++) {
            Console.WriteLine("Siguiente carta: ");
            Console.WriteLine(d1.siguiente());
            if (d1.estaVacia()) {
                Console.WriteLine("\nYa no quedan cartas");
                Environment.Exit(0);
            }
        }
     }
 }