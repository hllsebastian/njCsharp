using System; // Permite usar el codigo de C#
using System.Collections.Generic;
using CoreDemo.Enumeration;
using static System.Console; // usando el "using static"

namespace CoreDemo // Aca se encierra el paquete de codigo, es el nombre de la carpeta
{
    class Program
    {
        static void Main(string[] args)
        {            
          
            const int entero  = 2233;
            DateTime? dateNow = null;         // Permite definir variables como nulas con "?"
            var año           = dateNow?.Year;
            var numberDecimal = double.Parse("3,1416"); // "Parse" convierte a double en este caso
            (bool result, int valor) tupla = (false, 0); // Tupla, para definir y retornar dos valores
            (int valorA, string valorB) tuplaA = (1, "Gato");

 
            int[] vectorEnteros = new int[6]; // Declarando vector sin valores; "new int[6]"indica sus posiciones
            vectorEnteros[0] = 1; // Ingresando valor
            vectorEnteros[1] = new Random().Next(10); // "Random().Next()" Asigna un valor aleatorio
            vectorEnteros[5] = new Random().Next(100); 
            // Se puede usar "_" entre los decimales de un numero para hacerlo mas legible, cuando se
            // imprima en consola los guiones no apareceran 
            double guionBajo = 3.1359_435438_53048_573085734;



            // Usando estructuras condicionales (if, for, while)

            while (1>0){      

                Menu menu = Menu.ninguno;
                WriteLine("1 = año; 2 = numero; 3 = fecha actual; 4 = FOR; 5 WHILE; 6 = Vector; 7 = Diccionario");
                var inputN = ReadLine();
                //int.TryParse(inputN, out numSelect); 
               
               try
               {
                menu = Enum.Parse<Menu>(inputN);   
               }
                   // Se uso "when" para condicionar la busqueda de una palabra que este contenido dentro
                   // de la excepcion
               catch (Exception ex) when (ex.Message.ToLower().Contains("format"))  
               {
                   // Interpolacion en cadena de texto anteponiendo "$" y poniendo el dato diferente al 
                   // texto entre llaves
                   throw new Exception( $"El formato no es valido. {ex.Message}");
               }

                if ( menu == Menu.año){
                    WriteLine($"El años es: {año}");
                } 
                else if (menu == Menu.enterO )
                {
                    WriteLine($"El numero es {entero}");
                }
                else if (menu == Menu.dateNow)
                {
                    WriteLine($"La fecha actual es: {dateNow} ");
                }
                else if(menu == Menu.contadorFor)
                {
                    WriteLine("Ingrese el numero limite");      // Usando el for
                    var limit = ReadLine();
                    // var intLimit = 0;
                    // Dentro del parametro se puede establecer el tipado de la variable
                    int.TryParse(limit, out int intLimit);

                    for (int i = 1; i<=intLimit; i++ )              
                    {
                        WriteLine(i);
                    }                
                } 
                else if(menu == Menu.contadorWhile)             // usando el while
                {
                    int count = 0;
                    int cicle = 7;
                    while(count <= cicle){
                        WriteLine(count++);
                    }           
                }
                else if(menu == Menu.vectorEnteros)             // usando el while
                {
                    for (var i = 0; i<vectorEnteros.Length; i++){
                        WriteLine(vectorEnteros[i]);
                    }     
                }else if(menu == Menu.Diccionario)             // usando el diccionario
                {

                    Dictionary<int, int> diccionario = new Dictionary<int, int>();
                    int keyvalue = 1;

                    WriteLine("Ingrese un numero para agregar al diccionario o finalize con .");
                    string numeroIngresado = "";
                    
                    while (!numeroIngresado.Equals("."))
                    {
                         numeroIngresado = ReadLine();
                         try
                         {
                             int transNum = int.Parse(numeroIngresado);
                             diccionario.Add(keyvalue, transNum);
                             keyvalue++;
                         }
                         catch 
                         {
                             
                         }                         
                    }
                    foreach(var item in diccionario)
                    {
                        WriteLine($"Clave: {item.Key}  Valor: {item.Value}");
                    }
                } 
            }     
        } 
    }
}
