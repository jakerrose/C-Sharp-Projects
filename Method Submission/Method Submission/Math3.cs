using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Submission
{
    //creates public class Math3
    public class Math3
    {
        //creates method Math with two parameters, one optional
        public static int Math(int a, int b=20)
        {
            //code to use inside method
            int solution = (a * 42 + b);
            return solution;
        }
    }
}
