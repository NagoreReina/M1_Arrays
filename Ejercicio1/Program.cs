using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear un array de 10 ints. Asignar un valor a cada uno de las 10 posiciones. 
            //Mostrar los 10 valores en pantalla.
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
