using System;

namespace Majasdarbs_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random();
            Parbaude();
        }
        static void Random()
        {
            Random rand = new Random();
            int diena = rand.Next(1, 7);
            if(diena == 1)
            {
                Console.WriteLine("pirmdiena");
            }
            else if (diena == 2)
            {
                Console.WriteLine("otrdiena");
            }
            else if (diena == 3)
            {
                Console.WriteLine("tresdiena");
            }
            else if (diena == 4)
            {
                Console.WriteLine("ceturtdiena");
            }
            else if (diena == 5)
            {
                Console.WriteLine("piektdiena");
            }
            else if (diena == 6)
            {
                Console.WriteLine("sestdiena");
            }
            else if (diena == 7)
            {
                Console.WriteLine("svetdiena");
            }
        }
        static void Parbaude()
        {
            Console.WriteLine("ievadiet skaitli, lai parbauditu vai tas ir pozitivs");
            string ievade = Console.ReadLine();
            int iev1 = Convert.ToInt32(ievade);
            if (iev1 > 0)
            {
                Console.WriteLine("skaitlis ir pozitivs");
            }
            if (iev1 < 0)
            {
                Console.WriteLine("skaitlis ir negativs");
            }
            if (iev1 == 0)
            {
                Console.WriteLine("skaitlis ir nulle");
            }
        }
    }
}
