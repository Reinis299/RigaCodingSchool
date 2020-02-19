using System;
using System.Collections.Generic;
using System.Text;

namespace Diena_8_objekti
{
    class skaitlis
    {
        private int a;
        public skaitlis()
        {
            Random random = new Random();
            a = random.Next(1, 10);
        }
        public int getNumber()
        {
            return a;
        }
        public int regenerateNumber()
        {
            Random random = new Random();
            this.a = random.Next(1, 10);
            return a;
        }

    }
}
