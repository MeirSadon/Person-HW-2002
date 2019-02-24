using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_2002
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons =
        {
            new Person(2, 25, 1.89f, "a"),
            new Person(1, 32, 1.92f, "c"),
            new Person(4, 12, 1.20f, "d"),
            new Person(5, 65, 2.1f, "z"),
            new Person(3, 55, 3f, "t")
        };
            PrintPersonArray(persons);
            Array.Sort(persons, PersonCompareById);
        }
        static void PrintPersonArray(Person[] person)
        {
            foreach (Person per in person)
            {
                Console.WriteLine(per);
            }
        }
    }
}
