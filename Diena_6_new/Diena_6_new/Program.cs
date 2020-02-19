using System;

namespace Diena_6_new
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExampleClass.test();
            Console.WriteLine(Tasks.getA());
            Console.WriteLine("ievadiet skaitli");
            String input = Console.ReadLine();
            int skaitlis = Convert.ToInt32(input);

            Tasks.setA(skaitlis);
            Console.WriteLine(Tasks.getA());

        }
    }
}
