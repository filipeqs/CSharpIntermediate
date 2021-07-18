using System;

namespace CSharpIntermediate
{
    public class Person
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine($"Hi {to}, I am {Name}");
        }

        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;

            return person;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var filipe = new Person() { Name = "Filipe" };
            filipe.Introduce("Mosh");

            var john = Person.Parse("John");
            john.Introduce(filipe.Name);
        }
    }
}
