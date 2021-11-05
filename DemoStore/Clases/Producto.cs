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
         public string Name;  
         public string Description;  
         public double Price;  
         public  Measurement measuring;     

         
         public void GivePrice(double newPrice) // DEfiniendo un metodo
         {
             Price = newPrice;
         }
         
    }
}