using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaProductos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidad = 0;
            int total = 0;
            int precio1 = 20;
            int precio2 = 15;
            Console.WriteLine("Cuantas unidades desea comprar? ");
            cantidad = int.Parse(Console.ReadLine());
            if (cantidad <= 10)
            {
                total = (cantidad * precio1);
                Console.WriteLine($"Cantidad a llevar: {cantidad} \nPrecio unitario: ${precio1} \nTotal a pagar: ${total}");
            }
            else
            {
                total = (cantidad * precio2);
                Console.WriteLine($"Cantidad a llevar: {cantidad} \nPrecio unitario: ${precio2} \nTotal a pagar: ${total}");
            }
            Console.Read();
        }
    }
}
