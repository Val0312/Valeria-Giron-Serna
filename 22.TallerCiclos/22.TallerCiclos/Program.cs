using System.Diagnostics.Metrics;

namespace _22.TallerCiclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Algoritmo que permita calcular promedio de calificaciones y permita
            ////que el usuario decida cuando terminar de capturar calificaciones
            ////en el momento en el que el usuario decida terminar de capturar
            ////calificaciones se debe mostrar el promedio de las calificaciones con ciclo while

            //int calificacion = 0;
            //int suma = 0;
            //int contador = 0;
            //double promedio = 0;
            //string respuesta = "s";
            //while (respuesta == "s")
            //{
            //    Console.WriteLine("Ingrese una calificacion: ");
            //    calificacion = int.Parse(Console.ReadLine());
            //    suma += calificacion; // suma = suma + calificacion
            //    contador++;
            //    Console.WriteLine("¿Desea capturar otra calificacion? (s/n)");
            //    respuesta = Console.ReadLine().ToLower();
            //}
            //if (contador > 0)
            //{
            //    promedio = (double)suma / contador;
            //    Console.WriteLine("El promedio de las calificaciones es: " + promedio);
            //}
            //else
            //{
            //    Console.WriteLine("No se capturaron calificaciones.");
            //}
            //Console.ReadKey();


            //// Algoritmo que permita calcular el resultado de una potencia dados dos numeros enteros e que es el exponente y b que es la base
            ////calcular el resultado de e elevado a la b con ciclo while

            //int e = 0;
            //int b = 0;
            //int resultado = 1;
            //Console.WriteLine("Ingrese la base (b): ");
            //b = int.Parse(Console.ReadLine());
            //Console.WriteLine("Ingrese el exponente (e): ");
            //e = int.Parse(Console.ReadLine());
            //int i = 0;
            //while (i < e)
            //{
            //    resultado *= b; // resultado = resultado * b
            //    i++;
            //}
            //Console.WriteLine(b + " elevado a la " + e + " es: " + resultado);
            //Console.ReadKey();
            //Console.ReadLine();

            ////Ejemplo de ciclo for donde se requiere un algortimo para hallar los divisores de un número 
            ////utilizando operaddor mod% para obtener el residuo de una división

            //int numero = 0;
            //Console.WriteLine("Ingrese un número para hallar sus divisores: ");
            //numero = int.Parse(Console.ReadLine());
            //Console.WriteLine("Los divisores de " + numero + " son: ");
            //for (int j = 1; j <= numero; j++)
            //{
            //    if (numero % j == 0)
            //    {
            //        Console.WriteLine(j);
            //    }
            //}
            //Console.ReadKey();
            //Console.ReadLine();

            //// Un entrenador le ha propuesto a un atleta recorrer una ruta de cinco kilometros durante 10 dias
            //// para determinar si es apto para competir en una carrera de 5 kilometros
            ////para ser apto debe tener un tiempo menor a 20 minutos 
            //// que en una de las pruebas realice un tiempo menor a 15 minutos
            ////que su promedio sea menor o igual a 18 minutos
            ////diseñar el algoritmo que permita determinar si el atleta es apto o no para competir

            //int tiempo = 0;
            //int sumaTiempos = 0;
            //int dias = 10;
            //bool apto = false;
            //bool tiempoMenor15 = false;
            //for (int k = 1; k <= dias; k++)
            //{
            //    Console.WriteLine("Ingrese el tiempo en minutos para el dia " + k + ": ");
            //    tiempo = int.Parse(Console.ReadLine());
            //    sumaTiempos += tiempo;
            //    if (tiempo < 15)
            //    {
            //        tiempoMenor15 = true;
            //    }
            //}
            //double promedioTiempos = (double)sumaTiempos / dias;
            //if (promedioTiempos <= 18 && tiempoMenor15)
            //{
            //    apto = true;
            //}
            //if (apto)
            //{
            //    Console.WriteLine("El atleta es apto para competir.");
            //}
            //else
            //{
            //    Console.WriteLine("El atleta no es apto para competir.");
            //}
            //Console.ReadKey();
            //Console.ReadLine();

            ////Se aplicó una encuensta a n personas, solicitando su opinion sobre el tema del servicio militar obligatorio para mujeres
            ////las respuestas son: a favor, en contra e indiferente 
            ////se requiere determinar el porcentaje de personas que respondieron a favor, en contra e indiferente

            //int n = 0;
            //int aFavor = 0;
            //int enContra = 0;
            //int indiferente = 0;
            //string opinion = "";
            //Console.WriteLine("Ingrese el número de personas encuestadas: ");
            //n = int.Parse(Console.ReadLine());
            //for (int l = 1; l <= n; l++)
            //{
            //    Console.WriteLine("Ingrese la opinión de la persona " + l + " (a favor, en contra, indiferente): ");
            //    opinion = Console.ReadLine().ToLower();
            //    if (opinion == "a favor")
            //    {
            //        aFavor++;
            //    }
            //    else if (opinion == "en contra")
            //    {
            //        enContra++;
            //    }
            //    else if (opinion == "indiferente")
            //    {
            //        indiferente++;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Opinión no válida.");
            //        l--; // para repetir la iteración
            //    }
            //}
            //double porcentajeAFavor = (double)aFavor / n * 100;
            //double porcentajeEnContra = (double)enContra / n * 100;
            //double porcentajeIndiferente = (double)indiferente / n * 100;
            //Console.WriteLine("Porcentaje a favor: " + porcentajeAFavor + "%");
            //Console.WriteLine("Porcentaje en contra: " + porcentajeEnContra + "%");
            //Console.WriteLine("Porcentaje indiferente: " + porcentajeIndiferente + "%");
            //Console.ReadKey();
            //Console.ReadLine();


          
                





















        }



    }
}



