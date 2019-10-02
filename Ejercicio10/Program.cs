using System;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programa que lee las edades de 20 alumnos (validado entre 18 y 35), 
            //las almacena en un array y calcula y escribe su media (para probar, se pueden generar 
            //aleatoriamente entre 18 y 35)
            int[] ages = new int[20];
            Random randomNum = new Random();
            double result = 0;

            for (int i = 0; i < ages.Length; i++)
            {
                ages[i] = randomNum.Next(18, 36);
                result += ages[i];
            }
            result /= 20;

            Console.WriteLine($"La media es {result}");
        }
    }
}
