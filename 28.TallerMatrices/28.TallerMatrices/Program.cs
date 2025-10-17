namespace _28.TallerMatrices
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    //Desarrollar un programa que crea una matriz de 10 filas y 20 columnas y muestre por pantalla la suma de los elementos de cada columna
        //    int[,] matriz = new int[10, 20];
        //    Random random = new Random();
        //    int[] sumaColumnas = new int[20];
        //    // Llenar la matriz con números aleatorios y calcular la suma de cada columna
        //    for (int i = 0; i < 10; i++)
        //    {
        //        for (int j = 0; j < 20; j++)
        //        {
        //            matriz[i, j] = random.Next(1, 100); // Números aleatorios entre 1 y 99
        //            sumaColumnas[j] += matriz[i, j];
        //        }

        //    }

        //    // Mostrar la suma de cada columna
        //    Console.WriteLine("Suma de los elementos de cada columna:");
        //    for (int j = 0; j < 20; j++)
        //    {
        //        Console.WriteLine($"Columna {j + 1}: {sumaColumnas[j]}");
        //    }







        //}

        //Desarrollar un programa que cree una matriz de n filas y m columnas donde el usuarios ingrese caracteres en cada posicion de la matriz hasta
        //llenarla.El programa debe intercambiar la primera fila con la ultima fila de la matriz y al final imprimir la matriz original y la matriz intercambiada.
        static void Main(string[] args)
        {
            Console.Write("Ingrese el número de filas (n): ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el número de columnas (m): ");
            int m = int.Parse(Console.ReadLine());
            char[,] matriz = new char[n, m];
            // Llenar la matriz con caracteres ingresados por el usuario
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"Ingrese el carácter para la posición [{i},{j}]: ");
                    matriz[i, j] = Console.ReadLine()[0]; // Tomar el primer carácter ingresado
                }
            }
            // Mostrar la matriz original
            Console.WriteLine("\nMatriz Original:");
            MostrarMatriz(matriz, n, m);
            // Intercambiar la primera fila con la última fila
            for (int j = 0; j < m; j++)
            {
                char temp = matriz[0, j];
                matriz[0, j] = matriz[n - 1, j];
                matriz[n - 1, j] = temp;
            }
            // Mostrar la matriz intercambiada
            Console.WriteLine("\nMatriz con filas intercambiadas:");
            MostrarMatriz(matriz, n, m);
        }
        static void MostrarMatriz(char[,] matriz, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }

        }

    }
}
