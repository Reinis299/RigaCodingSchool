using System;

namespace Majasdarbs_klases
{
    class Program
    {
        static void Main(string[] args)
        {
            //task1();
            task2();
        }

        static void task1()
        {
            double pirmais = AtgriezDouble.skaitlaIevade();
            double otrais = AtgriezDouble.skaitlaIevade();
            Darbibas.setSk1(pirmais);
            Darbibas.setSk2(otrais);
            Console.WriteLine("Ja velaties saskaitit, nospiediet 1");
            Console.WriteLine("Ja velaties atnemt, nospiediet 2");
            Console.WriteLine("Ja velaties reizinat, nospiediet 3");
            Console.WriteLine("Ja velaties dalit, nospiediet 4");

            String izvelesSkaitlis = Console.ReadLine();
            int izvele = Convert.ToInt32(izvelesSkaitlis);
            if(izvele == 1)
            {
                Console.WriteLine("skaitlu summa ir : " + Darbibas.saskaitisana());
            }
            if (izvele == 2)
            {
                Console.WriteLine("Skaitlu stapiba ir : " + Darbibas.atnemsana());
            }
            if (izvele == 3)
            {
                Console.WriteLine("skaitlu reizinajums ir : " + Darbibas.reizinasana());
            }
            if (izvele == 4)
            {
                Console.WriteLine("skaitlu dalijums ir : " + Darbibas.dalisana());
            }

        }
        static void task2()
        {
            double Rlinija = Aplis.RinkaLinija();
            Aplis.setRadiuss(Rlinija);
            Aplis.print();
        }

    }
}
