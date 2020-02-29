using System;
using System.Collections.Generic;
using System.Text;

namespace Majasdarbs_masivi
{
    class Tasks
    {
        public static void task1()
        {
            String[] mas = new String[4];

            for (int i = 0; i < 3; i++)
            {
                Console.Write("#");
                for (int a = 0; a < 3; a++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }

    }
}
