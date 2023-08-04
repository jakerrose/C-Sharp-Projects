using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method
{
    //Created public class Math 2
    public class Math2
    {
        //method Dev will take in an integer and give an integer
        public static int Div(int a)
        {
            int answer = (a / 2);
            return answer;
        }

        //method Mult will take in a decimal and give an integer
        public static int Mult(decimal b)
        {
            //converts decimal type to int type
            int answer = Convert.ToInt32(b * 2); 
            return answer;
        }

        //method Add will take in a string and give an integer
        public static int Add(string c)
        {
            //converts string type to decimal
            int answer = Convert.ToInt32(c) + 5;
            return answer;
        }
    }
}
