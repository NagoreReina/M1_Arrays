using System;

namespace Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crear un array de dos dimensiones, de 5 posiciones cada una. Rellenar los valores con 0. 
             * Pedir al usuario dos números, utilizar eso como la posición de la 1 dimensión y la 2 dimensión 
             * y poner un 1 en esa posición. Mostrar el array (en filas y columnas) en pantalla 
             * (deberían ser todo 0 menos un 1).
             */
            int[,] numbers = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    numbers[i, j] = 0;
                }
            }
            Console.WriteLine("Escribe un numero del 1 al 5");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escribe un numero del 1 al 5");
            int num2 = Convert.ToInt32(Console.ReadLine());
            numbers[num1-1, num2-1] = 1;
            Console.WriteLine("-----------------------------");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"{numbers[i, j]}\t");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
