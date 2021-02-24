using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mostrar Hello World en la consola
            System.Console.WriteLine("Hello World :D");

            //Tomar los datos
            Console.ReadLine();

            //Variables
            var numero = 4;
            var saludo = "Hola";
            System.Console.WriteLine(numero);
            System.Console.WriteLine(saludo);
            System.Console.WriteLine(numero + 2);

            //Tipos de variables
            System.Int32 wholeNumber;
            System.Double pi = 3.1416;
            System.Boolean status = true;
            System.String cadena = "hello";
            System.Char letter = 'z';

            //Espera a que se oprima una tecla para salir
            Console.ReadKey();

        }
    }
}
