using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_2002
{
    class Person : IComparable<Person>
    {
        public int Id { get; private set; }
        public int Age { get; private set; }
        public float Height { get; private set; }
        public string Name { get; private set; }

        static readonly Comparer<Person> _idComparer;
        static readonly Comparer<Person> _ageComparer;
        static readonly Comparer<Person> _heightComparer;
        static readonly Comparer<Person> _nameComparer;

        public static IComparer<Person> IdComparer { get; }
        public static IComparer<Person> AgeComparer { get; }
        public static IComparer<Person> HeightComparer { get; }
        public static IComparer<Person> NameComparer { get; }

        private static IComparer<Person> DefaultComparer;

        public Person(int id, int age, float height, string name)
        {
            Id = id;
            Age = age;
            Height = height;
            Name = name;
        }
        static Person()
        {

        }
        public static void ModifyDefaultComparer(string s)
        {

        }
        public static IComparer<Person> GetDefaultComparer()
        {

        }
        public override string ToString()
        {
            return $"Id: {Id} Age: {Age} Height: {Height} Name: {Name}";
        }

        public int CompareTo(Person other)
        {
            return this.Id - other.Id;
        }
    }
}