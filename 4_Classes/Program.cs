using _4_Classes.Math;
using System;

namespace _4_Classes
{

    class Program
    {
        static void Main(string[] args)
        {
            var fazo = new Person();
            fazo.firstName = "Felix Alejandro";
            fazo.lastName = "Zelaya Orellana";
            fazo.Introduce();

            Calculator cassio = new Calculator();
            var ResultAdd = cassio.Add(5, 4);
            Console.WriteLine($"The result of the operation is: {ResultAdd}");
        }
    }
}
