using System;
using System.Collections.Generic;
using System.Text;

namespace Majasdarbs_klases
{
    class Aplis
    {
        
        public static double RinkaLinija()
        {
            Console.WriteLine("Ievadiet Rinka linijas radiusu!");
            String skaitlaIevade = Console.ReadLine();
            int radiuss = Convert.ToInt32(skaitlaIevade);
            return radiuss;
        }

        private static double a = 0;
        public static void setRadiuss(double rad1)
        {
            a = rad1;
        }
        public static void print()
        {
            Console.WriteLine("rinka laukums ir: " + (a * 2) * 3.14);
            Console.WriteLine("Radiuss ir : " + a);
        }

    }
}
