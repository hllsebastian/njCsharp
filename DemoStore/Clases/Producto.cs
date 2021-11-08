using System;
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

        // "get; set;", sirve para extraer y asignar valores a la propiedad 
         public string Name { get; set; } 

         // La forma mas completa de realizar el encapsulamiento
         private string _Description;
         public string Description 
        {
            set
            {
                _Description = value; // "Set"  asigna valor a la propiedad
            }
            get 
            {
                return _Description; // "Get" obtiene el valor
            }
        }        

         public  Measurement measuring  { get; set; }

         private double _Price;

         // Se pueden definir reglas cuando se recibe un valor
         public double Price 
         {
             set
             {
                 _Price = value;
             }
             get
             {
                 // De esta manera cuando se ingrese un valor con muchos decimales, el sistema guardar los 
                 // definidos, en este caso 2
                 return Price = Math.Round(_Price, 2);;
             }
         }


         
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