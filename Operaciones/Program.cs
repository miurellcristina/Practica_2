using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            string guardar_numero_1;
            string guardar_numero_2;
            int numero_2;
            int numero_1;

            Console.WriteLine("Escribe el primer numero");
            guardar_numero_1 = Console.ReadLine();
            numero_1 = Convert.ToInt32(guardar_numero_1);
            Console.WriteLine("Escribe el segundo numero");
            guardar_numero_2 = Console.ReadLine();
            numero_2 = Convert.ToInt32(guardar_numero_2);

            Console.WriteLine("Operaciones");

            Console.WriteLine("La suma es: " + (numero_1 + numero_2));
            Console.WriteLine("La resta es: " + (numero_1 - numero_2));
            Console.WriteLine("La multiplicacion es: " + (numero_1 * numero_2));
            Console.WriteLine("La division es: " + (numero_1 / numero_2));
            Console.WriteLine("Preciona cualquier tecla para salir");
            Console.ReadKey();
        }
    }
}
