using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Submission_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //instatiates the class
            Math5 math = new Math5();
            //prints instructions to user    
            Console.WriteLine("Please enter an integer.");
            //creates new int datatype variable userNum from user input
            int userNum = Convert.ToInt32(Console.ReadLine());
            //passes int userNum through method userMethod
            Math5.userMethod(userNum);
            Console.ReadLine();

            //creates local variable
            int b = 100;
            //prints value of variable before method call
            Console.WriteLine("Before method call, value of b: {0}", b);
            //passes variable through method
            math.returnValue(out b);
            //prints value of variable after method call
            Console.WriteLine("After method call, value of b: {0}", b);
            Console.ReadLine();

            //passes the arguments to the method Addition
            int sum1 = math.Addition(1, 2);
            Console.WriteLine("Sum of the two numbers: " + sum1);

            //passes three arguments to the overloaded method
            int sum2 = math.Addition(1, 2, 3);
            Console.WriteLine("Sum of the three numbers: " + sum2);
            Console.ReadLine();
        }
    }
}
