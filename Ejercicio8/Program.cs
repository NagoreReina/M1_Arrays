using System;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Crear un array de 11 ints. Pedir al usuario que introduzca valores entre 0 y 10. 
            Cada vez que introduzca un dígito, añadir uno al valor en esa posición del array. 
            Si por ejemplo introduce un 3, sumar uno a la posición 3. Mostrar en pantalla los valores. 
            Si introduce un número mayor que 10, decir que ese número es incorrecto. 
            Si introduce un número negativo, mostrar en pantalla el número de cada posición 
            y el valor que contiene. Por ejemplo, si introduce 7, 7, 7, 5, 6, 5, 9, 9, 10, -1 mostrar:
            0	
            1	0
            2	0
            3	0
            4	0
            5	2

            6	1
            7	3
            8	0
            9	2
            10	1
             */
            int[] numbers = new int[11];
            int num = 0;
            do
            {
                Console.WriteLine("Introduce un numero entre 0 y 10");
                num = Convert.ToInt32(Console.ReadLine());
                if (num >= 0)
                {
                    if (num < 11)
                    {
                        numbers[num]++;
                    }
                    else
                    {
                        Console.WriteLine("numero incorrecto");
                    }
                }
            } while (num >= 0);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{i} \t {numbers[i]}");
            }
        }
    }
}
