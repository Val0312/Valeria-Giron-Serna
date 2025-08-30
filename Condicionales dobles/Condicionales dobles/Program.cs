namespace Condicionales_dobles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crea un algoritmo que lea la edad de un usuario,
            //si el usuario es mayor de 18, se debe mostrar el siguiente mensaje:
            //“Bienvenido a mi sitio web”.

            int edad = 0;
            string nombre = "";
            int sueldo = 0;

            Console.WriteLine("Por favor, ingrese su edad:");

            edad = Convert.ToInt32(Console.ReadLine());
            if (edad >= 18)
            {
                Console.WriteLine("Bienvenido a mi sitio web");
            }
            else
            {
                Console.WriteLine("Lo siento, debes ser mayor de 18 años para ingresar.");
            }

            if (sueldo>3000)
            {
                Console.WriteLine($"La persona {nombre} debe pagar impuestos");
            }
            else
            {
                Console.WriteLine($" La persona {nombre} No debe pagar impuestos");
            }

            // Crear un algoritmo que permita ingresar dos números, si el primer número es mayor al segundo número informar su suma y diferencia, en caso contrario informar
            //el producto y la división del primer número respecto al segundo número. 

            int numero1 = 0;
            int numero2 = 0;

            Console.WriteLine("Ingrese el primer número:");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número:");
            numero2 = Convert.ToInt32(Console.ReadLine());

            if (numero1 > numero2)
            {
                int suma = numero1 + numero2;
                int diferencia = numero1 - numero2;
                Console.WriteLine($"La suma es: {suma}");
                Console.WriteLine($"La diferencia es: {diferencia}");
            }
            else
            {
                int producto = numero1 * numero2;
                double division = (double)numero1 / numero2; 
                Console.WriteLine($"El producto es: {producto}");
                Console.WriteLine($"La división es: {division}");
            }









        }
    }
}
