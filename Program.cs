using System;
using System.Globalization;

namespace DateTime1
{
    class program
    {
        static void Main(string[] args)
        {
            DateTime d1 = DateTime.Now;


            Console.WriteLine(d1);

            //O numero de "ticks" ( 100 nanosegundos) desde a meia noite do dia 1 de janeiro do ano 1 da era comum.

            Console.WriteLine(d1.Ticks);

            Console.WriteLine("_________________________________");

            DateTime d2 = new DateTime(2018, 11, 25);
            DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 3);
            DateTime d4 = new DateTime(2018, 11, 25, 20, 45, 3, 500);


            DateTime d5 = DateTime.Now;
            DateTime d6 = DateTime.Today;
            DateTime d7 = DateTime.UtcNow;






            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine(d7);


            Console.WriteLine("_____________________________________");


            DateTime d8 = DateTime.Parse("2000-08-15");
            DateTime d9 = DateTime.Parse("2000-08-15 23:40:48");
            DateTime d10 = DateTime.Parse("15/08/2000");
            DateTime d11 = DateTime.Parse("15/08/2000 13:05:58");

            Console.WriteLine(d8);
            Console.WriteLine(d9);
            Console.WriteLine(d10);
            Console.WriteLine(d11);

            Console.WriteLine("__________________________________");

            DateTime d12 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);


            DateTime d13 = DateTime.ParseExact("15/08/2018 23:46:42", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);


            Console.WriteLine(d12);
            Console.WriteLine(d13);





        }
    }
}