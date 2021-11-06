using System;
using DemoStore.Clases;
using DemoStore.Enumeations;

namespace DemoStore
{
    class Program
    {
        static void Main(string[] args)
        {

            /* // Creando la instancia de un objeto  
            Producto product1 = new Producto();
            product1.Name = "Arroz";
            product1.Description = "Alta calidad";
            //product1.Price = 22.3;
            product1.measuring = Measurement.Kilo;

            Producto product2 = new Producto();
            product2.Name = "Aceite de Oliva";
            product2.Description = "Alta calidad";
            var price2 = product2.GivePrice(40);
            product2.measuring = Measurement.Litro;


            // otra forma de crear la instancia de objtetos
            var product3 = new Producto();
            product3.Name = "Leche "; */

            // Console.WriteLine($"{product2.Name}; {price2}");

            Store myStore = new Store();
            void printingProducts(Producto[] products)
            {
                for (var i = 0; i < products.Length; i++)
                {
                    Console.WriteLine($"{products[i].Name}: {products[i].showPrice()}");
                }
            }
             
            Console.WriteLine($"Welcome to {myStore.nameStore}");
            Console.WriteLine("Available products");
            printingProducts(myStore.AllProducst);




            
        }
    }
}
