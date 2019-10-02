using System;

namespace Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Cargar una tabla de 20 elementos donde cada elemento almacenará un valor entre 1 y 9 
             * (genéralos de forma aleatoria) y escribir, además del contenido de la tabla, la cantidad de 1, 
             * cantidad de 2, cantidad de 3…, cantidad de 9 almacenados en ella. 
             */
            int[] num = new int[20];
            Random randomNum = new Random();
            int[] count = new int[10];

            //Generar los numeros aleatorios
            for (int i = 0; i < num.Length; i++)
            {
                num[i] = randomNum.Next(1, 10);
            }
            //Contar cuantas veces sale cada numero
            for (int x = 1; x < 10; x++)
            {
                for (int y = 0; y < num.Length; y++)
                {
                    if (num[y] == x)
                        count[x]++;
                }
            }
            //Sacar en consola
            Console.WriteLine("Los valores que han salido son: ");
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write($"{num[i]}, ");
            }
            Console.WriteLine("\nY estos son los datos de cuantas veces aparece cada valor:");
            for (int i = 1; i < count.Length; i++)
            {
                Console.Write($"{i} sale {count[i]} veces, ");
            }
        }
    }
}
