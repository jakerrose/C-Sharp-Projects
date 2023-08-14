using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Input_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {   //console asks for number, can be string since no operations are being done, creates string data type
            Console.WriteLine("Please enter a number.");
            string num1 = Console.ReadLine();
            //prints number to console
            Console.WriteLine("Your number is " + num1);
            //logs number to separate text file
            File.WriteAllText(@"C:\Users\rosej\log1.txt", num1);
            
            Console.ReadLine();
        }
    }
}
