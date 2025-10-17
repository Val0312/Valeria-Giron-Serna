namespace _15.While7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Realizar un algoritmo para determinar cuánto ahorrará una persona en un año, si al final de cada mes deposita cantidades variables de dinero; además, se quiere saber cuánto lleva ahorrado cada mes. 

            int mes = 1;
            double ahorroMensual, ahorroTotal = 0;
            while (mes <= 12)
            {
                Console.Write("Ingrese la cantidad de dinero que ahorró en el mes " + mes + ": ");
                ahorroMensual = Convert.ToDouble(Console.ReadLine());
                ahorroTotal += ahorroMensual;
                Console.WriteLine("El ahorro total hasta el mes " + mes + " es: " + ahorroTotal);
                mes++;
            }
            Console.WriteLine("El ahorro total en el año es: " + ahorroTotal);
            Console.ReadKey();


        }
    }
}
