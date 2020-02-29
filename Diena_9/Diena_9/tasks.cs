using System;
using System.Collections.Generic;
using System.Text;

namespace Diena_9
{
    class tasks
    {
        // uztaisiit masiivu, kuram garumu ievada lietotajs
        // pectam lai lietotajs so masivu aizpilda ar izveletam vertibam 

        // int [], cilveks izvelas garumu
        public static void task1()
        {
            Console.WriteLine("ievadiet jusu velamo garumu masiivam! ");
            string ievade = Console.ReadLine();
            int input = Convert.ToInt32(ievade);

            int[] iev = new int [input];

            for (int i = 0; i < iev.Length; i++)
            {
                Console.WriteLine("ievadiet " + i + " elementu");
                string input2 = Console.ReadLine();
                iev[i] = Convert.ToInt32(input2);
            }

            for (int i = 0; i < iev.Length; i++)
            {
                Console.WriteLine(iev[i]+ " ") ;
            }
        }

        public static void task2()
        {
            // masivu ar 5 elementiem
            // string tipa 
            // 4us elementus aizpilda cilveks 
            // 5. elementa glabajas  abc, ce, o, qwerty, abcceoqwerty

            string[] iev = new string[5];

            for (int i = 0; i < iev.Length; i++)
            {
                Console.WriteLine("ievadiet " + (i+1) + " elementu");
                iev[i] = Console.ReadLine();
            }

            for (int i = 0; i < iev.Length; i++)
            {
                //Console.WriteLine(iev[i] + " ");
                iev[4] = iev[4] + iev[i];
                Console.WriteLine(iev[i]);
            }
        }

    }
}
