using System;
//6. Validar edades utilizando funciones.
//Validar si es mayor o menor de edad
Console.Clear();
bool mayoredad(int edad)
{
    return edad >= 18;
}

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

Console.Write("Ingresa tu edad: ");
edad = int.Parse(Console.ReadLine()!);

mostrar_resultado(edad);
