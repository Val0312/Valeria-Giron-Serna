namespace _9.Ciclowhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escribir un algoritmo que permita generar primeros 5 números enteros positivos y realizar y mostrar su suma.
            //con contador y acumulador

            int contador = 0;
            int acumulador = 0;

            while (contador <= 5)
            {
                acumulador += contador;//acumulador = acumulador + contador
                Console.WriteLine($"C: {contador} - A: {acumulador}"); //es para ver el proceso
                contador++;
            }


            Console.WriteLine($"La suma de los primeros 5 números enteros positivos es: {acumulador}");




        }
    }

}
