using System;

namespace Diena_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // ievada 3 skaitlus - int 
            // izvada lielaako no 3 skatliem 
            Console.WriteLine("Ievdiet triis skaitlus");
            String num1 = Console.ReadLine();
            String num2 = Console.ReadLine();
            String num3 = Console.ReadLine();
            double newNr1 = Convert.ToDouble(num1);
            double newNr2 = Convert.ToDouble(num2);
            double newNr3 = Convert.ToDouble(num3);
            
            if(newNr1 >= newNr2 && newNr1>=newNr3)
            {
                Console.WriteLine("lielaakais skaitlis ir: " + newNr1);
            }
            else if (newNr2 >= newNr1 && newNr2 >= newNr3)
            {
                Console.WriteLine("lielaakais skaitlis ir: " + newNr2);
            }
            else if (newNr3 >= newNr1 && newNr3 >= newNr2)
            {
                Console.WriteLine("lielaakais skaitlis ir: " + newNr3);
            }
            if(newNr1 == newNr2 && newNr2 == newNr3)
            {
                Console.WriteLine("skaitli ir vienaadi");
            }
        }
        static void piemersZarosanas()
        {
            int a = 5;
            int b = 6;
            // && 
            // jaizpildas abiem
            if (a > 5 && b == 6)
            {

            }
            else
            {

            }
            // || "or"
            // jaizpildas vienam 
            if (a > 5 || b == 6)
            {

            }
            int skaitlis = 5;
            // #
            // ## 
            // >5, <5, ==5
            if (skaitlis > 5)
            {
                Console.WriteLine("#");
            }
            else if (skaitlis < 5)
            {
                Console.WriteLine("##");
            }
            else
            {
                Console.WriteLine("###");
            }
            // gadijums ar vairakiem salidzinamajiem
            // and ir viens nosacijums. vai izpildas visi &&, vai arī tikai viens or. 
            int c = 7;

            if (a > 5 && b < 7 && c == 7 || a > 9)
            {

            }
        }
        static void kalkulators()
        {
            // kalkulators 
            // cilveks ievada divus skaitlus
            // cilveks ievada ko vins grib darit. saskaitit, atnemt, reizinaat, daliit
            // izvada rezultaatu
            // convert.toDouble();
            // ja cilveks ka darbibu ievada ko citu, nevis int, tad pazino ar kludu 
            Console.WriteLine("Ievdiet divus skaitlus");
            String num1 = Console.ReadLine();
            String num2 = Console.ReadLine();
            double newNr1 = Convert.ToDouble(num1);
            double newNr2 = Convert.ToDouble(num2);
            Console.WriteLine("ja velaties saskaitit, ievadiet '1', ja atnemt '2', ja reizinat '3', ja daliit '4'");
            string var1 = Console.ReadLine();
            if (var1 == "1")
            {
                Console.WriteLine(newNr1 + newNr2);
            }
            else if (var1 == "2")
            {
                Console.WriteLine(newNr1 - newNr2);
            }
            else if (var1 == "3")
            {
                Console.WriteLine(newNr1 * newNr2);
            }
            else if (var1 == "4")
            {
                Console.WriteLine(newNr1 / newNr2);
            }
            else
            {
                Console.WriteLine("ievadiet izveelnes skaitli! ");
            }
        }
    }
}
