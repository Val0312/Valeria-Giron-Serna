using System.Security.Cryptography;

namespace _20.DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Un equipo de futbol jugó 30 partidos en el año, se desea crear un algoritmo que permita saber:   
            //Un equipo de futbol jugó 30 partidos en el año, se desea crear un algoritmo que permita saber:   
           // El número de partidos perdidos
           // El número de partidos empatados
            //El número de partidos ganados
            //El porcentaje de partidos perdidos
            //El porcentaje de partidos empatados
            //El porcentaje de partidos ganados
            // Con do while

            int partidosJugados = 30;
            int partidosPerdidos = 0;
            int partidosEmpatados = 0;
                
            int partidosGanados = 0;

            // Variables para los porcentajes
            double porcentajePerdidos;
            double porcentajeEmpatados;
            double porcentajeGanados;
            int contador = 0;

        do
            {
                Console.WriteLine("Ingrese el resultado del partido (G = Ganado, E = Empatado, P = Perdido): ");
                string resultado = Console.ReadLine().ToUpper();
                switch (resultado)
                {
                    case "G":
                        partidosGanados++;
                        break;
                    case "E":
                        partidosEmpatados++;
                        break;
                    case "P":
                        partidosPerdidos++;
                        break;
                    default:
                        Console.WriteLine("Resultado no válido. Intente de nuevo.");
                        continue; // No contar este intento
                }
                contador++;
            } while (contador < partidosJugados);

            // Cálculo de porcentajes
            porcentajePerdidos = (partidosPerdidos / (double)partidosJugados) * 100;
            porcentajeEmpatados = (partidosEmpatados / (double)partidosJugados) * 100;
            porcentajeGanados = (partidosGanados / (double)partidosJugados) * 100;
            // Mostrar resultados
            Console.WriteLine($"\nResultados después de {partidosJugados} partidos:");

            Console.WriteLine($"Partidos Ganados: {partidosGanados} ({porcentajeGanados:F2}%)");
            Console.WriteLine($"Partidos Empatados: {partidosEmpatados} ({porcentajeEmpatados:F2}%)");
            Console.WriteLine($"Partidos Perdidos: {partidosPerdidos} ({porcentajePerdidos:F2}%)");

        }


