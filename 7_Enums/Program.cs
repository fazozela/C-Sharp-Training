using System;

namespace _7_Enums
{
    public enum ShippingMethod
    {
        //
        RegularAirMail = 1,
        RegisteredAirmail = 2,
        Express = 1
    }
    class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);

            //In case you recieve the ShippingMethod
            var methodId = 2;
            Console.WriteLine((ShippingMethod)methodId);

            //Convert to string
            Console.WriteLine(method.ToString());

            //Parsing, is getting a string and convert it to a number
            var methodName = "Express";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
        }
    }
}
