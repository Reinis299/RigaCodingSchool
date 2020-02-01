using System;

namespace Majasdarbs_1
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        static void uzdevums1()
        {
            Console.WriteLine("Ievadiet skaitli robezas no 1 - 10 ");
            string ievade = Console.ReadLine();
            int jauns = Convert.ToInt32(ievade);

            if (jauns > 5)
            {
                Console.WriteLine("Skaitlis ir lielaks par 5 ");
            }
            else if (jauns < 5)
            {
                Console.WriteLine("Skaitlis ir mazaks par 5 ");
            }
            else
            {
                Console.WriteLine("Skaitlis ir vienads ar 5 ");
            }
        }
        static void uzdevums2()
        {
            Console.WriteLine("Ievadiet cetru burtu salikumu ");
            string vards = Console.ReadLine();
            if (vards.Length == 4 && vards == "aaaa")
            {
                Console.WriteLine("sis ir 4 burtu salikums ");
            }
            else
            {
                Console.WriteLine("iemacies lasit ");
            }
        }
        static void uzdevums3()
        {
            Console.WriteLine("uzminiet 4 burtu vardu, tas ir apals un edams ");
            string vards = Console.ReadLine();
            if (vards == "pica")
            {
                Console.WriteLine("jaa, taa ir pica ");
            }
            else
            {
                Console.WriteLine("miniet velreiz ");
            }
        }
    }
}
