using System;

namespace CSharpIntermediate
{
    public class Person
    {
        public string Name;
        public DateTime BirthDate { get; private set; }

        public Person(DateTime birthDate)
        {
            this.BirthDate = birthDate;
        }

        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - BirthDate;
                var years = timeSpan.Days / 365;
                return years;
            }
        }

        public void Introduce(string to)
        {
            Console.WriteLine($"Hi {to}, I am {Name}");
        }

        public static Person Parse(string str)
        {
            var person = new Person(DateTime.Now);
            person.Name = str;

            return person;
        }
    }
}
