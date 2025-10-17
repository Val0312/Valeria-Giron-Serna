namespace _23.Ciclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear arreglo llamado numeros de 100 elementos y asignar el numero 10 en cada una
            //de las posiciones del arreglo utilizando un ciclo for, ademas leer el contenido de cada elemento y
            //escribirlo en pantalla
            int[] numeros = new int[100];
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = 10;
            }
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }
            Console.ReadKey();

        }
    }
}
