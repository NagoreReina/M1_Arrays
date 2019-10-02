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
                El programa seguirá pidiendo al usuario que introduzca números hasta que introduzca un número negativo. Una vez haya introducido un número negativo: 
                - Muestra cuántos números decimales y cuantos enteros ha creado. 
                - Haz la suma de todos los números enteros introducidos.
                - Saca la media de todos los números, tanto enteros como decimales JUNTOS.
            Controla las posibles excepciones que se puedan dar, como por ejemplo introducir una letra en una variable double.

             */
            double decimalNum = 0;
            int intNum;
            List<int> allIntNums = new List<int>();
            List<double> allDoubleNums = new List<double>();
            while (decimalNum >= 0)
            {
                Console.WriteLine("Introduce un numero decimal o entero");
                string textNumber = Console.ReadLine();

                Console.WriteLine("-----------------------------------------");
                if (double.TryParse(textNumber,out decimalNum)==true) //comprueba que es un numero lo que se ha introducido
                {
                    if (decimalNum >= 0) //comprueba que es negativo o no
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
                    else //cuando se introudce un numero negativo, se muestran las listas
                    {
                        Console.Write("Lista de enteros introducidos: ");
                        int sum = 0;
                        if (allIntNums.Count > 0)
                        {
                            for (int i = 0; i < allIntNums.Count; i++)
                            {
                                Console.Write($"{allIntNums[i]}, ");
                                sum += allIntNums[i];
                            }
                        }

                        Console.WriteLine("\n");
                        Console.WriteLine("-----------------------------------------");
                        Console.Write("Lista de decimales introducidos: ");
                        double sumDecimal = 0;
                        if (allDoubleNums.Count > 0)
                        {
                            for (int i = 0; i < allDoubleNums.Count; i++)
                            {
                                Console.Write($"{allDoubleNums[i]}, ");
                                sumDecimal += allDoubleNums[i];
                            }
                        }
                        Console.WriteLine("\n");
                        Console.WriteLine("-----------------------------------------");
                        Console.WriteLine($"La suma de todos los enteros es igual a: {sum}");
                        Console.WriteLine("-----------------------------------------");
                        Console.WriteLine($"La media de todos los numeros introducidios es: {(sum + sumDecimal)/(allDoubleNums.Count+allIntNums.Count)}");

                    }
                }
                else
                {
                    Console.WriteLine("El valor introducido no es valido, prueba otra vez");
                }

            }

        }
    }
}
