using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfChar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pedir el caracter
            Console.WriteLine("Ingresar un caracter");
            char c = (char)Console.Read();
            if (Char.IsLetter(c))
            {
                if (Char.IsLower(c))
                {
                    Console.WriteLine("El caracter ingresado es una letra minuscula");
                }
                else
                {
                    Console.WriteLine("El caracter ingresado es una letra mayuscula");
                }
            }
            else
            {
                Console.WriteLine("El caracter ingresado es un numero");
            }

            Console.WriteLine("Preciona cualquier tecla para salir");
            Console.ReadKey();
        }
    }
}
