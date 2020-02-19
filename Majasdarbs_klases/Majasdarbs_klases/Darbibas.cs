using System;
using System.Collections.Generic;
using System.Text;

namespace Majasdarbs_klases
{
    class Darbibas
    {
        private static double a = 0;
        private static double b = 0;

        public static void setSk1(double par1)
        {
            a = par1;
        }
        public static double getSk1()
        {
            return a;
        }
        public static void setSk2(double par1)
        {
            b = par1;
        }
        public static double getSk2()
        {
            return b;
        }
        public static double saskaitisana()
        {
            return a + b;
        }
        public static double atnemsana()
        {
            return a - b;
        }
        public static double reizinasana()
        {
            return a * b;
        }
        public static double dalisana()
        {
            return a / b;
        }
    }
}
