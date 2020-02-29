using System;

namespace Diena_10_masivi
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 12;
            int c = a;
            a = b;
            b = c;
            //task1();
            //bubbleSort();
            SelectionSort();
        }

        static void task1()
        {
            // bubble sort - sarindo 10 ievaditos masivus augosa kartibaa
            // https://stackoverflow.com/questions/14768010/simple-bubble-sort-c-sharp
            int[] skaitli = new int[10];

            for (int i = 0; i < skaitli.Length; i++)
            {
                Console.WriteLine("Ievadiet " + (i + 1) + ". elementu");
                skaitli[i] = Convert.ToInt32(Console.ReadLine());
            }
            int temp = 0;

            for (int write = 0; write < skaitli.Length; write++)
            {
                for (int sort = 0; sort < skaitli.Length - 1; sort++)
                {
                    if (skaitli[sort] > skaitli[sort + 1])
                    {
                        temp = skaitli[sort + 1];
                        skaitli[sort + 1] = skaitli[sort];
                        skaitli[sort] = temp;
                    }
                }
                //Console.Write("{0} ", skaitli[write]);
            }
            for (int i = 0; i < skaitli.Length; i++)
                Console.Write(skaitli[i] + " ");

            //Console.ReadKey();
        }
        static void bubbleSort()
        {
            int[] skaitli = new int[1000];

            for (int i = 0; i < skaitli.Length; i++)
            {
                skaitli[i] = genRandom();
                Console.WriteLine(genRandom());
                //Console.WriteLine((i + 1) + ". elements------->" + genRandom());
                //skaitli[i] = Convert.ToInt32(Console.ReadLine());
            }
            //int temp = 0;

            for (int write = 0; write < skaitli.Length; write++)
            {
                for (int sort = 0; sort < skaitli.Length - 1; sort++)
                {
                    if (skaitli[sort] > skaitli[sort + 1])
                    {
                        int temp = skaitli[sort + 1];
                        skaitli[sort + 1] = skaitli[sort];
                        skaitli[sort] = temp;
                    }
                }
                //Console.Write("{0} ", skaitli[write]);
            }
            for (int i = 0; i < skaitli.Length; i++)
                Console.Write(skaitli[i] + " ");
        }
        static void SelectionSort()
        {
            //laiks();
            int[] skaitli = new int[1000];
            for (int i = 0; i < skaitli.Length; i++)
            {
                skaitli[i] = genRandom();
                Console.WriteLine(genRandom());
            }
            int temp, smallest;
            for (int i = 0; i < skaitli.Length - 1; i++)
            {
                smallest = i;
                for (int j = i + 1; j < skaitli.Length; j++)
                {
                    if (skaitli[j] < skaitli[smallest])
                    {
                        smallest = j;
                    }
                }
                temp = skaitli[smallest];
                skaitli[smallest] = skaitli[i];
                skaitli[i] = temp;
            }
            Console.WriteLine();
            Console.Write("Saskirots : ");
            for (int i = 0; i < skaitli.Length; i++)
            {
                Console.Write(skaitli[i] + " ");
            }
            Console.WriteLine();
            //laiks();
        }
        public static int genRandom()  
        {
            int skaitlis = 0; 
            Random random = new Random();
            skaitlis = random.Next(1, 10);
            return skaitlis;
        }
        public static void laiks()
        {
            DateTime now = DateTime.Now;
            now.ToString("F");
            Console.WriteLine("Hour: {0}", now.Hour);
            Console.WriteLine("Minute: {0}", now.Minute);
            Console.WriteLine("Second: {0}", now.Second);
            Console.WriteLine("Millisecond: {0}", now.Millisecond);
        }
    }
}
