using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods
{

    public class Math
    {
        public static int Mult(int a)
        {
            int result = (a * 8);
            Console.WriteLine(result);
            return result;    
        }

        public static int Add(int b)
        {
            int result = (b + 8);
            Console.WriteLine(result);
            return result;
        }

        public static int Subt(int c)
        {
            int result = (c - 8);
            Console.WriteLine(result);
            return result;
        }
    }
}
