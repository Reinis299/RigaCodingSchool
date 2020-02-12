using System;

namespace Diena3_metodes
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool a = true;
           // a = false;
           // a = !a;
            // cilveks ievada skaitli 
            // uztaisam metodi, kas atgriez (return) vai skaitlis ir pozitivs vai negativs
            Console.WriteLine("Ievadiet skaitli! ");
            String skaitlaIevade = Console.ReadLine();
            int sk1 = Convert.ToInt32(skaitlaIevade);
            Console.WriteLine("rezultāts ir :  " + YesNo(sk1) );
        }
        static bool YesNo(int a)
        {
            if (a > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void refrectorTask()
        {
            //Cilveks ievada tris skaitlus- int
            //Jaizvada lielakais

            int sk1 = input1();
            int sk2 = input1();
            int sk3 = input1();
            int big = biggest(sk1, sk2);
            big = biggest(big, sk3);
            Console.WriteLine("Rezultats ir " + big);

        }
        static int biggest(int a, int b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        static int input1()
        {
            Console.WriteLine("Ievadiet skaitli!");
            String skaitlaIevade = Console.ReadLine();
            int sk1 = Convert.ToInt32(skaitlaIevade);
            return sk1;
        }


        static void From1to3()
        {
            /*piemers1();
            piemers2();
            piemers3(3,4);
            int c = piemers4();
            piemers3(c, 6);
            piemers5();*/

            // 1. saskaitisana - 
            // ievads main metodee. padodam skaitlus uz musu izveidoto ka parametrus
            // izvade notiek tur 

            //2. ievade notiek musu izveidotajaa metodee. 
            //rezultatu atgriezam ar return un izvadam main. 

            // 3. apvienojam 1 un 2 uzdevumu. 
            // musu izveidotajaa metodee notiek tikai darbiba. visa ievade/izvade notiek main (gan parametri, gan return. 

            //saskaitisana(2, 5);
            /*int g = sask2();
            Console.WriteLine(g);*/
            Console.WriteLine("ievadiet skaitli ");
            String a = Console.ReadLine();
            int sk1 = Convert.ToInt32(a);
            Console.WriteLine("ievadiet skaitli ");
            string b = Console.ReadLine();
            int sk2 = Convert.ToInt32(b);
            Console.WriteLine("Skaitlu summa ir: " + tresais(sk1, sk2));
        }
        static int tresais(int a, int b)
        {
            return (a + b);
        }
        static int sask2()
        {
            int a = 4;
            int b = 6;
            return a + b;
        }
        static void saskaitisana(int a, int b)
        {
            Console.WriteLine(a+b);
        }
        static void piemers1()
        {
            Console.WriteLine("parasta void metode");
            piemers2();
        }

        static void piemers2()
        {
            // metode obligati ir jaizsauc no main, vai no citas metodes.
            Console.WriteLine("Velviena void metode");
        }

        static void piemers3(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        static int piemers4()
        {
            int sk1 = 5;
            int sk2 = 61111;
            return sk1 + sk2;
        }

        static string piemers5()
        {
            Console.WriteLine("ievadiet kaut ko");
            string ievads = Console.ReadLine();
            return ievads;
        }
    }
}
