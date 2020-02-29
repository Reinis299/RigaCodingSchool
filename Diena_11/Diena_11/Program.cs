using System;

namespace Diena_11
{
    class Program
    {
        static void Main(string[] args)
        {
            task1();
        }
        static void task1()
        {
            //masivs ar 5 vertibam 
            // Aizpilda masivus ar random skaitliem 
            // cilveks ievada velamo masiva garumu 
            // ja ir ievadijis 5 un mazaak, tad izvadam 
            // ja ir vairak, tad ir jasaglabaa vecaas vertibas in japardefinee masivs 
            // vecas vertibas ieliekam atpakal un pievienojam jaunas
            String[] mas = new String[5];
            for (int i = 0; i <= mas.Length - 1; i++)
            {
                Random random = new Random();
                int number = random.Next(1, 100);
                //Console.WriteLine((i + 1) + " elements ir --->" + number);
            }
            Console.WriteLine("Ievadiet masivu garumu");
            int len = Convert.ToInt32(Console.ReadLine());

            if (len <= 5)
            {
                for (int i = 0; i < mas.Length; i++)
                {
                    Console.WriteLine(mas[i]);
                }
            }
        }
        static void task2()
        {

            Console.WriteLine("Ievadiet masivu garumu");
            int len = Convert.ToInt32(Console.ReadLine());
            int[] iev = new int[len];

            if (len <= 5)
            {
                for (int i = 0; i < iev.Length; i++)
                {
                    Random random = new Random();
                    int number = random.Next(1, 100);
                    Console.WriteLine((i + 1) + " elements ir --->" + number);
                }
            }
        }
    }
}
