using System;
using System.Collections.Generic;

namespace Ejercicio18
{
    class Program
    {
        static void Main(string[] args)
        {
            /*2. Lee por consola los números que introduzca el usuario. 
                - Si el número introducido es decimal lo guardará en una lista de números decimales,.
                - Si no es decimal entonces los guardará en una lista de ints. 
             */
            double decimalNum;
            int intNum;
            List<int> allIntNums = new List<int>();
            List<double> allDoubleNums = new List<double>();
            while (true)
            {
                Console.WriteLine("Introduce un numero decimal o entero");
                string textNumber = Console.ReadLine();

                Console.WriteLine("-----------------------------------------");
                if (double.TryParse(textNumber,out decimalNum)==true)
                {
                    if (textNumber.Contains("."))
                    {
                        decimalNum = Convert.ToDouble(textNumber);
                        allDoubleNums.Add(decimalNum);
                    }
                    else
                    {
                        intNum = Convert.ToInt32(textNumber);
                        allIntNums.Add(intNum);
                    }
                }
                else
                {
                    Console.WriteLine("El valor introducido no es valido, prueba otra vez");
                }
                Console.Write("Lista de enteros introducidos: ");
                if (allIntNums.Count > 0)
                {
                    for (int i = 0; i < allIntNums.Count; i++)
                    {
                        Console.Write($"{allIntNums[i]}, ");
                    }
                }
                
                Console.WriteLine("\n");
                Console.WriteLine("-----------------------------------------");
                Console.Write("Lista de decimales introducidos: ");
                if (allDoubleNums.Count > 0)
                {
                    for (int i = 0; i < allDoubleNums.Count; i++)
                    {
                        Console.Write($"{allDoubleNums[i]}, ");
                    }
                }
                Console.WriteLine("\n");
                Console.WriteLine("-----------------------------------------");

            }

        }
    }
}
