using System;

namespace Diena_8_objekti
{
    class Program
    {
        static void Main(string[] args)
        {
            //piemers();
            //aplis();
            task1();

        }
        static void task1()
        {
            //izveidot klasi
            // jabut laukam kur glabasies skaitlis int. 
            // jauzgenere random skaitlis no 1 - 10. tas jaizdara konstruktoraa.
            // getNumber, kas atgriez so skaitli 
            //regenerateNumber() - no jauna uzgenere gadijuma skaitli

            // uztaisam vienu objektu main
            // uztaisam otru objektu main
            // iet while cikls. 
            //salidzina abu objektu gadijuma skaitlus
            // lielakais skaitlis uzvar
            // ka piefikset uzvaras - freestyle
            //apstajas tad, kad viens objekts ir uzvarejis 3 reizes 
            /*Random random = new Random();
            int number = random.Next(1,10)*/

            /* const int uzvaretajs = 3;
             int pirm = 0;
             int otr = 0;
                 for (int i = 0; i <= uzvaretajs; i++)
                 {
                     skaitlis sk = new skaitlis();
                     Console.WriteLine(sk.getNumber());
                     skaitlis sk2 = new skaitlis();
                     Console.WriteLine(sk2.getNumber());
                     if (sk.getNumber() > sk2.getNumber())
                     {
                         Console.WriteLine("Pirmais skaitlis bija liekaaks ");
                         pirm++;
                     }
                     else
                     {
                         Console.WriteLine("Otrais skaitlis bija liekaaks ");
                         otr++;
                     }
                 }*/
            skaitlis sk = new skaitlis();
            Console.WriteLine(sk.getNumber());
            skaitlis sk2 = new skaitlis();
            Console.WriteLine(sk2.getNumber());

            int i = 0;
            int o = 0;
            int sum =0;

            while (i <= 2 && o <= 2)
            {
                if (sk.getNumber() > sk2.getNumber())
                {
                    Console.WriteLine("Pirmais skaitlis bija liekaaks ");
                    i++;
                }
                else if (sk2.getNumber() > sk.getNumber())
                {
                    Console.WriteLine("Otrais skaitlis bija liekaaks ");
                    o++;
                }
                else
                {
                    Console.WriteLine("abi skaitli ir vienadi ");
                }
                Console.WriteLine(sk.regenerateNumber());
                Console.WriteLine(sk2.regenerateNumber());
            }
            Console.WriteLine("pirmie skaitli uzvareja =   " + i + " reizes");
            Console.WriteLine("otrie skaitli uzvareja =   " + o + " reizes");
            if (i >= 3)
            {
                Console.WriteLine("uzvareja pirmais random generators");
            }
            else
            {
                Console.WriteLine("uzvareja otrais random generators");
            }

        }
        static void piemers()
        {
            Example ex = new Example(4, 8);
            ex.print();
            int kautkadsMainigais = ex.getA();
        }
        static void aplis()
        {
            Aplis apl = new Aplis(ievade());
            apl.getLaukums();
            apl.print();
        }
        static double ievade()
        {
            Console.WriteLine("ievadiet radiusu! ");
            string iev = Console.ReadLine();
            int sk = Convert.ToInt32(iev);
            return sk;
        }
    }
}
