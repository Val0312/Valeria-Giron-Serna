namespace _12.Ciclosdewhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Realizar algoritmo que permita obtener la suma de todos los números impares hasta el 99. con while contador y acumulador

            int contador = 1;
            int acumulador = 0;
            while (contador < 100)
            {
                acumulador += contador;
                contador += 2;
            }

            Console.WriteLine("La suma de todos los números impares hasta el 99 es: " + acumulador);



        }
    }
}
