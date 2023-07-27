using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            //Uses Console.ReadLine() method to get input from user and saves those as variables. Converts string to double data type.
            Console.WriteLine("Person one: What is your hourly rate?");
            double rateOne = Convert.ToDouble(Console.ReadLine()); 
            Console.WriteLine("Your hourly rate is $" + rateOne + ". Please press enter.");
            Console.ReadLine();
            Console.WriteLine("Person one: How many hours have you worked this weeK?");
            double hoursOne = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("You worked " + hoursOne + " hours this week. Please press enter.");
            Console.ReadLine();
            double sumOne = rateOne * hoursOne * 52;
            Console.WriteLine("The annual salary of Person one is $" + sumOne + ". Please press enter.");
            Console.ReadLine();

            //Uses Console.ReadLine() method to get input from user and saves those as variables. Converts string to double data type.
            Console.WriteLine("Person two: What is your hourly rate?");
            double rateTwo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Your hourly rate is $" + rateTwo + ". Please press enter.");
            Console.ReadLine();
            Console.WriteLine("Person two: How many hours have you worked this weeK?");
            double hoursTwo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("You worked " + hoursTwo + " hours this week. Please press enter.");
            Console.ReadLine();
            double sumTwo = rateTwo * hoursTwo * 52;
            Console.WriteLine("The annual salary of Person two is $" + sumTwo + ". Please press enter.");
            Console.ReadLine();

            //Uses bool data type to do comparison on two sums
            bool isGreater = sumOne > sumTwo;
            Console.WriteLine("Person one makes more money than Person two: " + isGreater);
            Console.ReadLine();




        }
    }
}
