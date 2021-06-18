using System;

namespace _1_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring variables on C#


            //** Primitive variables **

            //Integral Numbers
            byte numero_1;      //1 Byte,   0 - 255
            short numero_2;     //2 Bytes,  -32768 - 32767
            int numero_3;       //4 Bytes,  -2.1B - 2.1B
            long numero_4;      //8 Bytes

            //Real Numbers
            float numero_5;     //4 Bytes, -3.4E38 - 3.4E38
            double numero_6;    //8 Bytes
            decimal numero_7;   //16 Bytes, -7.9E28 - 7.9E28
            /*NOTE, for declaring this types use terms 'f', 'd', 'm' at the end*/

            //Character
            char letra;         //2 Bytes, Unicode Character

            //Boolean
            bool condicion;     //1 Byte, True / False


            //** OTHER VARIABLES**//
            /* string, array, enum, class*/

            //Constants
            // To define a constant you just write 'const'

            //IMPORTANT, Be aware of oveflowing - almost never applicable
        }
    }
}
