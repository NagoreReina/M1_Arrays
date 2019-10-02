using System;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer la media de 10 valores utilizando un array.
            double[] numbers = {10,10,10,10,10,10,7,8,9,10};
            double suma = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                suma += numbers[i];
            }
            suma = suma / 10;
            Console.WriteLine($"La media es {suma}");
        }
    }
}
