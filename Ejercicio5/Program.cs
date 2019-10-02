using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear un array de 3 ints. Usar un for para pedir al usuario que introduzca valores a cada una de las
            //posiciones. Mirar los valores del array una vez tenga los 3 valores y mostrar en pantalla el más pequeño.
            int[] numbers = new int[3];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Introduce el {i + 1}º numero");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("___________________________");
            if (numbers[0]> numbers[1] && numbers[0]> numbers[2])
            {
                Console.WriteLine(numbers[0]);
            }
            else if (numbers[1] > numbers[0] && numbers[1] > numbers[2])
            {
                Console.WriteLine(numbers[1]);
            }
            else
            {
                Console.WriteLine(numbers[2]);
            }
        }
    }
}
