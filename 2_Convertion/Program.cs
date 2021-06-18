using System;

namespace _2_Convertion
{
    class Program
    {
        static void Main(string[] args)
        {
            //IMPLICIT CONVERSION
            byte numero_1 = 2;
            int numero_2 = numero_1;
            Console.WriteLine(numero_1);

            //EXPLICIT CONVERSION
            int numero_3 = 3;
            byte numero_4 = (byte)numero_3;
            /*Note with this one we have to be
             very carefull of the sizing*/

            //NON COMPATIBLE TYPES
            var numero_5 = "1234";
            /*Quick Note, if we want to cast explicity
             * int x = int(numero_5);
             * we cant because they are diferent types
             * So, we need to use a Convert o Parse function
             * like above
             */
            int numero_6 = Convert.ToInt32(numero_5);

            //But...this is risky, so we have to checked before a disaster happens like this
            try
            {
                var numero_7 = "9876";
                byte numero_8 = Convert.ToByte(numero_7);
            }
            catch (Exception)
            {
                Console.WriteLine("Could not convert to Byte, not the same size");
            }

        }
    }
}
