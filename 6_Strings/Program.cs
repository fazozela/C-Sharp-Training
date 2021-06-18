using System;

namespace _6_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstname = "Marina";
            var lastname = "Vega";
            
            //One way
            var fullName = firstname + " " + lastname;

            //Another way
            var fullName2 = string.Format("My name is: {0} {1}", firstname, lastname);

            //Another way Using Join
            var names = new string[] { "Felix", "Norma" };
            var joinedNames = string.Join("-", names);

            Console.WriteLine(fullName);
            Console.WriteLine(fullName2);
            Console.WriteLine(joinedNames);

            /*NOTE 
             * Be aware of the scape characters
             * \n, new line
             * \t, tab
             * \\, backslash
             * \', single quotation mark
             * \", double quotation mark
             */
            
        }
    }
}
