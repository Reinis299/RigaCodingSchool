using System;

namespace Diena_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //lielakais();
            //task2();
            //task3();
            //task4();
            //task5();
            task6();
        }
        static void lielakais()
        {
            int biggest = Int32.MinValue;
            for (int i = 0; i<6; i++)
            {
                int currentnumber = skaitlaIevade("skaitli");
                if(currentnumber > biggest)
                {
                    biggest = currentnumber;
                }
            }
            Console.WriteLine(biggest);
        
        }
        static void task2()
        {
            Console.WriteLine("Ievadiet gradus pec farenheita ");
            string input = Console.ReadLine();
            double gradiF = Convert.ToDouble(input);
            double gradiC = (gradiF - 32) * 5 / 9;
            Console.WriteLine("gradi pec celsija: " + gradiC);
        }
        static void task3()
        {
            int w = skaitlaIevade("platumu");
            int h = skaitlaIevade("augstumu");

            for (int i = 0; i<h; i++)
            {
                for (int j = 0; j<w; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
        static void task4()
        {
            string input = "";
            do
            {
                Console.WriteLine("Ievadiet frazi");
                input = Console.ReadLine();
            } while (input.Contains("zirgs") || input.Contains("suns"));
        }

        static void task5()
        {
            Console.WriteLine("ievadiet minamo vardu! ");
            string minamais = Console.ReadLine();

            Console.Clear();

            for (int i = 5; i > 0; i--)
            {
                Console.WriteLine("ievadiet vardu. Vel palikusi " + i + " meginajumi");
                Console.WriteLine("varda garums ir " + minamais.Length);

                string ievade = Console.ReadLine();
                if(ievade == minamais)
                {
                    Console.WriteLine("uzvar otrais speletajs");
                    break;
                }
                if(ievade!=minamais && i == 1)
                {
                    Console.WriteLine("Uzvar pirmais speletajs");
                }
            }
        }
        static void task6()
        {
            Console.WriteLine("ievadiet savu vardu");
            String vards = Console.ReadLine();

            Console.WriteLine("Sveiks, " + vards);
        }

        static int skaitlaIevade(string vertiba)
        {
            Console.WriteLine("Ievadiet " + vertiba);
            String input = Console.ReadLine();
            int ievade1 = Convert.ToInt32(input);
            return ievade1;
        }
    }
}
