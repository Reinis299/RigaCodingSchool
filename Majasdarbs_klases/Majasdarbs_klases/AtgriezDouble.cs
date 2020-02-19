using System;
using System.Collections.Generic;
using System.Text;

namespace Majasdarbs_klases
{
    public class AtgriezDouble
    {
        public static double skaitlaIevade()
        {
            Console.WriteLine("Ievadiet skaitli!");
            String skaitlaIevade = Console.ReadLine();
            int skaitlis = Convert.ToInt32(skaitlaIevade);
            return skaitlis;
        }
    }
}
