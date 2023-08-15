using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Date_Time_submission
{
    class Program
    {
        static void Main(string[] args)
        {
            //writes to console the current date and time using built in method DateTime.Now
            Console.WriteLine("The current date and time is " + DateTime.Now);
            //asks user for a number, converts string to int and creates new variable
            Console.WriteLine("Please enter a number.");
            int userNum = Convert.ToInt32(Console.ReadLine());
            //creates variable to represent DateTime.Now
            DateTime today = DateTime.Now;
            //uses built in method AddHours and inputs user number to add hours to current date and time
            DateTime future = today.AddHours(userNum);
            //prints result to console
            Console.WriteLine("The current date and time plus your number in hours is " + future);

            Console.ReadLine();
        }
    }
}
