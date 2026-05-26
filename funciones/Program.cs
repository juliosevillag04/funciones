using System;
//9. Crear un sistema modular para calcular promedio estudiantil. Usando funciones.
Console.Clear();
// Ingreso de datos
int estudiantes = validar_estudiantes("Número de estudiantes: ");

// Variable para acumular las notas
double suma = 0;

// Ingreso de notas
for (int i = 1; i <= estudiantes; i++)
{
    double nota = validar_nota($"Nota del estudiante #{i}: ");
    suma += nota;
}

// Calcular promedio
double promedio = calcular_promedio(suma, estudiantes);

// Mostrar resultado
mostrar_resultado(promedio);


// Función para validar número de estudiantes entero
int validar_estudiantes(string mensaje)
{
    int numero;

    while (true)
    {
        Console.Write(mensaje);

        if (int.TryParse(Console.ReadLine(), out numero))
        {
            if (numero > 0)
            {
                return numero;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: el número de estudiantes debe ser mayor que 0.");
                Console.ResetColor();
            }
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error: ingrese solo números enteros válidos.");
            Console.ResetColor();
        }
    }
}


// Función para validar notas mayores o iguales que 0 y menores o iguales que 100
double validar_nota(string mensaje)
{
    double nota;

    while (true)
    {
        Console.Write(mensaje);

        if (double.TryParse(Console.ReadLine(), out nota))
        {
            if (nota >= 0 && nota <= 100)
            {
                return nota;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: la nota debe ser mayor que 0 y menor que 100.");
                Console.ResetColor();
            }
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error: ingrese una nota válida.");
            Console.ResetColor();
        }
    }
}


// Función para calcular promedio
double calcular_promedio(double suma, int estudiantes)
{
    return suma / estudiantes;
}


// Función para mostrar resultado
void mostrar_resultado(double promedio)
{
    Console.WriteLine($"El promedio estudiantil es: {Math.Round(promedio, 2)}");
}