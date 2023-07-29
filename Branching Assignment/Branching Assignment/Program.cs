using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            //converts user inputted string to data type integer

            Console.WriteLine("Please enter the weight of your package in pounds to the nearest pound:");
            int pounds = Convert.ToInt32(Console.ReadLine());
            //if variable pounds is more than 50, will print message
            if (pounds > 50)
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");

            else
            //user will input info for width, height, and length of package
            {
            Console.WriteLine("Please enter the width of the package in inches to the nearest inch:"); }
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the height of the package to the nearest inch:");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the length of the package to the nearest inch:");
            int length = Convert.ToInt32(Console.ReadLine());

            //creates variables for total dimensions and volume of package
            int dimensions = (width * height * length);
            int total = (width + length + height);

            //program will end of variable total is larger than 50
            if (total > 50)
                Console.WriteLine("Package too big to be shipped via Package Express.");
            //if total is less than or equal to 50, the shipping cost will print based on the formula
            else
                Console.WriteLine("Your estimated shipping is $" + dimensions * pounds / 100 + ".00.");
            }
            Console.ReadLine();
        }
    }
