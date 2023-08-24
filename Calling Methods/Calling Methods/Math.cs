using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods
{
    //Creates public class Math
    public class Math
    {
        //creates method Mult() which is public and static. 
        public static int Mult(int a)
        {
            //variable result is assigned to data type result. Method will multiply 8 to user input a
            int result = (a * 8);
            Console.WriteLine(result);
            return result;    
        }
        //creates method Add() which is public and static. 
        public static int Add(int b)

        //variable result is assigned to data type result. Method will add 8 to user input b
        {
            int result = (b + 8);
            Console.WriteLine(result);
            return result;
        }

        //creates method Subt() which is public and static. 
        public static int Subt(int c)
        //variable result is assigned to data type result. Method will subtract 8 from user input c
        {
            int result = (c - 8);
            Console.WriteLine(result);
            return result;
        }
    }
}
