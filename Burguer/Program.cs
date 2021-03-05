using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burguer
{
    class Program
    {
        static void Main(string[] args)
        {
            string cantidad;
            int producto1, producto2, producto3, resultado;
            double total;
            const double precioproducto1=45, precioproducto2=15, precioproducto3=20;

            //Estructura de menu
            Console.WriteLine("------------Menu-----------");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Codigo    Producto    Precio");
            Console.WriteLine("  1     Hamburguesa     {0}", precioproducto1);
            Console.WriteLine("  2        Bebida       {0}", precioproducto2);
            Console.WriteLine("  1         Papas       {0}", precioproducto3);
            Console.WriteLine("---------------------------");
            
            //Pedidos
            Console.WriteLine("Cuantas hamburguesas desea?");
            cantidad = Console.ReadLine();
            producto1 = Convert.ToInt32(cantidad);

            Console.WriteLine("Cuantas Bebidas desea?");
            cantidad = Console.ReadLine();
            producto2 = Convert.ToInt32(cantidad);

            Console.WriteLine("Cuantas Papas desea?");
            cantidad = Console.ReadLine();
            producto3 = Convert.ToInt32(cantidad);


            Console.WriteLine("------------Ticket------------");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Cantidad    Producto     Total");
            resultado = producto1 * 45;

            Console.WriteLine("  {0}       Hamburguesa     {1}", producto1, resultado);
            resultado = producto2 * 15;

            Console.WriteLine("  {0}          Bebida       {1}", producto2, resultado);

            resultado = producto3 * 20;
            Console.WriteLine("  {0}           Papas       {1}", producto3, resultado);
            total = (producto1 * precioproducto1) + (producto2 * precioproducto2) + (producto3 * precioproducto3);

            Console.WriteLine("              TOTAL       " + total);
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Preciona cualquier tecla para salir");
            Console.ReadKey();

        }
    }
}
