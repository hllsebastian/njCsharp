using System; // Permite usar el codigo de C#
using System.Collections.Generic;
using CoreDemo.Enumeration;

namespace CoreDemo // Aca se encierra el paquete de codigo, es el nombre de la carpeta
{
    class Program
    {
        static void Main(string[] args)
        {            
            string saludo;  // Declaracion de varibale
            saludo = "oelo"; // asignacion de valor a la variable
            Console.WriteLine(saludo); // ejecutando instruccion con el valor de la variable

            const int entero  = 2233;
            var dateNow = DateTime.Now;
            short año = 2021;
            var numberDecimal = double.Parse("3,1416"); // "Parse" convierte a double en este caso
            Console.WriteLine(numberDecimal);


            // Vectores

            int[] vectorEnteros = new int[6]; // Declarando vector sin valores; "new int[6]"indica sus posiciones
            vectorEnteros[0] = 1; // Ingresando valor
            vectorEnteros[1] = new Random().Next(10); // "Random().Next()" Asigna un valor aleatorio
            vectorEnteros[5] = new Random().Next(100); 



            // Usando estructuras condicionales (if, for, while)

            while (1>0){      

                Menu menu = Menu.ninguno;
                Console.WriteLine("1 = año; 2 = numero; 3 = fecha actual; 4 = FOR; 5 WHILE; 6 = Vector; 7 = Diccionario");
                var inputN = Console.ReadLine();
                // "TryParse" cambia el numero a "int" el "out" para indicar en que variable guardar
                //int.TryParse(inputN, out numSelect); 
               
               try
               {
                menu = Enum.Parse<Menu>(inputN);   
               }
               catch (Exception ex)
               {
                   
                   throw new Exception("Ingrese un valor valido. " + ex);
               }

                if ( menu == Menu.año){
                    Console.WriteLine("El años es " + año);
                } 
                else if (menu == Menu.enterO )
                {
                    Console.WriteLine("El numero es " + entero);
                }
                else if (menu == Menu.dateNow)
                {
                    Console.WriteLine("La fecha actual es " + dateNow);
                }
                else if(menu == Menu.contadorFor)
                {
                    Console.WriteLine("Ingrese el numero limite");      // Usando el for
                    var limit = Console.ReadLine();
                    var intLimit = 0;
                    int.TryParse(limit, out intLimit);

                    for (int i = 1; i<=intLimit; i++ )              
                    {
                        Console.WriteLine(i);
                    }                
                } 
                else if(menu == Menu.contadorWhile)             // usando el while
                {
                    int count = 0;
                    int cicle = 7;
                    while(count <= cicle){
                        Console.WriteLine(count++);
                    }           
                }
                else if(menu == Menu.vectorEnteros)             // usando el while
                {
                    for (var i = 0; i<vectorEnteros.Length; i++){
                        Console.WriteLine(vectorEnteros[i]);
                    }     
                }else if(menu == Menu.Diccionario)             // usando el while
                {

                    Dictionary<int, int> diccionario = new Dictionary<int, int>();
                    int keyvalue = 1;

                    Console.WriteLine("Ingrese un numero para agregar al diccionario o finalize con .");
                    string numeroIngresado = "";
                    
                    while (!numeroIngresado.Equals("."))
                    {
                         numeroIngresado = Console.ReadLine();
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
                        Console.WriteLine("Clave:" + item.Key + " Valor:" + item.Value);
                    }
                } 
                {
                Console.WriteLine("Ingrese un valor valido");
                }
            }

            
        } 


    }


  

}
