namespace CondicionalAnidado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Condicional anidado Diseñar un algoritmo que lea tres números A, B y C y se visualice el mayor de ellos.El usuario ingresará los números A, B y C por teclado.

            int numA = 0;
            int numB = 0;
            int numC = 0;

            Console.WriteLine("Ingrese el primer número (A): ");
            numA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número (B): ");
            numB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer número (C): ");
            numC = Convert.ToInt32(Console.ReadLine());
            // Condicional anidado para determinar el mayor de los tres números


            if (numA>numB)
            {
                if (numA > numC)
                {
                    Console.WriteLine("El número mayor es {numA}");

                }
                else
                {
                    Console.WriteLine("El número mayor es {numC}");
                     

           
                }

            }

            else
            {
                if (numB > numC)
                {
                    Console.WriteLine("El número mayor es {numB}");
                }
                else
                {
                    Console.WriteLine("El número mayor es {numC}");
                }
            }


        }
    }
}
