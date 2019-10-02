using System;
using System.Collections.Generic;

namespace Ejercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crea una lista de personajes de la saga Star Wars e introduce tres personajes.
                - Muestra la lista.
                - Ordena la lista alfabeticamente.
                - Pide al usuario que introduzca un personaje por teclado. Si existe borralo de la lista sino, añadelo.
                - Cuenta cuantos personajes contiene la lista.
             */
            List<string> characterNames = new List<string>();
            characterNames.Add("Luke Skywalker");
            characterNames.Add("Leia Organa");
            characterNames.Add("Darth Vader");

            Console.WriteLine($"Esta es la lista actual:\n- {characterNames[0]}\n- {characterNames[1]}\n- {characterNames[2]}");
            Console.WriteLine("---------------------------------------------");
            characterNames.Sort();
            Console.WriteLine($"Ordenados alfabeticamente:\n- {characterNames[0]}\n- {characterNames[1]}\n- {characterNames[2]}");
            Console.WriteLine("---------------------------------------------");
            while (true)
            {
                Console.WriteLine("Introduce un personaje");
                string text = Console.ReadLine();
                bool isInList = false;
                Console.WriteLine("---------------------------------------------");
                for (int i = 0; i < characterNames.Count; i++)
                {
                    if (characterNames[i] == text)
                    {
                        characterNames.RemoveAt(i);
                        isInList = true;
                    }
                }
                if (!isInList)
                {
                    characterNames.Add(text);
                }
                Console.WriteLine($"Esta es la lista actual:");
                for (int i = 0; i < characterNames.Count; i++)
                {
                    Console.WriteLine($"- {characterNames[i]}");
                }
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine($"Ordenados alfabeticamente:");
                characterNames.Sort();
                for (int i = 0; i < characterNames.Count; i++)
                {
                    Console.WriteLine($"- {characterNames[i]}");
                }
                Console.WriteLine("---------------------------------------------");
            }
            
        }
    }
}
