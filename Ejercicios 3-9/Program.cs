using System;

namespace Ejercicios_3_9
{
    class Program
    {
        private const string Value = "Tu signo zodiacal es: acuerio";

        static void Main(string[] args)
        {
            // Crear un programa que te diga tu signo zodiacal según tu día y mes de nacimiento.

            /* Acuario 21 de enero – 19 de febrero
               Piscis  20 de febrero – 20 de marzo 
             * Aries   21 de marzo – 20 de abril
               Tauro   21 de abril – 21 de mayo
               Géminis 22 de mayo – 21 de junio
               Cáncer  22 de junio – 23 de julio
               Leo 23 de julio – 23 de agosto
               Virgo   24 de agosto – 23 de septiembre
               Libra   24 de septiembre – 23 de octubre
               Escorpio    24 de octubre – 22 de noviembre
               Sagitario   23 de noviembre – 21 de diciembre
               Capricornio 22 de diciembre – 20 de enero
               
               */

            Console.WriteLine("programa que te diga tu signo zodiacal según tu día y mes de nacimiento.");

            int d, m;

            

            Console.WriteLine("el dia de su nacimiento");
            d = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dijite el mes del nacimiento(1-12)");
            m = Convert.ToInt32(Console.ReadLine());
            
            switch (m)
            {
                case 1:
                    if (d < 21)
                    Console.WriteLine("Tu signo zodiacal es: capricornio");
                   else
                    Console.WriteLine("Tu signo zodiacal es: Acuario");
                    break;
                case 2:
                    if (d < 20)
                        Console.WriteLine("Tu signo zodiacal es: Acuario");
                    else
                        Console.WriteLine("Tu signo zodiacal es: Piscis");
                    break;
                case 3:
                    if (d < 21)
                        Console.WriteLine("Tu signo zodiacal es: Piscis");
                    else
                        Console.WriteLine("Tu signo zodiacal es: Aries");
                    break;
                case 4:
                    if (d < 22)
                        Console.WriteLine("Tu signo zodiacal es: Aries");
                    else
                        Console.WriteLine("Tu signo zodiacal es: Tauro");
                    break;
                case 5:
                    if (d < 22)
                        Console.WriteLine("Tu signo zodiacal es: Tauro");
                    else
                        Console.WriteLine("Tu signo zodiacal es: Geminis");
                    break;
                case 6:
                    if (d < 23)
                        Console.WriteLine("Tu signo zodiacal es: Geminis");
                    else
                        Console.WriteLine("Tu signo zodiacal es: Cancer");
                    break;
                case 7:
                    if (d < 23)
                        Console.WriteLine("Tu signo zodiacal es: Cancer");
                    else
                        Console.WriteLine("Tu signo zodiacal es: Leo");
                    break;
                case 8:
                    if (d < 24)
                        Console.WriteLine("Tu signo zodiacal es: Leo");
                    else
                        Console.WriteLine("Tu signo zodiacal es: Virgo");
                    break;
                case 9:
                    if (d < 24)
                        Console.WriteLine("Tu signo zodiacal es: Virgo");
                    else
                        Console.WriteLine("Tu signo zodiacal es: Libra");
                    break;
                case 10:
                    if (d < 24)
                        Console.WriteLine("Tu signo zodiacal es: Libra");
                    else
                        Console.WriteLine("Tu signo zodiacal es: Escorpio");
                    break;
                case 11:
                    if (d < 23)
                        Console.WriteLine("Tu signo zodiacal es: Escorpio");
                    else
                        Console.WriteLine("Tu signo zodiacal es: Sagitario");
                    break;
                case 12:
                    if (d < 22)
                        Console.WriteLine("Tu signo zodiacal es: Sagitario");
                    else
                        Console.WriteLine("Tu signo zodiacal es: Capricornio");
                    break;
            }

            Console.ReadKey();


        }
    }
}
