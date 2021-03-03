using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_int
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.- Declaracion de variables tipo Int
            int numero_1 = 3;
            int numero_2 = 6;
            int numero_3 = 9;

            //2.- Crear una variable de tipo Int que guardara la suma de los tres numeros
            int suma = numero_1 + numero_2 + numero_3;

            //3.- Mostrar en pantalla el valor de la suma
            Console.WriteLine("El valor de la suma es: " + suma);
            Console.WriteLine("Precione cualquier tecla");
            Console.ReadKey();
        }
    }
}
