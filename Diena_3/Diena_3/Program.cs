using System;

namespace Diena_3
{
    class Program
    {
        static void Main(string[] args)
        {

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
    }
}
