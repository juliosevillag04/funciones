using System;
//8. Convertir cadenas a mayúsculas y minúsculas. Usando funciones
Console.Clear();
//Función
string cadena(string mayusculas, string minusculas)
{
    return "Texto en mayúsculas: " + mayusculas.ToUpper() + "\n" + "Texto en minuscúlas: " + minusculas.ToLower();
}
//Ingreso de datos
Console.Write("Ingresa una cadena de texto: ");
string texto = Console.ReadLine()!;
//Mostrar resultado
Console.WriteLine(cadena(texto, texto));