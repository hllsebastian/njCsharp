using DemoStore.Enumeations;

namespace DemoStore.Clases
{
    public class Store
    {
        
        public string nameStore;
        public Producto[] AllProducst;  

        public Store()   //         Generando constructor
        {
            nameStore = "Ant Store";
            AllProducst = GettingProducts();
        }
        

        private Producto[] GettingProducts()
        {
            // Creando un array y asignandole una cantidad de posiciones
            Producto [] listproducts = new Producto[3];

            Producto product1 = new Producto();
            product1.Name = "Arroz";
            product1.Description = "Alta calidad";
            product1.measuring = Measurement.Kilo;

            Producto product2 = new Producto();
            product2.Name = "Aceite de Oliva";
            product2.Description = "Alta calidad";
            var price2 = product2.GivePrice(40);
            product2.measuring = Measurement.Litro;
            var showp2 = product2.showPrice();

            var product3 = new Producto();
            product3.Name = "Leche ";

            // Ingresando los valores al array definiendo una posicion
            listproducts[0] = product1;
            listproducts[1] = product2;
            listproducts[2] = product3;

            return listproducts;
        } 

        

    }



}