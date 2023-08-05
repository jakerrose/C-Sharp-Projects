using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiates class
            Math4 math = new Math4();

            //passes arguments to the two parameters
            Math4.Method(50, 20);
            Console.ReadLine();

        }
    }
}
