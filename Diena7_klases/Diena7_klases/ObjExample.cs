using System;
using System.Collections.Generic;
using System.Text;

namespace Diena7_klases
{
    public class ObjExample
    {
        private int a;
        private int b;

        public ObjExample(int localA, int b)
        {
            a = localA; //1. veids
            this.b = b; //2. veids
        }

        public void setA(int par1)
        {
            a = par1;
        }

        public int getA()
        {
            return a;
        }

        public void setB(int par1)
        {
            b = par1;
        }

        public int getB()
        {
            return b;
        }

        public void print()
        {
            Console.WriteLine("a = " + a + "b = " + b);
        }
    }
}
