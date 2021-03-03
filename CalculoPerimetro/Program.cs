using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoPerimetro
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Declaracion de variables 
            int a = 10;
            int b = 10;
            int c = 7;
            int p = a + b + c;

            //2.Impresion en consola
            Console.WriteLine("El perimetro del triangulo es: " + p);
            Console.WriteLine("Presione cualquier tecla para salir");
            Console.ReadKey();
        }
    }
}
