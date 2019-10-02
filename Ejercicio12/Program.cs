using System;

namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ordenar un array de 5 strings alfabéticamente:
            // - Utilizar función.
            // - Sin función. (Muy dificil)

            //Utilizando función
            int num = 0;
            string[] sentences = new string [5];
            do
            {
                Console.WriteLine($"Introduce una frase {num + 1}/5");
                sentences[num] = Console.ReadLine();
                num++;

            } while (num < 5);

            Array.Sort(sentences);
            Console.WriteLine($"{sentences[0]} \n{sentences[1]} \n{sentences[2]} \n{sentences[3]} \n{sentences[4]}");
        }
    }
}
