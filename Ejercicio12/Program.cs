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

            int num = 0;
            string[] sentences = new string [5];
            do
            {
                Console.WriteLine($"Introduce una frase {num + 1}/5");
                sentences[num] = Console.ReadLine();
                num++;

            } while (num < 5);

            //Utilizando función------------------------------
            //Array.Sort(sentences);
            //Console.WriteLine($"{sentences[0]} \n{sentences[1]} \n{sentences[2]} \n{sentences[3]} \n{sentences[4]}");

            //Sin usar funcion----------------------------------
            for (int i = 0; i < sentences.Length; i++)
            {
                char c1 = Convert.ToChar(sentences[i].Substring(0, 1));
                int value1 = char.ToUpper(c1) - 64;
                for (int j = 0; j < sentences.Length; j++)
                {
                    char c2 = Convert.ToChar(sentences[j].Substring(0, 1));
                    int value2 = char.ToUpper(c2) - 64;
                    if(value1 < value2)
                    {
                        string tempText = sentences[i];
                        sentences[i] = sentences[j];
                        sentences[j] = tempText;
                        value1 = value2;
                    }

                }

            }
            Console.WriteLine($"{sentences[0]} \n{sentences[1]} \n{sentences[2]} \n{sentences[3]} \n{sentences[4]}");

        }
    }
}
