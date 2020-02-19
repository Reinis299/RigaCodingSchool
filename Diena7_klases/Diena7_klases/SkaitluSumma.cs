using System;
using System.Collections.Generic;
using System.Text;

namespace Diena7_klases
{
    public class SkaitluSumma
    {
        private static int a = 0;
        private static int b = 0;
        
        public static void setA(int par1)
        {
            a = par1;
        }

        public static int getA()
        {
            return a;
        }

        public static void setB(int par1)
        {
            b = par1;
        }

        public static int getB()
        {
            return b;
        }

        public static void Summa()
        {
            Console.WriteLine("Summa ir " + (a + b));
        }

    }
}
