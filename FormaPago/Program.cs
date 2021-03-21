using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormaPago
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pedir el precio del producto 
            Console.WriteLine("Ingrese el precio del producto");
            double precio = Convert.ToDouble(Console.ReadLine());

            //Pedir que forma de pago (tarjeta o efectivo)
            Console.WriteLine("Escriba la forma de pago: tarjeta o efectivo");
            String formaPago = (Console.ReadLine()).ToLower();
            //Si es Tarjeta debera pedir el numero de tarjeta
            if (formaPago.Equals("tarjeta"))
            {
                Console.WriteLine("Introduce el numero de tarjeta");
                int numero_tarjeta = Convert.ToInt32(Console.ReadLine());
                //Imprimir un mensaje  de confirmacion
                       Console.WriteLine("El producto con precio $ " + precio + " se ha pagado con el numero de tarjeta <" + numero_tarjeta +">");
            }

            else if (formaPago.Equals("efectivo"))
            {
                //Si el pago es en efectivo imprimira El producto con precio <precio> se ha pagado”
                Console.WriteLine("El producto con precio $" + precio + " se ha pagado");
            }
            else
            {
                // Si elige diferente imprimir "No es un metodo correcto de pago"
                Console.WriteLine("No es un metodo de pago correcto");
            }
            Console.WriteLine("Presiona cualquier tecla para continuar");
            Console.ReadKey();
        }
    }
}
