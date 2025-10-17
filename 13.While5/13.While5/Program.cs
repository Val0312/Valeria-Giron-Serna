namespace _13.While5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escribir un algoritmo que cuente cuántos números pares hay en un rango de números del 1 al número n. con ciclos de While

            Console.WriteLine("Ingrese un número entero positivo:");
            int n = int.Parse(Console.ReadLine());
            int contador = 0;

            int i = 1;
            while (i <= n)
            {
                if (i % 2 == 0)
                {
                    contador++;
                }
                i++;
            }

            Console.WriteLine($"Hay {contador} números pares entre 1 y {n}.");
            Console.ReadKey();






        }
    }
}
