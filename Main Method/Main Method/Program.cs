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
            Math2 math = new Math2();

            int x=Math2.Div(8);
            Console.WriteLine(x);

            int y=Math2.Mult(2.3m);
            Console.WriteLine(y);

            int z=Math2.Add("4");
            Console.WriteLine(z);

            Console.ReadLine();
        }
        
     }
}
