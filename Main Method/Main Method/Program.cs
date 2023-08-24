using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            //instatiated class
            Math2 math = new Math2();

            //creates variable x for answer to math problem
            int x=Math2.Div(8);
            Console.WriteLine(x);

            //creates variable y for answer to math problem
            int y =Math2.Mult(2.3m);
            Console.WriteLine(y);

            //creates variable z for answer to math problem
            int z =Math2.Add("4");
            Console.WriteLine(z);


            Console.ReadLine();
        }
        
     }
}
