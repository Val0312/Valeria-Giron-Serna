using System.Security.Cryptography;
using System.Text;

namespace _6.CondicionalMultipleTerciario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tiendas La Avenida desea desarrollar un programa que permita ingresar por teclado el monto de compra y el día de la semana, para saber:
            //Si el día es martes o jueves, se realizará un descuento del 15 % por la compra. 
            // Si el día es lunes o miércoles, se realizará un descuento del 10 % por la compra.
            //Si el día es viernes o sábado, se realizará un descuento del 20 % por la compra.
            // Si es domingo no se realiza descuento.
            //Visualizar el día, el descuento y el total a pagar por la compra. 

            float ValorCompra = 0;
            float Descuento = 0;
            Char DiaSemana = ' ';

            Console.WriteLine("Ingrese el monto de compra:");
            ValorCompra = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el día de la semana (L:Lunes M: Maartes, X: Miercoles, J: jueves, V:Viernes, S:Sábado , D:Domingo):");
            DiaSemana = char.ToUpper(Console.ReadKey().KeyChar);

            switch (DiaSemana)
            {

                case 'L': // Lunes
                    Descuento = ValorCompra * 0.10f;
                    Console.WriteLine("Hoy es Lunes el descuento es de un 10%");
                    break;

                case 'M': // Martes
                    Descuento = ValorCompra * 0.15f;
                    Console.WriteLine("Hoy es Martes el descuento es de un 15%");
                    break;
                case 'X': // Miércoles
                    Descuento = ValorCompra * 0.10f;
                    Console.WriteLine("Hoy es Miércoles el descuento es de un 10%");
                    break;
                case 'J': // Jueves
                    Descuento = ValorCompra * 0.15f;
                    Console.WriteLine("Hoy es Jueves el descuento es de un 15%");
                    break;


                case 'V': // Viernes
                    Descuento = ValorCompra * 0.20f;
                    Console.WriteLine("Hoy es Viernes el descuento es de un 20%");
                    break;

                case 'S': // Sábado
                    Descuento = ValorCompra * 0.20f;
                    Console.WriteLine("Hoy es Sábado el descuento es de un 20%");
                    break;

                case 'D': // Domingo
                    Descuento = 0;
                    Console.WriteLine("Hoy es Domingo no hay descuento");
                    break;


                default: // Caso por defecto para manejar días no válidos
                    Console.WriteLine("Día no válido.");
                    return; // Salir del programa si el día no es válido


                    //Diseñar un algoritmo que permita crear una calculadora básica capaz de realizar operaciones aritméticas entre dos números ingresados por el usuario.
                    //Las operaciones disponibles serán: suma, resta, multiplicación y división, las cuales se ejecutarán según la opción seleccionada por el usuario. 

                    int Operaciones = 0;
                    float Numero1 = 0;
                    float Numero2 = 0;


                    switch (Operaciones)

                    {
                        case 1: // Suma
                            Console.WriteLine("Ingrese el primer número:");
                            Numero1 = float.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el segundo número:");
                            Numero2 = float.Parse(Console.ReadLine());
                            Console.WriteLine($"El resultado de la suma es: {Numero1 + Numero2}");
                            break;
                        case 2: // Resta
                            Console.WriteLine("Ingrese el primer número:");
                            Numero1 = float.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el segundo número:");
                            Numero2 = float.Parse(Console.ReadLine());
                            Console.WriteLine($"El resultado de la resta es: {Numero1 - Numero2}");
                            break;
                        case 3: // Multiplicación
                            Console.WriteLine("Ingrese el primer número:");
                            Numero1 = float.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el segundo número:");
                            Numero2 = float.Parse(Console.ReadLine());
                            Console.WriteLine($"El resultado de la multiplicación es: {Numero1 * Numero2}");
                            break;
                        case 4: // División
                            Console.WriteLine("Ingrese el primer número:");
                            Numero1 = float.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el segundo número:");
                            Numero2 = float.Parse(Console.ReadLine());
                            if (Numero2 != 0)
                            {
                                Console.WriteLine($"El resultado de la división es: {Numero1 / Numero2}");
                            }
                            else
                            {
                                Console.WriteLine("Error: No se puede dividir por cero.");
                            }
                            break;
                        default: // Caso por defecto para manejar opciones no válidas
                            Console.WriteLine("Opción no válida.");
                            break;


                    }

            }
        }
    }
}

