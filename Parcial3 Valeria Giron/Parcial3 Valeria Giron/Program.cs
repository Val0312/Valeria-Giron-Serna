using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.Intrinsics.X86;

namespace Parcial3_Valeria_Giron
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Se desea desarrollar un programa para gestionar la ocupación y facturación anual de un hotel. El hotel tiene 6 pisos y en cada piso hay 4 habitaciones.
            //Se requiere registrar cuántas noches ha sido ocupada cada habitación durante el año, así como el monto total facturado por cada habitación.
            // el programa debe permitir:Utilizar dos matrices bidimensionales de 6 filas por 4 columnas:
            //            Una matriz ocupacion para almacenar la cantidad de noches ocupadas por habitación.
            //Una matriz facturacion para almacenar el total facturado en pesos por habitación.
            //Cada fila representa un piso del hotel(Piso 1 a Piso 6).
            //Cada columna representa una habitación en ese piso(Habitación A a D).
            //Para cada habitación (por piso y letra), se debe solicitar al usuario:
            //            La cantidad de noches ocupada en el año(valor entero entre 0 y 365).
            //El monto total facturado por esa habitación(valor positivo decimal).
            //Validar ambos valores:
            //            Las noches deben estar entre 0 y 365.
            //El monto debe ser mayor o igual a 0.
           
            

            int[,] ocupacion = new int[6, 4];
            float[,] facturacion = new float[6, 4];
            string[] habitaciones = { "A", "B", "C", "D" }; // Letras de las habitaciones
            Random random = new Random();
            //Ingreso de datos

            for (int piso = 0; piso < 6; piso++)
            {
                for (int hab = 0; hab < 4; hab++)
                {
                    int noches;
                    float monto;
                    
                    // Solicitar y validar noches ocupadas
                    do
                    {
                        Console.Write($"Ingrese las noches ocupadas en el año para la habitación {habitaciones[hab]} del piso {piso + 1} (0-365): ");
                        noches = int.Parse(Console.ReadLine());
                       
                        if (noches < 0 || noches > 365)
                        {
                            Console.WriteLine("Valor inválido. Intente de nuevo.");
                        }

                    } while (noches < 0 || noches > 365);
                    ocupacion[piso, hab] = noches;
                    // Solicitar y validar monto facturado
                    do
                    {
                        Console.Write($"Ingrese el monto total facturado para la habitación {habitaciones[hab]} del piso {piso + 1} (>=0 y en decimal): "); 
                        monto = float.Parse(Console.ReadLine());
                        //solo leer decimales 
                       
                        if (monto < 0)
                        {
                            Console.WriteLine("Valor inválido. Intente de nuevo.");
                        }
                    } while (monto < 0);
                    facturacion[piso, hab] = monto;
                }
            }
            // Mostrar matrices  //el programa debe mostrar ambas matrices (ocupacion y facturacion) en formato tabulado con encabezados (Pisos y Habitaciones A, B, C, D).
            //            Los valores deben presentarse con claridad y formato numérico adecuado.

            Console.WriteLine("\nMatriz de Ocupación (Noches):");
            Console.Write("       ");
            for (int hab = 0; hab < 4; hab++)
            {
                Console.Write($"   {habitaciones[hab]}   ");
            }

            //Cálculos requeridos:
            //a) Total de noches ocupadas por piso:
            //Calcular y mostrar cuántas noches en total se ocuparon en cada piso del hotel.
            //b) Ingreso total por habitación:
            //Calcular y mostrar cuánto dinero facturó cada habitación en el año.
            //c) Habitación más rentable:
            //            Determinar cuál fue la habitación que más dinero facturó en el año. Mostrar:
            //            Piso
            //            Letra de habitación
            //Monto facturado
            //d) Porcentaje de ocupación del hotel:
            //            Calcular el total de noches ocupadas en todo el hotel.
            //Calcular el porcentaje de ocupación de cada habitación con respecto al total posible.
            //e) Habitaciones sin ocupación:
            //            Mostrar cuántas habitaciones no fueron ocupadas en todo el año(0 noches).

            Console.WriteLine(
                "\nMatriz de Ocupación (Noches):");
            Console.Write("       ");
            for (int hab = 0; hab < 4; hab++)
            {
                Console.Write($"   {habitaciones[hab]}   ");
            }
            Console.WriteLine(
                "\n-------------------------------------------------");
            for (int piso = 0; piso < 6; piso++)
                {
                Console.Write($"Piso {piso + 1} |");
                for (int hab = 0; hab < 4; hab++)
                {
                    Console.Write($" {ocupacion[piso, hab],5} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(
                "\nMatriz de Facturación");
            Console.Write("       ");
            for (int hab = 0; hab < 4; hab++)
            {
                Console.Write($"   {habitaciones[hab]}   ");
            }
            Console.WriteLine(
                "\n-------------------------------------------------");
            for (int piso = 0; piso < 6; piso++)
                {
                Console.Write($"Piso {piso + 1} |");
                for (int hab = 0; hab < 4; hab++)
                {
                    Console.Write($" {facturacion[piso, hab],8:C} ");
                }
                Console.WriteLine();
            }
            //Cálculos requeridos:
            //a) Total de noches ocupadas por piso:
            Console.WriteLine("\nTotal de noches ocupadas por piso:");
            for (int piso = 0; piso < 6; piso++)
            {
                int totalNochesPiso = 0;
                for (int hab = 0; hab < 4; hab++)
                {
                    totalNochesPiso += ocupacion[piso, hab];
                }
                Console.WriteLine($"Piso {piso + 1}: {totalNochesPiso} noches");
            }
            //b) Ingreso total por habitación:
            Console.WriteLine("\nIngreso total por habitación:");
            for (int piso = 0; piso < 6; piso++)
            {
                for (int hab = 0; hab < 4; hab++)
                {
                    Console.WriteLine($"Piso {piso + 1} Habitación {habitaciones[hab]}: {facturacion[piso, hab]:C}");
                }
            }
            //c) Habitación más rentable:
            float maxFacturacion = 0;
            int pisoMax = -1;
            int habMax = -1;
            for (int piso = 0; piso < 6; piso++)
            {
                for (int hab = 0; hab < 4; hab++)
                {
                    if (facturacion[piso, hab] > maxFacturacion)
                    {
                        maxFacturacion = facturacion[piso, hab];
                        pisoMax = piso;
                        habMax = hab;
                    }
                }
            }
            Console.WriteLine($"\nHabitación más rentable: Piso {pisoMax + 1} Habitación {habitaciones[habMax]} con facturación de {maxFacturacion:C}");
            //d) Porcentaje de ocupación del hotel:
            int totalNochesHotel = 0;
            int habMaxHotel = -1;
            int pisoMaxHotel = -1;
            for (int piso = 0; piso < 6; piso++)
            {
                for (int hab = 0; hab < 4; hab++)
                {
                    totalNochesHotel += ocupacion[piso, hab];
                }
            }
            int totalNochesPosibles = 6 * 4 * 365;
            decimal porcentajeOcupacion = (decimal)totalNochesHotel / totalNochesPosibles * 100;
            Console.WriteLine($"\nPorcentaje de ocupación del hotel: {porcentajeOcupacion:F2}%");
            //e) Habitaciones sin ocupación:
            int habitacionesSinOcupacion = 0;
            for (int piso = 0; piso < 6; piso++)
            {
                for (int hab = 0; hab < 4; hab++)
                {
                    if (ocupacion[piso, hab] == 0)
                    {
                        habitacionesSinOcupacion++;
                    }
                }
            }
            Console.WriteLine($"\nHabitaciones sin ocupación en todo el año: {habitacionesSinOcupacion}");
            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();







        }
    }
}
