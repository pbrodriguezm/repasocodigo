using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int entera;
            float flotante = 2.2f; // 32 bits 7 digitos
            double doble = 2.2; 
            string texto="texto aquí";
            char caracter = 'A';
            bool booleana = true; //FALSE

            //ARREGLOS: contenedores de tipos de datos
            String[] vocales_originales = new String[5];
            String[] vocales_alrevez = new String[5];

            //FOR: BUCLES O REPETICIOS HASTA QUE SE DETENGA
            //Ejercicio : Leer desde teclado y guardar vocales
                   //variable        // Pregunta                       //Incrementa
            for (   int i=0   ;      i< vocales_originales.Length     ;     i++   )
            {
                String var = Console.ReadLine(); //LEER DESDE TECLADO
                vocales_originales[i] = var;
            }

            //Ejercicio: Imprimir array
            int x = 0;
            //while : Mientras (sea Verdad) ejecutar contexto
            while (  x < vocales_originales.Length)
            {
                Console.WriteLine(vocales_originales[x]);
                x++;
            }

            //Invertir array de vocales
            int y = 4;
            for (int i = 0; i < vocales_originales.Length; i++)
            {

                vocales_alrevez[i] = vocales_originales[y] ;
                y--;
            }

            Console.ReadKey();
        }
    }
}
