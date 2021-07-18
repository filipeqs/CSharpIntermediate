using System;

namespace CSharpIntermediate
{
    public class Person
    {
        public string Name;
        public DateTime BirthDate { get; set; }

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
}
