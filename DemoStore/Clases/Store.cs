using DemoStore.Enumeations;

namespace DemoStore.Clases
{
    public class Store
    {
        
        // Se le puede asignar una valor por defecto a la propiedad y asi se omite definirla dentro
        // del constructor
        public string nameStore { get; set; } = "Ant Store";
        public Producto[] AllProducst { get; set; }  
        public ImportProduct[] AllImportProducts { get; set; }  

        public Store()   //         Generando constructor
        {
            AllProducst        = GettingProducts();
            AllImportProducts = GettingImportProducts();
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

        private ImportProduct[] GettingImportProducts()
        {
            ImportProduct [] importProductsList = new ImportProduct[2];

            ImportProduct importProduct1 = new ImportProduct();
            importProduct1.Name = "Uvas";
            importProduct1.measuring = Measurement.Kilo;
            importProduct1.Price = 34.1456;
            importProduct1.Description= "Delicious";
            importProduct1.importationCountry = "Argentina";

            ImportProduct importProduct2 = new ImportProduct();
            importProduct2.Name = "tomatos";
            importProduct2.measuring = Measurement.Kilo;
            importProduct2.Price = 5.1456;
            importProduct2.Description= "Fresh";
            importProduct2.importationCountry = "Peru"; 

            importProductsList[0] = importProduct1;
            importProductsList[1] = importProduct2;

            return importProductsList;
        }
        

    }



}