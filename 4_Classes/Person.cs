using System;

namespace _4_Classes
{
    class Person
    {
        public string firstName;
        public string lastName;

        public void Introduce()
        {
            Console.WriteLine("Hi my name is: " + firstName + " " + lastName);
        }
    }
}
