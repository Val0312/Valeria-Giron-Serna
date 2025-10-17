namespace Parcial_2_Valeria_Giron_Serna
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Un profesor tiene las calificaciones de 14 alumnos y necesita procesar la información para obtener un análisis general del curso. Las notas se encuentran en un rango de 0 a 10.
            //            El programa debe realizar las siguientes operaciones:
            //            Leer por teclado la nota de cada uno de los 14 estudiantes.
            //Calcular el promedio de todas las notas.
            //Identificar y mostrar cuál fue la nota mayor y la nota menor entre las ingresadas.
            //Contar cuántos estudiantes aprobaron la asignatura(nota mayor o igual a 6.0).
            //Mostrar por pantalla:
            //            El promedio general.
            //La nota más alta.
            //La nota más baja.
            //La cantidad de aprobados en el curso.
            // con ciclo for

            int numeroEstudiantes = 14;
            double sumaNotas = 0;
            double notaMayor = double.MinValue; //double.MinValue para asegurar que cualquier nota ingresada sea mayor a esta
            double notaMenor = double.MaxValue;
            int cantidadAprobados = 0;

            for (int i = 1; i <= numeroEstudiantes; i++)
            {
                Console.Write($"Ingrese la nota del estudiante {i} (0-10): si contiene decimales use , (coma) ");
                double nota = Convert.ToDouble(Console.ReadLine()); // Leer la nota del estudiante
                // Validar que la nota esté en el rango correcto
                while (nota < 0.00 || nota > 10.00) //incluir decimales
                {
                    Console.Write("Esta nota no es posible. Ingrese una nota entre 0 y 10: ");
                    nota = Convert.ToDouble(Console.ReadLine());
                }
                sumaNotas += nota; // Acumular la suma de las notas
                if (nota > notaMayor)
                {
                    notaMayor = nota;
                }
                if (nota < notaMenor)
                {
                    notaMenor = nota;
                }
                if (nota >= 6.0)
                {
                    cantidadAprobados++;
                }
            }

            double promedio = sumaNotas / numeroEstudiantes;
            Console.WriteLine($"\nEl promedio general es: {promedio:F2}"); // Mostrar el promedio con 2 decimales
            Console.WriteLine($"La nota más alta es: {notaMayor:F2}");
            Console.WriteLine($"La nota más baja es: {notaMenor:F2}");
            Console.WriteLine($"La cantidad de alumnos que aprobar el curso es: {cantidadAprobados}");
        }
    }
}
