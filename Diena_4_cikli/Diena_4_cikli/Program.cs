using System;

namespace Diena_4_cikli
{
    class Program
    {
        static void Main(string[] args)
        {
            //forLoopExample();
            //whiled();
            //uzd1();
            //uzd2();
            uzdExtra();
        }
        static void uzd2()
        {
            //cilveks ievada 5 skaitlus un izvada skaitlu summu 
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("ievadiet skaitli: ");
                string ievade = Console.ReadLine();
                int iev = Convert.ToInt32(ievade);
                sum += iev;
            }
            Console.WriteLine("ievadito skaitlu summa ir: " + sum);
        }
        static void uzdExtra()
        {
            // cilveks ievada baazi. (skaitli ko kapinat) 
            //ievada pakaapi
            //izvada rezultātu 
            // izmanto veselus skaitlus 
            // for ciklaa
            
            Console.WriteLine("ievadiet skaitla baazi: ");
            string ievade = Console.ReadLine();
            int baze = Convert.ToInt32(ievade);
            Console.WriteLine("ievadiet pakaapi kuraa kapinaat: ");
            ievade = Console.ReadLine();
            int pakape = Convert.ToInt32(ievade);
            int rezultats = 1;
            for (int i = 0; i < pakape; i++)
            {
                rezultats = rezultats * baze;
            }
            Console.WriteLine(rezultats);

        }

        static void uzd1()
        {
            //ar for cikla palidzibu sasummet skaitlus no 1 lidz 10 un izvadit summu 
            int sum = 0;
            for (int i=0; i<11; i++)
            {
                sum += i;
                //Console.WriteLine(sum);
            }
            Console.WriteLine(sum);

        }

        static void forLoopExample()
        {
            /*for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("ievadiet frazi ");
                string fraze = Console.ReadLine();
                Console.WriteLine("cikla pielietojums -> " + i);
            }*/
            for (int i=1; i<101; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void whiled()
        {
            int a = 0;
            while (a < 10)
            {
                Console.WriteLine("cikla pielietojums -> " + a);
                a++;
            }
            a = 0;
            do
            {
                Console.WriteLine("cikla pielietojums -> " + a);
                a++;
            } while (a < 10);
        }
        
    }
}
