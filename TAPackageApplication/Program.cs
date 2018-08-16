using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAPackageApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("What is the weight of your package?");
            int weight = Convert.ToInt32(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package is too heavy to be shipped via Package Express. Have a good day.");
                Console.Read();
                return;
            }
            Console.WriteLine("What is the width of your package?");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("And the height?");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("And what about the length?");
            int length = Convert.ToInt32(Console.ReadLine());
            int dimensions = width + height + length;
            if (dimensions > 50)
            {
                Console.WriteLine("Package is too big to be shipped via Package Express.");
                Console.Read();
                return;
            }
            decimal total = Convert.ToDecimal(dimensions / 100.m);
            Console.WriteLine("$" + total);
            Console.Read();
        }
    }
}
