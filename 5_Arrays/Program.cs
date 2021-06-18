using System;

namespace _5_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var numeros = new int[3];
            numeros[0] = 1;

            Console.WriteLine(numeros[0]);
            Console.WriteLine(numeros[1]);
            Console.WriteLine(numeros[2]);


            var banderas = new bool[3];
            banderas[0] = true;

            Console.WriteLine(banderas[0]);
            Console.WriteLine(banderas[1]);
            Console.WriteLine(banderas[2]);

            var nombres = new string[3] { "Jack", "Marina", "Felix" };

            Console.WriteLine(nombres[0]);
            Console.WriteLine(nombres[1]);
            Console.WriteLine(nombres[2]);

        }
    }
}
