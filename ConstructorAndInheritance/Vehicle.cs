using System;

namespace ConstructorAndInheritance
{
    public class Vehicle
    {
        private string RegistrationNumber { get; }

        public Vehicle(string registrationNumber)
        {
            RegistrationNumber = registrationNumber;

            Console.WriteLine("Vehicle is being initialized {0}", RegistrationNumber);
        }
    }
}
