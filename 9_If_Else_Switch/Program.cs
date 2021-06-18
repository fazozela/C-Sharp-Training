using System;

namespace _9_If_Else_Switch
{

    class Program
    {
        static void Main(string[] args)
        {

            //** IF ELSE **
            bool isGoldCustomer = true;

            //One way
            /*
            float price;
            if (isGoldCustomer)
            {
                price = 19.95f;
            }
            else
            {
                price = 29.95f;
            }
            */

            //Better way
            float price = (isGoldCustomer) ? 19.95f : 29.95f;
            Console.WriteLine(price);


            //** SWITCH **
            var season = Season.Autumn;

            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("Ït is Autum");
                    break;

                case Season.Spring:
                case Season.Summer:
                    Console.WriteLine("Ït is Spring & Summer");
                    break;
            }


            //**EXERCISES

            //1.
            Console.WriteLine("Write a valid number: ");
            var validNumber = Console.ReadLine();

            var validNumberConverted = Convert.ToInt32(validNumber);

            var result = (validNumberConverted > 0 && validNumberConverted <= 10) ? $"The number {validNumber} is valid" : "Please enter a valid number";

            Console.WriteLine(result);

            //2.
            Console.WriteLine("First Number");
            var firstNumber = Console.ReadLine();
            var firstNumberConverter = Convert.ToInt32(firstNumber);

            Console.WriteLine("Second Number");
            var secondNumber = Console.ReadLine();
            var secondNumberConverter = Convert.ToInt32(secondNumber);

            var maximum = (firstNumberConverter > secondNumberConverter) ? $"{firstNumber} is the maximun" : $"{secondNumber} is the maximun";
            Console.WriteLine(maximum);

            //3
            Console.WriteLine("Width:");
            var width = Console.ReadLine();
            var widthConverter = Convert.ToInt32(width);

            Console.WriteLine("Hight:");
            var hight = Console.ReadLine();
            var hightConverter = Convert.ToInt32(hight);

            var size = (widthConverter > hightConverter) ? "LANDSCAPE" : "PORTRAIT";
            Console.WriteLine(size);

        }
    }
}
