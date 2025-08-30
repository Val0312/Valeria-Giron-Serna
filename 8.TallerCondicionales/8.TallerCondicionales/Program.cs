namespace _8.TallerCondicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear un algoritmo que permita leer tres valores y almacenarlos en las variables 
            // num1 num2 y num3.El algoritmo debe comprobar si los numeros son diferentes y si es asi imprimir cual es el
            //mayor de los tres ademas ordenar y mostrar en pantalla los numeros de menor a mayor

            int num1 = 0;
            int num2 = 0;
            int num3 = 0;


            Console.WriteLine("Ingrese el primer numero:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero:");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer numero:");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 == num2 || num1 == num3 || num2 == num3)
            {
                Console.WriteLine("Los numeros deben ser diferentes.");
            }
            else
            {
                int mayor = Math.Max(num1, Math.Max(num2, num3)); // Encontrar el mayor de los tres numeros
                int menor = Math.Min(num1, Math.Min(num2, num3)); // Encontrar el menor de los tres numeros
                Console.WriteLine($"El numero mayor es: {mayor}");
                Console.WriteLine($"El numero menor es: {menor}");







                // Ordenar los numeros de menor a mayor
                int medio = num1 + num2 + num3 - mayor - menor; // Calcular el numero medio
                Console.WriteLine($"Los numeros ordenados de menor a mayor son: {menor}, {medio}, {mayor}");
            }
        }
    }
}


internal class Program
    {
    private static void Main(string[] args)
    {
        int num1 = 0;
        int num2 = 0;
        int num3 = 0;

        Console.WriteLine("Ingrese el primer numero:");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo numero:");
        num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ingrese el tercer numero:");
        num3 = Convert.ToInt32(Console.ReadLine());



        if (num1 == num2 || num1 == num3 || num2 == num3)
        {
            Console.WriteLine("Los numeros deben ser diferentes.");
        }

        // Encontrar el mayor de los tres numeros con operadores ternarios
        int mayor = (num1 > num2) ? (num1 > num3 ? num1 : num3) : (num2 > num3 ? num2 : num3);
        Console.WriteLine($"El numero mayor es: {mayor}");

        // Encontrar el menor de los tres numeros con operadores ternarios
        int menor = (num1 > num2) ? (num2 < num3 ? num2 : num3) : (num1 < num3 ? num1 : num3);

        Console.WriteLine($"El numero menor es: {menor}");

        // Numero medio
        int medio = (num1 > num2) ? (num1 < num3 ? num1 : (num2 > num3 ? num2 : num3)) : (num2 < num3 ? num2 : (num1 > num3 ? num1 : num3));
        Console.WriteLine($"El numero medio es: {medio}");

        Console.WriteLine($"Los numeros ordenados de menor a mayor son: {menor}, {medio}, {mayor}");




        // El personaje de un juego puede disparar si cumple con dos condiciones: municion y si esta en estado invencible, crear
        // un programa que permita ingresar por teclado si el personaje esta en estado invencible (true) y la cantidad de munición que tiene el personaje que será
        // calculada por medio de un numero aleatorio por medio de la clase random de C#

        int numero;
        string invencible;

        


        Random rnd = new Random();
        numero = rnd.Next(0, 10); // Genera un numero aleatorio entre 0 y 9
        Console.WriteLine($"El personaje tiene {numero} balas.");

        if (numero > 0 || numero <= 10)
        {
            Console.WriteLine("El personaje está disparando.");
        }
       







    }

}

   

