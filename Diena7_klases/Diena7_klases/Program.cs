using System;

namespace Diena7_klases
{
    class Program
    {
        static void Main(string[] args)
        {

            task3();
            //objEx1();



        }

        static void task1()
        {
            //uztaisat jaunu klasi ar nosaukumu SkaitluSumma
            //Cilveks ievada 2 int tipa skaitlus no main
            //uztaisat, get,set, un lai butu publiska metode, kas izvada
            //abu skaitlu summu
            //abiem skaitliem ir jabut pieejamiem visa SkaitluSumma klasē
            //bet no Program.cs klases tikai ar get un set.
            int sk1 = skaitlaIevade();
            int sk2 = skaitlaIevade();

            SkaitluSumma.setA(sk1);
            SkaitluSumma.setB(sk2);

            SkaitluSumma.Summa();

        }

        static void task2()
        {

            //Klases nosaukums ir trijsturis
            //Cilveks ievada 3 malu vertibas - mainigie jaunaja klase
            //Metodi, kas izvada perimetru mala + mala + mala
            //visa ievade un izvade notiek no main- WriteLine un ReadLine
            //ja kada mala ir 0, par to ir japazino
            int mala1 = skaitlaIevade();
            int mala2 = skaitlaIevade();
            int mala3 = skaitlaIevade();

            Trijsturis.setMala1(mala1);
            Trijsturis.setMala2(mala2);
            Trijsturis.setMala3(mala3);
            //1. variants
            int perimetrs = Trijsturis.perimetrs();
            if (perimetrs > 0)
            {
                Console.WriteLine("Perimetrs ir " + perimetrs);
            }
            else
            {
                Console.WriteLine("Kluda!");
            }

            //2. varints
            Console.WriteLine(Trijsturis.perimetrs2());

        }

        static int skaitlaIevade()
        {
            Console.WriteLine("Ievadiet skaitli!");
            String skaitlaIevade = Console.ReadLine();
            int skaitlis = Convert.ToInt32(skaitlaIevade);
            return skaitlis;
        }

        static void objEx1()
        {
            ObjExample obj = new ObjExample(0, 0);
            obj.setA(1);
            obj.setB(2);
            obj.print();

            obj.setA(5);
            obj.print();

            ObjExample obj2 = new ObjExample(0, 0);
            obj2.print();

            ObjExample obj3 = new ObjExample(3, 7);
            obj3.print();
        }



        static void task3()
        {
            //jauna klase- TrijsturisObj
            //metodes no klases Trijsturis.cs

            //uztaisit 2 trijsturi-
            TrijsturisObj tr1 = new TrijsturisObj(1, 2, 3);
            Console.WriteLine(tr1.perimetrs2());


            TrijsturisObj tr2 = new TrijsturisObj(0, 2, 0);
            Console.WriteLine(tr2.perimetrs2());
            //vienu ar pareizam malu vertibam
            //otru, kur divas malas ir 0
        }

        static void task4()
        {
            //Klase ar nosaukumu Students
            //Klase konstruktors ar paremetriem
            //Vards,Uzvards,Kurss, iestasanas gads

            Students st1 = new Students("Janis", "Berzins", 3, 2017);
            Students st2 = new Students("Juris", "Abele", -76, 2017);

            st1.print();
            st2.print();
            //print() izvada visu informaciju
            //Kurss- 1 lidz 3
            //Ja ir vairak par 3 tad iestatam 3
            //Ja ir mazak par 1 tad iestatam 1

            //uztaisit 2 testa objektus
        }
    }
}
