using System;

namespace Ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Cargar dos tablas, una con los nombres y otra con las calificaciones de los N alumnos
              de una clase de Programación. 
             
                - X Rellenar arrays con el nombre del alumno y su nota validando entre 0 y 10. 
                - X Calcular la media de la clase
                - X Escribir los alumnos cuya nota es mayor que la media.
                - Calcular la nota máxima y quienes la han conseguido
                - Calcular la nota mínima y quienes la han conseguido
                - Mostrar la lista de alumnos junto con su nota correspondiente: 
                    - Nombre1 Apellido11 Apellido12  - Nota 
                    - Nombre2 Apellido21 Apellido22  - Nota

             */
            string[] names = {"Nagore Reina De La Maza", "Bruno Moya Velasco", "Eduardo Marquez Sanchez", "Omar Gallego Calvo", "Francisco Gimenez Moreno", "Álvaro Martin Carrasco", "Laia Martinez Vazquez", "Noa Pujol Esteban", "Saray Fuentes Arias", "Raquel Gutierrez Nieto" };
            double[] notes = new double[10];
            Random randomNum = new Random();
            double media = 0;
            //Generar los notas aleatorias
            for (int i = 0; i < notes.Length; i++)
            {
                notes[i] = Convert.ToDouble(randomNum.Next(0, 11));
                media += notes[i];
            }
            media /= 10;
            Console.WriteLine("---------------------------");
            Console.WriteLine($"La Nota media es: {media}");
            Console.WriteLine("---------------------------");

            Console.WriteLine("Los alumnos con la nota más alta que la media son: ");
            for (int i = 0; i < notes.Length; i++)
            {
                if (notes[i] > media)
                {
                    Console.Write($"{names[i]}, ");
                }
            }
            double maxNote = 0;
            Console.WriteLine("\n");
            Console.WriteLine("---------------------------");
            Console.WriteLine("La/las persona/s con la nota más alta es/son: ");
            for (int i = 0; i < notes.Length; i++)
            {
                if (notes[i] >= maxNote)
                {
                    maxNote = notes[i];
                }
            }
            for (int i = 0; i < names.Length; i++)
            {
                if (notes[i] == maxNote)
                {
                    Console.Write($"{names[i]}, ");
                }
                
            }
            double minNote = 10;
            Console.WriteLine("\n");
            Console.WriteLine("---------------------------");
            Console.WriteLine("La/las persona/s con la nota más baja es/son: ");
            for (int i = 0; i < notes.Length; i++)
            {
                if (notes[i] <= minNote)
                {
                    minNote = notes[i];
                }
            }
            for (int i = 0; i < names.Length; i++)
            {
                if (notes[i] == minNote)
                {
                    Console.Write($"{names[i]}, ");
                }

            }
            Console.WriteLine("\n");
            Console.WriteLine("---------------------------");
            for (int i = 0; i < notes.Length; i++)
            {
                Console.WriteLine($"{names[i]} - {notes[i]}");
            }
            Console.WriteLine("---------------------------");
        }
    }
}
