namespace _28.ProgramacionModular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MostrarMensaje("Soy Valeria");
            MostrarMensaje("Tengo 44 años");
            MostrarMensaje("Adiós Mundo");
        }

        static void MostrarMensaje(string mensaje)
        {
            Console.WriteLine("Bienvenido a la programación modular");
            MostrarMensaje("Estoy siendo llamado desde MostrarMensaje");
        }

        static int CalcularEdad() //todos los modulos deben ser estaticos 
        {
            int Edad = 2025 - 1981;
            return Edad;
        }

        static int calcularEdad2(int añoActual, int añoNacimiento) //modulo con parametros sirve para reutilizar el codigo

        {
            return añoActual - añoNacimiento;
        }
    }
}
