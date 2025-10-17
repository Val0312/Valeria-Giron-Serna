namespace _24.Ciclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Algoritmo que permita solicitar 10 numeros que serán almacenados en un arreglo
            //al final visualizar el promedio de los numeros ingresados
            int[] numeros = new int[10];
            int suma = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"Ingrese el numero {i + 1}: ");
                numeros[i] = int.Parse(Console.ReadLine());
                suma += numeros[i];
            }
            double promedio = (double)suma / numeros.Length;
            Console.WriteLine($"El promedio de los numeros ingresados es: {promedio}");
            Console.ReadKey();
        }
    }
}
