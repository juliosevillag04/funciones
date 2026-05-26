using System;
//7. Utilizar Math.Pow para calcular potencias. Usando funciones.
Console.Clear();

//Función
double potencia(double base_num, double exponente)
{
    return Math.Pow(base_num, exponente);
}

//Validación
double validar(string mensaje)
{
    double numero;
    while (true)
    {
        Console.Write(mensaje);
        if (double.TryParse(Console.ReadLine(), out numero))
        {
            return numero;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error: ingrese solo números válidos.");
            Console.ResetColor();
        }
    }
}

//Ingreso de datos
double base_num = validar("Número base: ");
double exponente = validar("Exponente: ");

//Cálculos
double resultado = potencia(base_num, exponente);

//Mostrar resultado
Console.WriteLine($"{base_num}^{exponente} = {resultado}");