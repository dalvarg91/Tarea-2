using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidad = 0;
            float precio = 0;
            float desc1 = 15f;
            float desc2 = 20f;
            Console.WriteLine("Digite la cantidad de camisetas a comprar: ");
            cantidad = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite el precio unitario de la camiseta: ");
            precio = int.Parse(Console.ReadLine());
            if (cantidad >= 2 && cantidad <= 5)
            {
                float subtotal = (cantidad * precio);
                float preciodesc = (subtotal * desc1 / 100);
                float total = (subtotal - preciodesc);
                Console.WriteLine($"Subtotal:{subtotal}\nDescuento aplicado:{preciodesc} \nEl total a pagar es: {total}");
            }
            else if (cantidad > 5)
            {
                float subtotal = (cantidad * precio);
                float preciodesc = (subtotal * desc2 / 100);
                float total = (subtotal - preciodesc);
                Console.WriteLine($"Subtotal:{subtotal}\nDescuento aplicado:{preciodesc} \nEl total a pagar es: {total}");
            }
            else
            {
                float total = (cantidad * precio);
                Console.WriteLine($"El total a pagar es: {total}");
            }
            Console.Read();
        }
    }
}
