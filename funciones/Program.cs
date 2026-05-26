using System;
//Recopilación de clase práctica en menú
Console.Clear();
int opcion;

do
{
    Console.WriteLine("===================== MENÚ DE EJERCICIOS =====================");
    Console.WriteLine("6. Validar edades utilizando funciones");
    Console.WriteLine("7. Utilizar Math.Pow para calcular potencias");
    Console.WriteLine("8. Convertir cadenas a mayúsculas y minúsculas");
    Console.WriteLine("9. Crear un sistema modular para calcular promedio estudiantil");
    Console.WriteLine("10. Validar entradas numéricas usando TryParse");
    Console.WriteLine("11. Salir");
    Console.Write("Seleccione una opción: ");

    if (int.TryParse(Console.ReadLine(), out opcion))
    {
        Console.Clear();

        switch (opcion)
        {
            case 6:
                Console.Clear();
                bool mayoredad(int edad)
                {
                    return edad >= 18;
                }

                void mostrar_edad(int edad)
                {
                    if (mayoredad(edad))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Eres mayor de edad");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Eres menor de edad");
                        Console.ResetColor();
                    }
                }

                int edad;

                Console.Write("Ingresa tu edad: ");
                edad = int.Parse(Console.ReadLine()!);

                mostrar_edad(edad);
                break;

            case 7:
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
                break;

            case 8:
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
                break;

            case 9:
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
                break;

            case 10:
                Console.Clear();

                Console.ForegroundColor=ConsoleColor.DarkGray;
                Console.WriteLine("Nota. Ejercicio 6 con validación de entrada numérica usando TryParse");
                Console.ResetColor();
                
                //Función de edad
                bool mayor_edad(int edad_2)
                {
                    return edad_2 >= 18;
                }

                //Función para mostrar el resultado en pantalla
                void mostraredad(int edad_2)
                {
                    if (mayor_edad(edad_2))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Eres mayor de edad");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Eres menor de edad");
                        Console.ResetColor();
                    }
                }

                int edad_2;

                //Validación e ingreso de datos
                while (true)
                {
                    Console.Write("Ingresa tu edad: ");
                    if (int.TryParse(Console.ReadLine()!, out edad_2) && edad_2 >= 0)
                    {
                        mostraredad(edad_2);
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Ingresa una edad válida");
                        Console.ResetColor();
                        Console.Write("Pulsa una tecla");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                break;

            case 11:
                Console.WriteLine("Saliendo del programa...");
                break;

            default:
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Opción inválida");
                Console.ResetColor();
                break;
        }
    }
    else
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Ingrese solo números");
        Console.ResetColor();
    }

    if (opcion != 11)
    {
        Console.WriteLine();
        Console.WriteLine("Presione cualquier tecla para volver al menú...");
        Console.ReadKey();
        Console.Clear();
    }

} while (opcion != 11);