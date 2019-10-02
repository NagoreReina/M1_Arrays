using System;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crear un array de dos dimensiones, del tamaño que el usuario introduzca por teclado 
             * (si introduce 5, hacer un array de 5 x 5). Poner los valores OX alternados en cada fila. 
             * Al pasar de una fila y otra, el O o X inicial debería alternar. Mostrarlo en pantalla. 
             * Por ejemplo, si introduce un 4, mostrar en pantalla:
                OXOX
                XOXO
                OXOX
                XOXO
             */
            Console.WriteLine("Escribe un numero");
            int num = Convert.ToInt32(Console.ReadLine());
            char[,] numbers = new char[num, num];
            char x = 'X';
            char o = 'O';
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    if (j%2 == 0)
                    {
                        numbers[i, j] = o;
                    }
                    else
                    {
                        numbers[i, j] = x;
                    }
                }
                if (x == 'X')
                {
                    x = 'O';
                    o = 'X';
                }
                else
                {
                    x = 'X';
                    o = 'O';
                }

            }
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    Console.Write($"{numbers[i, j]}");
                }
                Console.WriteLine("");
            }
        }
    }
}
