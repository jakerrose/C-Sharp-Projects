using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Writes question for user to terminal
            Console.WriteLine("Please enter an integer to multiply 8 to.");
            //creates var a from user input
            int a = Convert.ToInt32(Console.ReadLine());
            //calls method Mult to act on user parameter a
            Math.Mult(a);
            Console.ReadLine();

            //Writes question for user to terminal
            Console.WriteLine("Please enter an integer to add 8 to.");
            //creates var b from user input
            int b = Convert.ToInt32(Console.ReadLine());
            //calls method Add to act on user parameter b
            Math.Add(b);
            Console.ReadLine();

            //Writes question for user to terminal
            Console.WriteLine("Please enter an integer to subtract 8 from.");
            //creates var c from user input
            int c = Convert.ToInt32(Console.ReadLine());
            //calls method Subt to act on user parameter c
            Math.Subt(c);
            Console.ReadLine();

        }
    }
}
