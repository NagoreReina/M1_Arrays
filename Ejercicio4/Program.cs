using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear un array de 3 ints. Usar un for para pedir al usuario que introduzca valores a 
            //cada una de las posiciones. Usar otro for para mostrarlos en pantalla.
            int[] numbers = new int[3];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Introduce el {i+1}º numero");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("___________________________");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);

            }
        }
    }
}
