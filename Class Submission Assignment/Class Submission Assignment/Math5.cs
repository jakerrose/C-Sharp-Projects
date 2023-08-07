using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Submission_Assignment
{
    //Creates new public class Math5
    public class Math5
    {
        //creates void method userMethod with one parameter
        public static void userMethod(int userNum)
            //Line that will be printed when method is called
        {
            Console.WriteLine("Your number divided by two is " + (userNum / 2));
        }
        //creates a second method with an output parameter
        public void returnValue(out int x)
        {
            //creates int datatype, assigns value to 10, assigns var name to x
            int num1 = 10;
            x = num1;
        }
        //creates method Addition with two parameters
        public int Addition(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
        //overloads the method by adding a third parameter on an already existing method
        public int Addition(int a, int b, int c)
        {
            int sum = a + b + c;
            return sum;
        }


    }
}
