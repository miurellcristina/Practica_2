using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_StringInt
{
    class Program
    {
        static void Main(string[] args)
        {
            String nombre;
            int edad;
            // Pedir nombre
            Console.WriteLine("Por favor, ingresa tu nombre");
            nombre = Console.ReadLine();

            // Pedir Edad
            Console.WriteLine("Por favor, ingresa tu edad");
            edad = int.Parse(Console.ReadLine());

            // Imprimir en consola
            Console.WriteLine("Tu nombre es " + nombre + " y tienes " + edad + " años");
            Console.WriteLine("Preciona cualquier tecla para salir");
            Console.ReadKey();

        }
    }
}
