/*II) Crear una aplicación de cliente obtenga cinco cartas de una baraja previamente barajada.
Si tres cartas son del mismo palo debe indicarlo en pantalla. Si no son del mismo palo,
mostrar un mensaje indicando que vuelvo a intentarlo hasta que lo consiga.*/
using System;
using System.IO;
using libreria;
class MainClass
{
    public static void Main(string[] args)
    {  
        Deck d1 = new Deck();
        d1.barajar();
        Card[] mazo = d1.getArray();
        d1.asignar();
        int contP=0,contT=0,contD=0,contC=0,contV=0;
        int a=0, b=0, c=0, d=0, e=0, f=0, g=0, h=0, i=0, j=0;
        int A=5, B=5, C=5, D=5, E=5, F=5, G=5, H=5, I=5, J=5;
       
        while((contP<3)&&(contT<3)&&(contD<3)&&(contC<3))
        {
            if (j==52) {
                    Console.WriteLine("Has perdido, no quedan cartas");
                    Environment.Exit(0);
                }
            Console.WriteLine("Tu mano es:");
            contV++;
            contP=0;contT=0;contD=0;contC=0;
            
                
                //Los bucles dan 5 pasadas para mostrar 5 cartas cada vez
                for (; a < A; a++) 
                    mazo[a].parte1();              
                
                Console.WriteLine();
                for (; b < B; b++) 
                    mazo[b].parte2();

                Console.WriteLine();
                for (; c < C; c++) 
                    mazo[c].parte3();
                
                Console.WriteLine();
                for (; d < D; d++) 
                    mazo[d].parte4();

                Console.WriteLine();
                for (; e < E; e++) 
                    mazo[e].parte5();

                Console.WriteLine();
                for (; f < F; f++) 
                    mazo[f].parte6();

                Console.WriteLine();
                for (; g < G; g++) 
                    mazo[g].parte7();
 
                Console.WriteLine();
                for (; h < H; h++) 
                    mazo[h].parte8();
  
                Console.WriteLine();
                for (; i < I; i++) 
                    mazo[i].parte9();
                
                Console.WriteLine();
                for (; j < J; j++) {
                    if(mazo[j].palo==Palo.Picas)
                        contP++;
                    if(mazo[j].palo==Palo.Treboles)
                        contT++;
                    if(mazo[j].palo==Palo.Diamantes)
                        contD++;
                    if(mazo[j].palo==Palo.Corazones)
                        contC++;            
                }
                //Console.WriteLine(A);
                A+=5;B+=5;C+=5;D+=5;E+=5;F+=5;G+=5;H+=5;I+=5;J+=5; 
                
                //En caso de haber sacado 50 cartas, no puede coger otras 5, pues solo quedan 2, de modo que los bucles dan 2 pasadas esta vez
                if (J == 50) {
                    contP=0;contT=0;contD=0;contC=0;
                    Console.WriteLine("Tu mano es:");
                    for (; a < A; a++) 
                    mazo[a].parte1();              
                
                Console.WriteLine();
                for (; b < B; b++) 
                    mazo[b].parte2();

                Console.WriteLine();
                for (; c < C; c++) 
                    mazo[c].parte3();
                
                Console.WriteLine();
                for (; d < D; d++) 
                    mazo[d].parte4();

                Console.WriteLine();
                for (; e < E; e++) 
                    mazo[e].parte5();

                Console.WriteLine();
                for (; f < F; f++) 
                    mazo[f].parte6();

                Console.WriteLine();
                for (; g < G; g++) 
                    mazo[g].parte7();
 
                Console.WriteLine();
                for (; h < H; h++) 
                    mazo[h].parte8();
  
                Console.WriteLine();
                for (; i < I; i++) 
                    mazo[i].parte9();

                 Console.WriteLine();
                 for (; j < J; j++) {
                    if(mazo[j].palo==Palo.Picas)
                        contP++;
                    if(mazo[j].palo==Palo.Treboles)
                        contT++;
                    if(mazo[j].palo==Palo.Diamantes)
                        contD++;
                    if(mazo[j].palo==Palo.Corazones)
                        contC++;            
                }
                
                    A+=2;B+=2;C+=2;D+=2;E+=2;F+=2;G+=2;H+=2;I+=2;J+=2;  
                 }   
        }    
        Console.WriteLine("Has ganado :)\n" + "Número de manos: " +contV);
    }
}        