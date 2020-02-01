using System;

namespace Diena2_mainigie
{
    class Program
    {
        static void Main(string[] args)
        {
            //cilveks ievada skaitli
            //parbauda vai ir lielaks par 5 
            //ja ir, tad izvada ##
            //ja nav, tad #
            Console.WriteLine("Ievadiet skaitli, kas ir lielaks par 5");
            String ievadam = Console.ReadLine();

            int newNr = Convert.ToInt32(ievadam);
            if (newNr > 5)
            {
                Console.WriteLine("##");
            }
            else
            {
                Console.WriteLine("#");
            }
        }

        static void piemers1()
        {
            int a = 5;
            int b = 7;
            int c = a + b;
            Console.WriteLine("Ievadiet skaitli!");
            String ievade = Console.ReadLine();

            int parkonvertetsNr = Convert.ToInt32(ievade);
            c = parkonvertetsNr - a;

            Console.WriteLine("Skaitlis ir: " + c);

            String virkne1 = "vertiba ";
            String virkne2 = "ir ";
            String virkne3 = virkne1 + virkne2;
            Console.WriteLine(virkne3);
        }
        static void piemers2()
        {
            int a = 5;
            int b = 6;

            if (a > 5)
            {
                Console.WriteLine("ir");
            }
            else
            {
                Console.WriteLine("nav");
            }

            //>
            //<
            //<=
            //>=
            //==
            //!=

            String piem = "aaa";

            if (piem == "aaa")
            {

            }
            //int c = piem.Length; sadi var dabut string garumu

        }
        static void uzdevums1()
        {
            // lietotajam jāievada kurš viņam gads
            //lietotajs ievada gadu int
            //lietotajam paprasa kura gada dzimis 
            //lietotajs ievada gadu 
            //atnemas skaitlis, lai saprasta cik gadu 
            // izvade - vecums ir: 

            Console.WriteLine("Kurs gads ir sobrid?");
            String Year = Console.ReadLine();
            int converted = Convert.ToInt32(Year);

            Console.WriteLine("Kuraa gadaa esat dzimis? ");
            Year = Console.ReadLine();
            int dzimsanas = Convert.ToInt32(Year);
            int rezultats = converted - dzimsanas;
            Console.WriteLine("Jusu vecums ir: " + rezultats);
        }
    }
}
