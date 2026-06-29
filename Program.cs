using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Threading;
using System.Collections.Generic;

namespace WriteLines
{
    class Program
    {
        static void Main(string[] args)
        {

            Random casuale = new Random();

            // numeri da estrarre
            int casuale1 = casuale.Next(1, 50);
            int casuale2 = casuale.Next(1, 50);
            int casuale3 = casuale.Next(1, 50);
            int casuale4 = casuale.Next(1, 50);
            int casuale5 = casuale.Next(1, 50);

            // numeri della mia scheda
            int num1 = casuale.Next(1, 50);

            int num2 = casuale.Next(1, 50);

            int num3 = casuale.Next(1, 50);

            int num4 = casuale.Next(1, 50);

            int num5 = casuale.Next(1, 50);

            List<int> scheda = new List<int>() {num1, num2, num3, num4, num5};

            Console.Write("TOMBOLA (scrivi qualsiasi cosa per iniziare) ");
            string scritto = Console.ReadLine();

            string tuttinumeri = string.Join(", ", scheda);

            Console.WriteLine("La tua scheda è: " + tuttinumeri);

            Thread.Sleep(1000);


            while (casuale1 != scheda[0] && casuale1 != scheda[1] && casuale1 != scheda[2] && casuale1 != scheda[3] && casuale1 != scheda[4])

                {
                casuale1 = casuale.Next(1, 50);

                Console.WriteLine($"{casuale1}?");

                Thread.Sleep(2000);

                }
            
            scheda.Remove(casuale1);
            Console.WriteLine($"{casuale1} Era nella scheda.");

            tuttinumeri = string.Join(", ", scheda);

            Thread.Sleep(3000);

            while (casuale2 != scheda[0] && casuale2 != scheda[1] && casuale2 != scheda[2] && casuale2 != scheda[3] && casuale2 != scheda[4])

                {
                casuale2 = casuale.Next(1, 50);

                Console.WriteLine($"{casuale2}?");

                Thread.Sleep(2000);

                }
            
            scheda.Remove(casuale2);
            Console.WriteLine($"{casuale2} Era nella scheda.");

            tuttinumeri = string.Join(", ", scheda);

            Thread.Sleep(3000);



            


        }
    
    }

}