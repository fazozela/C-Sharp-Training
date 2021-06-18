using System;

namespace _8_Ref_Val_Types
{
    public class Person
    {
        public int age;
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Value Type
            var a = 10;
            var b = a;
            b++;
            Console.WriteLine($"{a},{b}");

            //Reference Type
            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 0;
            Console.WriteLine($"{array1[0]},{array2[0]}");


            //ANOTHER EXAMPLE MORE EXPLICIT
            var number = 1;
            Increment(number);
            Console.WriteLine(number);
            /*Note that it returns 1 
             * not 11, that is because, a value type
             * maked a copy of number when the
             * parameter is called by the function
             */

            var ale = new Person();
            ale.age = 27;
            MakeOld(ale);
            Console.WriteLine(ale.age);
            /*Note this works this incremented de value
             * because is a refere4ncer type and it
             * REFERENCE, does not make a copy
             */

        }

        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(Person person)
        {
            person.age += 10;

        }

    }
}
