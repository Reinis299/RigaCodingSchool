using System;
using System.Collections.Generic;
using System.Text;

namespace Diena_6_new
{
    class Tasks
    {
        private static int a = 0;
        private static int b = 0;
        // uztaisit divus privatus mainigos int
        // un uztaisiet ta, lai cilveks pieskir viniem vertibu 
        //Console.readline (ievadei) ir un notiek no program.cs klases
        // lai main vinus varetu izvadit
        //getA, setA
        public static void setA(int localA)
        {
            a = localA;
        }
        public static int getA()
        {
            return a;
        }
    }
}
