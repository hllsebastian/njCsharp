// Swithc as expression

// forma antigua de hacerlo

using System;

int intSwitch = 0;
string swithcResult = "";

switch (intSwitch)
{
    case 0:
        swithcResult = "cero";
        break;
    case 1:
        swithcResult = "uno";
        break; 
    case 2:
        swithcResult = "dos";
        break;    
    default:
        swithcResult = "Ingrese un numero valido";
        break;
}


swithcResult = (intSwitch) switch 
{
    (0) => "cero",
    (1) => "uno",
    (2) => "dos",
    (3) => "tres",
     _  => "Valor no valido"
};


// Property patterns

object myObject = null;

if (myObject is DateTime{Hour: 10, Day: 3})
{   

}


// static local function    

static void myfunction() 
{
    Console.WriteLine("Oelos");
}

// Using Declaration





