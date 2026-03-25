using System;

namespace RegistroEstudiantes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicitar cantidad de estudiantes (máximo 10)
            int n;
            do
            {
                Console.Write("Ingrese la cantidad de estudiantes (1-10): ");
                if (!int.TryParse(Console.ReadLine(), out n) || n < 1 || n > 10)
                {
                    Console.WriteLine("Error: Debe ingresar un número entre 1 y 10.");
                    n = 0;
                }
            } while (n < 1 || n > 10);

            // Declaración de arreglos
            string[] nombres = new string[n];
            float[] notas = new float[n];

            // 1. Función para registrar datos
            RegistrarEstudiantes(nombres, notas, n);

            int opcion;
            do
            {
                Console.WriteLine("\n--- MENÚ DE OPCIONES ---");
                Console.WriteLine("1. Mostrar todos los estudiantes");
                Console.WriteLine("2. Calcular promedio del grupo");
                Console.WriteLine("3. Mostrar estudiante con mayor nota");
                Console.WriteLine("4. Mostrar estudiante con menor nota");
                Console.WriteLine("5. Contar estudiantes aprobados y reprobados");
                Console.WriteLine("6. Buscar estudiante por nombre");
                Console.WriteLine("7. Salir");
                Console.Write("Seleccione una opción: ");
                
                if (!int.TryParse(Console.ReadLine(), out opcion)) opcion = 0;

                switch (opcion)
                {
                    case 1: MostrarEstudiantes(nombres, notas, n); break;
                    case 2: Console.WriteLine($"Promedio general: {CalcularPromedio(notas, n):F2}"); break;
                    case 3: MostrarNotaMayor(nombres, notas, n); break;
                    case 4: MostrarNotaMenor(nombres, notas, n); break;
                    case 5: ContarAprobadosReprobados(notas, n); break;
                    case 6: BuscarEstudiante(nombres, notas, n); break;
                    case 7: Console.WriteLine("Saliendo del programa..."); break;
                    default: Console.WriteLine("Opción no válida."); break;
                }
            } while (opcion != 7);
        }

        // --- FUNCIONES OBLIGATORIAS Y COMPLEMENTARIAS ---

        static void RegistrarEstudiantes(string[] nombres, float[] notas, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"\nNombre del estudiante {i + 1}: ");
                nombres[i] = Console.ReadLine();

                float nota;
                do
                {
                    Console.Write($"Nota final de {nombres[i]} (0-10): ");
                    if (!float.TryParse(Console.ReadLine(), out nota) || nota < 0 || nota > 10)
                    {
                        Console.WriteLine("Error: La nota debe estar entre 0 y 10.");
                        nota = -1;
                    }
                } while (nota < 0 || nota > 10);
                notas[i] = nota;
            }
        }

        static void MostrarEstudiantes(string[] nombres, float[] notas, int n)
        {
            Console.WriteLine("\n--- Lista de Estudiantes ---");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{nombres[i]} - Nota: {notas[i]}");
            }
        }

        static float CalcularPromedio(float[] notas, int n)
        {
            float suma = 0;
            foreach (float nota in notas) suma += nota;
            return suma / n;
        }

        static void MostrarNotaMayor(string[] nombres, float[] notas, int n)
        {
            float mayor = notas[0];
            int indice = 0;
            for (int i = 1; i < n; i++)
            {
                if (notas[i] > mayor)
                {
                    mayor = notas[i];
                    indice = i;
                }
            }
            Console.WriteLine($"Estudiante con mayor nota: {nombres[indice]} ({mayor})");
        }

        static void MostrarNotaMenor(string[] nombres, float[] notas, int n)
        {
            float menor = notas[0];
            int indice = 0;
            for (int i = 1; i < n; i++)
            {
                if (notas[i] < menor)
                {
                    menor = notas[i];
                    indice = i;
                }
            }
            Console.WriteLine($"Estudiante con menor nota: {nombres[indice]} ({menor})");
        }

        static void ContarAprobadosReprobados(float[] notas, int n)
        {
            int aprobados = 0, reprobados = 0;
            foreach (float nota in notas)
            {
                if (nota >= 6) aprobados++;
                else reprobados++;
            }
            Console.WriteLine($"Estudiantes Aprobados (>=6): {aprobados}");
            Console.WriteLine($"Estudiantes Reprobados (<6): {reprobados}");
        }

        static void BuscarEstudiante(string[] nombres, float[] notas, int n)
        {
            Console.Write("Ingrese el nombre del estudiante a buscar: ");
            string buscar = Console.ReadLine();
            bool encontrado = false;

            for (int i = 0; i < n; i++)
            {
                // Buscamos ignorando mayúsculas/minúsculas para mejor experiencia
                if (nombres[i].Equals(buscar, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Resultado: {nombres[i]} tiene una nota de {notas[i]}");
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("Mensaje: Estudiante no encontrado.");
            }
        }
    }
}
