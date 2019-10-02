using System;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Poner los nombres de los meses en un array de 12. Cuando el usuario introduce un número del 1 al 12, 
            //mostrar el nombre de ese mes en pantalla.

            string[] months = { "enero","febrero","marzo","abril","mayo","junio","julio","agosto","septiembre","octubre","noviembre","diciembre" };
            Console.WriteLine("Introduce un numero");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(months[num-1]);
        }
    }
}
