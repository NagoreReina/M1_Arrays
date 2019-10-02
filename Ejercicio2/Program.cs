using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear un array de 3 strings. Pedir al usuario 3 veces que escriba un string. 
            //Guardar cada uno de esos strings en la posición 0 , 1 y 2. 
            //Mostrar en pantalla en el orden: primero posición 1, después posición 2 y por último posición 0.
            string[] uData = new string[3];

            for (int i = 0; i < uData.Length; i++)
            {
                Console.WriteLine($"Introduce la frase {i}");
                uData[i] = Console.ReadLine();
                Console.WriteLine("------------------------");
            }
            Console.WriteLine(uData[1]);
            Console.WriteLine(uData[2]);
            Console.WriteLine(uData[0]);
        }
    }
}
