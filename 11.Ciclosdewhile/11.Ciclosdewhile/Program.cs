namespace _11.Ciclosdewhile
{
    internal class Program
    {
        //11. Realizar un algoritmo que pida números enteros positivos y los sume,
        //hasta que se ingrese un número entero negativo.
        
        //Se debe mostrar por pantalla el total de la suma de los números ingresados. Con while, contador y acumulador.

        static void Main(string[] args)

        {// usar contador y acumulador
            int numero;
            int suma = 0;
            int contador = 0;
            int acumulador = 0;

            do
            {
                Console.WriteLine("Ingrese un número entero positivo (o un número negativo para terminar): ");
                numero = int.Parse(Console.ReadLine());
                if (numero >= 0)
                {
                    suma += numero; // suma = suma + numero
                    contador++;
                    acumulador += numero; // acumulador = acumulador + numero
                }
            } while (numero >= 0);



        }


    }
}
