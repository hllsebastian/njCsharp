using System;
using DemoStore.Clases;
using DemoStore.Enumeations;

namespace DemoStore
{
    class Program
    {
        static void Main(string[] args)
        {

            // Creando la instancia de un objeto  
            Producto product = new Producto();
            product.Name = "Arroz";
            product.Description = "Alta calidad";
            product.GivePrice(23.4);
            product.measuring = Measurement.Kilo;

            // otra forma de crear la instancia de objtetos
            var product2 = new Producto();
            product2.Name = "Aceite";

            Console.WriteLine($"{product.Name}; {product.Price}");
        }
    }
}
