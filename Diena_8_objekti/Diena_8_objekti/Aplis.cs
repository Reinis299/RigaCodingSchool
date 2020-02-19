using System;
using System.Collections.Generic;
using System.Text;

namespace Diena_8_objekti
{
    class Aplis
    {
        private double a;
        public Aplis(double a)
        {
            this.a = a;
        }
        public double laukums()
        {
            return a * a * 3.14;
        }
        public void getLaukums()
        {
            Console.WriteLine("rinka laukums ir: " + laukums());
        }
        public void print()
        {
            Console.WriteLine("rinka laukums ir: " + laukums());
            Console.WriteLine("Radiuss ir : " + a);
        }
    }
}
