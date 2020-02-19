using System;
using System.Collections.Generic;
using System.Text;

namespace Diena7_klases
{
    public class Students
    {
        private String name;
        private String surname;
        private int course;
        private int year;

        public Students(String name, String surname, int course, int year)
        {
            this.name = name;
            this.surname = surname;

            if (course > 3)
            {
                this.course = 3;
            }
            else if (course < 1)
            {
                this.course = 1;
            }
            else
            {
                this.course = course;
            }

            this.year = year;
        }

        public void print()
        {
            Console.WriteLine("Vards- " + name);
            Console.WriteLine("Uzvards- " + surname);
            Console.WriteLine("Kurss- " + course);
            Console.WriteLine("Iestasanas gads- " + year);

            Console.WriteLine();
        }
    }
}
