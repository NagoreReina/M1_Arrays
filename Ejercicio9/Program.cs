using System;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear un array de 10 valores. Poner el valor 1 en cada una de la posición. 
            //Pedir al usuario que introduzca un número entre 0 y 9. Cada vez que introduzca un valor entre 0 y 9, 
            //mostrar el valor de esa posición del array, y modificarlo multiplicando por 2.
            int[] numbers = {1,1,1,1,1,1,1,1,1,1};
            int num = 0;
            do
            {
                Console.WriteLine("Introduce un numero entre 0 y 9");
                num = Convert.ToInt32(Console.ReadLine());
                if (num >= 0)
                {
                    if (num <= 9)
                    {
                        numbers[num] *= 2;
                        Console.WriteLine($"en la posición {num} el {numbers[num]}");
                    }
                }

            } while (num >= 0);
        }
    }
}
