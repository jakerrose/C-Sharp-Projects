using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiates method Math3
            Math3 math = new Math3();

            //creates new var x, runs number 4 in method
            int x = Math3.Math(4);
            Console.WriteLine(x);
            Console.ReadLine();
            //asks user for number
            Console.WriteLine("Please enter a number and press enter.");
            //takes user input and coverts to int data type, creates var userNum1
            int userNum1 = Convert.ToInt32(Console.ReadLine());
            //asks user for second number
            Console.WriteLine("Please enter in a second number if you like and press enter.");
            
            
            //trys if user inputs second argument
            try
            {   //takes second number, converts to int data type, creates another var userNum2
                int userNum2 = Convert.ToInt32(Console.ReadLine());
                int z = Math3.Math(userNum1, userNum2);
                Console.WriteLine(z);
            }
            //if only one argument is present, will run through catch. Second user input will become default value
            catch
            {
               int y= Math3.Math(userNum1);
                Console.WriteLine(y);
            }

            Console.ReadLine();
        }
    }
}
