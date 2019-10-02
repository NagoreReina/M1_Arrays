using System;

namespace Ejerecicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Cargar una tabla de 20 componentes enteros y calcular la suma de los componentes de 
             * posición par y  el producto de los componentes de posición impar. Los valores se generarán 
             * aleatoriamente entre 1 y 100.
             */
            int[] num = new int[20];
            Random randomNum = new Random();
            double resultPar = 0;
            double resultImpar = 1;

            for (int i = 0; i < num.Length; i++)
            {
                num[i] = randomNum.Next(1, 101);
                if (i % 2 == 0)
                {
                    resultPar += num[i];
                }
                else
                {
                    resultImpar *= num[i];
                }
            }
            Console.WriteLine($"El resultado de sumar los pares es {resultPar} y el de multiplicar los impares {resultImpar}");
        }
    }
}
