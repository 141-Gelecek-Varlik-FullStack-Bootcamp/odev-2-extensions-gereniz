using System;

namespace Extensions
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 5;
            Console.WriteLine(i + " Dolar = " + Core.Extensions.DollarToLira(i) + " Lira");

            Console.WriteLine(Core.Extensions.GetEnumDisplayName(UserTypes.userType2));
        }
    }
}
