namespace _21.For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ciclo for

            int acumulator = 0;

            for (int i = 0; i < 10; i++)
            {
                acumulator += i;

            }

            Console.WriteLine($"La suma de los primeros cinco numeros es: {acumulator}" );
        }
    }
}
