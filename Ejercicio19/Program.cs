using System;
using System.Collections.Generic;

namespace Ejercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            //3. Volver al ejercicio 13 de los arrays y en este caso hacerlo usando Dictionary.
            /*
            Cargar una tabla de 20 elementos donde cada elemento almacenará un valor entre 1 y 9 
             (genéralos de forma aleatoria) y escribir, además del contenido de la tabla, la cantidad de 1, 
             cantidad de 2, cantidad de 3…, cantidad de 9 almacenados en ella. 
             */
            Dictionary<int, int> nums = new Dictionary<int, int>();
            Random randNum = new Random();
            Console.WriteLine("Los valores que han salido son: ");
            for (int i = 0; i < 20; i++)
            {
                int value = randNum.Next(1, 10);
                if (nums.ContainsKey(value))
                {
                    nums[value]++;
                }
                else
                {
                    nums.Add(value, 1);
                }
                Console.Write($"{value}, ");
            }
            Console.WriteLine("");
            for (int i = 0; i < 10; i++)
            {
                if (nums.ContainsKey(i))
                {
                    Console.WriteLine($"el numero {i} ha salido, {nums[i]} veces");
                }
                else
                {
                    Console.WriteLine($"el numero {i} ha salido, 0 veces");
                }
            }
        }
    }
}
