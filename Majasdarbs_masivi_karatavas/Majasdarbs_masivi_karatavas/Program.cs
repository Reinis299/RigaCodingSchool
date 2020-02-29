using System;

namespace Majasdarbs_masivi_karatavas
{
    class Program
    {
        static void Main(string[] args)
        {
            karatavas();
        }
        static void karatavas()
        {
            Console.WriteLine("ievadiet vardu kuru velaties minet");
            string minamaisVards = Console.ReadLine();
            //string minamaisVards = "pica";
            char[] a = new char[minamaisVards.Length];
            Console.Clear();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = '*';
            }
            Console.WriteLine("vardaa ir " + a.Length + "burti");
            // Pasaka lietotajam burtu skaitu
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + "  ");
            }
            Console.WriteLine();

            int minejums = 0;
            do
            {
                Console.WriteLine("Ievadiet burtu kurs varetu atrasties vardaa");
                char input = Console.ReadLine().ToCharArray()[0];

                for (int i = 0; i < minamaisVards.Length; i++)
                {
                    // ja uzmineja pareizi, tad aizvieto 
                    if (minamaisVards[i] == input)
                    {
                        minejums++;
                        a[i] = input;  //ja uzmin pareozo, tad aizvieto ar input

                        //Parada kads izskatas pec parveidosanas

                    }
                }
                for (int j = 0; j < a.Length; j++)
                {
                    Console.Write(a[j] + " ");
                }
                Console.WriteLine();
            }

            while (minejums < a.Length);
            Console.WriteLine("Jus uzminejat vardu!");
            Console.WriteLine("Vards kuru jus mineejaat ir" + "--------->" + minamaisVards);
        }
        
    }
}
