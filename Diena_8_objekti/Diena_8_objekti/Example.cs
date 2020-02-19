using System;
using System.Collections.Generic;
using System.Text;

namespace Diena_8_objekti
{
    class Example
    {
            //konstruktors
            private int a;
            private int b;
        public Example(int a, int b)
        {
            this.a = 0;
            this.b = 0;
        }

        public void print()
        {
            Console.WriteLine("a = " + a + "b = " + b);
        }

        public void setA (int a)
        {
            this.a = a;
        }
        public int getA()
        {
            return a;
        }
        private void privatePrint()
        {
            Console.WriteLine("Sito publiski nevar");
        }
    }
}
