namespace _14.While6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //. Realizar un algoritmo que le pida al usuario ingresar por teclado números enteros al azar. Al usuario le corresponde ingresar la cantidad de números que va a introducir.  
            //            El algoritmo debe escribir en pantalla: 
            //La cantidad de números introducidos que son mayores que 0
            //La cantidad de números introducidos menores que 0
            //La cantidad de números iguales a 0.
            //Usar la estructura Mientras (While).

            int cantidadNumeros, numero;
            int contadorPositivos = 0, contadorNegativos = 0, contadorCeros = 0;
            Console.Write("Ingrese la cantidad de números que va a introducir: ");
            cantidadNumeros = int.Parse(Console.ReadLine());
            int i = 0;
            while (i < cantidadNumeros)
            {
                Console.Write("Ingrese un número entero: ");
                numero = int.Parse(Console.ReadLine());
                if (numero > 0)
                {
                    contadorPositivos++;
                }
                else if (numero < 0)
                {
                    contadorNegativos++;
                }
                else
                {
                    contadorCeros++;
                }
                i++;
            }
            Console.WriteLine($"Cantidad de números mayores que 0: {contadorPositivos}");
            Console.WriteLine($"Cantidad de números menores que 0: {contadorNegativos}");
            Console.WriteLine($"Cantidad de números iguales a 0: {contadorCeros}");





        }
    }
}
