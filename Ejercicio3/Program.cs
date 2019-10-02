using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear un array de 10 ints. Usar un for para asignar los valores de 20 a 11 a las 10 posiciones 
            //(en orden descendente). Usar un for para mostrar los 10 valores en pantalla.

            int[] numbers = new int[10];
            int value = 20;
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = value;
                value--;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);

            }
        }
    }
}
