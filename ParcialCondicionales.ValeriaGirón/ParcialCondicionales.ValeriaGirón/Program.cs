using Microsoft.VisualBasic;

namespace ParcialCondicionales.ValeriaGirón
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Desarrollar un programa en C# que permita determinar el elemento zodiacal de una persona,
            //en función de su mes de nacimiento y signo zodiacal
            //Solicitar al usuario que ingrese el mes de nacimiento (por ejemplo: "marzo").




            //Datos
            string MesNacimiento;
            string SignoZodiacal;
            bool encontrado = false;





            Console.WriteLine("¿Cual es su mes de nacimiento?, escribalo con Mayuscula inicial y buena ortografía.");
            MesNacimiento = Convert.ToString(Console.ReadLine()); //El usuario ingresa el mes de nacimiento y se convierte a string

            Console.WriteLine("¿Cual es su signo zodiacal?, escribalo con Mayuscula inicial y buena ortografía.");
            SignoZodiacal = Convert.ToString(Console.ReadLine()); //El usuario ingresa el signo zodiacal y se convierte a string


            //Condicionales para determinar el elemento zodiacal

            if (MesNacimiento == "Marzo" || MesNacimiento == "Abril" || MesNacimiento == "Julio" || MesNacimiento == "Agosto" || MesNacimiento == "Noviembre" || MesNacimiento == "Diciembre")
            {
                if (SignoZodiacal == "Aries" || SignoZodiacal == "Leo" || SignoZodiacal == "Sagitario")
                {
                    Console.WriteLine("Tu elemento es Fuego");
                    encontrado = true;
                }
                
               
            }
            

            if (MesNacimiento == "Abril" || MesNacimiento == "Mayo" || MesNacimiento == "Agosto" || MesNacimiento == "Septiembre" || MesNacimiento == "Diciembre" || MesNacimiento == "Enero")
            {
                if (SignoZodiacal == "Tauro" || SignoZodiacal == "Virgo" || SignoZodiacal == "Capricornio")
                {
                    Console.WriteLine("Tú elemento es Tierra");
                    encontrado = true;

                }

                

            }
           
           

            if (MesNacimiento == "Mayo" || MesNacimiento == "Junio" || MesNacimiento == "Septiembre" || MesNacimiento == "Octubre" || MesNacimiento == "Enero" || MesNacimiento == "Febrero")
            {
                if (SignoZodiacal == "Géminis" || SignoZodiacal == "Libra" || SignoZodiacal == "Acuario")
                {
                    Console.WriteLine("Tu elemento es Aire");
                    encontrado = true;
                }
                

            }

            

            if (MesNacimiento == "Marzo" || MesNacimiento == "Junio" || MesNacimiento == "Julio" || MesNacimiento == "Octubre" || MesNacimiento == "Noviembre" || MesNacimiento == "Febrero")
            {
                if (SignoZodiacal == "Cáncer" || SignoZodiacal == "Escorpión" || SignoZodiacal == "Piscis")
                {
                    Console.WriteLine("Tu elemento es Agua");
                    encontrado = true;
                }

                

            }

            if (encontrado == false)
            {
                Console.WriteLine("Los datos ingresados no son correctos, por favor verifique la ortografía y que el mes y signo zodiacal estén correctos.");
            }





        }
    }
}
