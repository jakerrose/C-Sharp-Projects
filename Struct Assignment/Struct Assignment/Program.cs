using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //instatiates struct Number
            Number numbers = new Number();
            //gives value to object numbers.Amount
            numbers.Amount = 1.5m;
            //prints value to console
            Console.WriteLine(numbers.Amount);

            Console.ReadLine();
           
        }
    }
 
}
