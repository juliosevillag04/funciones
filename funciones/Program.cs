using System;
//10. Validar entradas numéricas usando TryParse. Usando funciones
//Nota. Ejercicio 6 con validación de entrada numérica usando TryParse.
Console.Clear();

//Función de edad
bool mayoredad(int edad)
{
    return edad >= 18;
}

//Función para mostrar el resultado en pantalla
void mostrar_resultado(int edad)
{
    if (mayoredad(edad))
    {
        Console.ForegroundColor=ConsoleColor.Green;
        Console.WriteLine("Eres mayor de edad");
        Console.ResetColor();
    }
    else
    {
        Console.ForegroundColor=ConsoleColor.Red;
        Console.WriteLine("Eres menor de edad");
        Console.ResetColor();
    }
}

int edad;

//Validación e ingreso de datos
while (true)
{
    Console.Write("Ingresa tu edad: ");
    if (int.TryParse(Console.ReadLine()!, out edad) && edad >=0)
    {
        mostrar_resultado(edad);
        break;
    }
    else
    {
        Console.Clear();
        Console.ForegroundColor=ConsoleColor.Red;
        Console.WriteLine("Ingresa una edad válida");
        Console.ResetColor();
        Console.Write("Pulsa una tecla");
        Console.ReadKey();
        Console.Clear();
    }
}