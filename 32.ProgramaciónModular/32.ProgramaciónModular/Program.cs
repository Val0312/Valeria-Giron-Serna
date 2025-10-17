namespace _31.ProgramaciónModular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Algoritmo que muestre un menú con operaciones (+,-,*,/) y permita realizar la operación que el usuario ingrese por teclado. Si es suma o multiplicación, permitirle al usuario realizar estas operaciones con la cantidad
            //de números que el desee ingresar. Si es división o resta solo dejar realizar la operación con dos números. 

            double Sumar(int cantidad)
            {
                double suma = 0;
                for (int i = 0; i < cantidad; i++)
                {
                    Console.WriteLine("Ingrese el número " + (i + 1) + ": ");
                    double numero = double.Parse(Console.ReadLine());
                    suma += numero;
                }
                return suma;
            }
            double Restar()
            {
                Console.WriteLine("Ingrese el primer número: ");
                double numero1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo número: ");
                double numero2 = double.Parse(Console.ReadLine());
                return numero1 - numero2;
            }
            double Multiplicar(int cantidad)
            {
                double producto = 1;
                for (int i = 0; i < cantidad; i++)
                {
                    Console.WriteLine("Ingrese el número " + (i + 1) + ": ");
                    double numero = double.Parse(Console.ReadLine());
                    producto *= numero;
                }
                return producto;
            }
            double Dividir()
            {
                Console.WriteLine("Ingrese el primer número: ");
                double numero1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo número: ");
                double numero2 = double.Parse(Console.ReadLine());
                if (numero2 == 0)
                {
                    Console.WriteLine("No se puede dividir por cero.");
                    return 0;
                }
                return numero1 / numero2;
            }
            Console.WriteLine("Ingrese la operación que desea realizar (+, -, *, /): ");
            string operacion = Console.ReadLine();
            Console.WriteLine("Ingrese la cantidad de números que desea operar: ");
            int cantidadNumeros = int.Parse(Console.ReadLine());
            double resultado = 0;
            switch (operacion)
            {
                case "+":
                    resultado = Sumar(cantidadNumeros);
                    break;
                case "-":
                    if (cantidadNumeros != 2)
                    {
                        Console.WriteLine("La resta solo se puede realizar con dos números.");
                        return;
                    }
                    resultado = Restar();
                    break;
                case "*":
                    resultado = Multiplicar(cantidadNumeros);
                    break;
                case "/":
                    if (cantidadNumeros != 2)
                    {
                        Console.WriteLine("La división solo se puede realizar con dos números.");
                        return;
                    }
                    resultado = Dividir();
                    break;
                default:
                    Console.WriteLine("Operación no válida.");
                    return;
            }
            Console.WriteLine("El resultado es: " + resultado);
            Console.WriteLine(
                "Presione cualquier tecla para finalizar...");
            




        }
    }
}
