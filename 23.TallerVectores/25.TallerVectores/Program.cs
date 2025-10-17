namespace _25.TallerVectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escribir un algoritmo que permita llenar un vector (15) con numeros enteros y luego encuentre y muestre el valor máximo y mínimo de los numeros ingresados.
            int[] vector = new int[15];
            int max = int.MinValue;
            int min = int.MaxValue;
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write("Ingrese un numero entero: ");
                vector[i] = int.Parse(Console.ReadLine());
                if (vector[i] > max)
                {
                    max = vector[i];
                }
                if (vector[i] < min)
                {
                    min = vector[i];
                }
            }
            Console.WriteLine($"El valor maximo es: {max}");
            Console.WriteLine($"El valor minimo es: {min}");
            Console.ReadKey();



        }


        //escribir un algoritmo que permita intregar caracteres en un vector y luego invierta el orden de los elementos, se deben mostrar los 2 vectores, el original y el invertido.

        static void InvertirVector()
        {
            char[] vector = new char[10];
            char[] vectorInvertido = new char[10];
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write("Ingrese un caracter: ");
                vector[i] = char.Parse(Console.ReadLine());
            }
            for (int i = 0; i < vector.Length; i++)
            {
                vectorInvertido[i] = vector[vector.Length - 1 - i];
            }
            Console.WriteLine("Vector original: ");
            foreach (char c in vector)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Vector invertido: ");
            foreach (char c in vectorInvertido)
            {
                Console.Write(c + " ");
            }
            Console.ReadKey();
        }

        //Crear un algoritmo que llene un vector [20]con numeros enteros positivos aleatorios entre 0 y 50. luego debe pedir al usuario un numero para buscar el vector.Si encuentra el numero se debe mostrar en pantalla: la posición del numero y el vector resaltando el número en un color diferente. Si no encuentra el número se debe devolver y mostrar -1


        static void BuscarNumeroEnVector()
        {
            int[] vector = new int[20];
            Random rand = new Random();
            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = rand.Next(0, 51);
            }
            Console.Write("Ingrese un numero para buscar en el vector: ");
            int numeroBuscado = int.Parse(Console.ReadLine());
            int posicion = -1;
            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] == numeroBuscado)
                {
                    posicion = i;
                    break;
                }
            }
            if (posicion != -1)
            {
                Console.WriteLine($"El numero {numeroBuscado} se encuentra en la posicion {posicion}");
                Console.WriteLine("Vector: ");
                for (int i = 0; i < vector.Length; i++)
                {
                    if (i == posicion)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(vector[i] + " ");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write(vector[i] + " ");
                    }
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("-1");
            }
            Console.ReadKey();




        }








    }
}
