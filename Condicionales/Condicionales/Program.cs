namespace Condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1 CREAR UN ALGORITMO QUE PERMITA INGRESAS EL NOMBRE Y SUELDO DE UN USUARIO,
            //SI EL SUELDO SUPERA LOS 3000 PESOS DEBE MOSTRAR UN MENSAJE DICIENDO EL NOMBRE DE LA PERSONA INDICANDO QUE DEBE ABONAR IMPUESTOS

            string nombre = "";
            int sueldo = 0;

            Console.WriteLine("Ingrese su nombre:");
            nombre = Console.ReadLine(); //Todo lo que leo desde la consola es un string

            
            Console.WriteLine("Ingrese su sueldo:");
            sueldo = Convert.ToInt32(Console.ReadLine()); //Si no lo convierto a int, no puedo hacer comparaciones con el sueldo

            if (sueldo>3000)
            {
                Console.WriteLine($"La persona {nombre} Debe pagar impuestos");

            }


            //Crea un algoritmo que lea la edad de un usuario,
            //si el usuario es mayor de 18, se debe mostrar el siguiente mensaje:
            //“Bienvenido a mi sitio web”.

            int edad = 0;
            Console.WriteLine("Ingrese su edad:");

            //Console.ReadLine() lee un string, por lo que debo convertirlo a int con int.Parse o Convert.ToInt32

            edad = int.Parse (Console.ReadLine());

            if (edad>18)
            {
                Console.WriteLine("Bienvenido a mi sitio web");
            }
            else
            {
                Console.WriteLine("Lo siento, debes ser mayor de 18 años para acceder a este sitio.");
            }


            if (sueldo>=3000) 
            {
                //VERDADERO
                Console.WriteLine($"La persona {nombre} Debe pagar impuestos");
            }
            else
            {
                //FALSO
                Console.WriteLine($"La persona {nombre} No debe pagar impuestos");

            }



            //Crear un algoritmo que permita ingresar dos números, si el primer número es mayor al segundo número informar su suma y diferencia, en caso contrario informar
            //el producto y la división del primer número respecto al segundo número. 

            int numero1 = 0;
            int numero2 = 0;

            Console.WriteLine("Ingrese el primer número:");
            numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número:");
            numero2 = int.Parse(Console.ReadLine());

            if (numero1>numero2)
            {
                int suma = numero1 + numero2;
                int diferencia = numero1 - numero2;
                Console.WriteLine($"La suma es: {suma} y la diferencia es: {diferencia}");
            }
            else
            {
                int producto = numero1 * numero2;
                //Para la división, si el segundo número es 0, no se puede dividir por 0
                if (numero2 != 0)
                {
                    double division = (double)numero1 / numero2; //Hago un casteo a double para obtener un resultado con decimales
                    Console.WriteLine($"El producto es: {producto} y la división es: {division}");
                }
                else
                {
                    Console.WriteLine("No se puede dividir por 0");
                }
            }


        }
    }
}
