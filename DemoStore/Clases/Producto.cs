using DemoStore.Enumeations;



namespace DemoStore.Clases
// Modificadores de acceso: 
// *Internal -> Solo permitira ser accedido desde el mismo proyecto
// *public -> Se puede acceder desde cualquier lugar

{
    public class Producto
    {
        // Se declara como "public" para poder accederla desde otra clase, por defecto toma un valor
        // privado
         public string Name { get; set; } //  "get; set;", sirve para extraer y asignar valores a la propiedad 
         public string Description;
         // Se puede establecer una propiedad privada y acceder a esta cuando se genera una instancia,
         // por medio de un metodo  
         private double Price;  
         public  Measurement measuring;     

         
         public double GivePrice(double newPrice) // Definiendo un metodo
         {
             Price = newPrice;
             return Price;
         }

         public double showPrice()
         {
             return Price;
         }
    }
}