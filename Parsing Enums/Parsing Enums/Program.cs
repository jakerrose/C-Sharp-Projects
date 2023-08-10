using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsing_Enums
{
    class Program
    {
        static void Main(string[] args)
        { 
            
            //prints question to console
            Console.WriteLine("Please enter today's day of the week.");
            //inputs user response as string dayOWeek
            string dayOweek = Console.ReadLine();
            
            //uses try catch method to see if user input matches enum member name
            try
            {
                //parses through memebers of Days, determines if it matches user variable dayOWeek, creates day string day
                Days day = (Days)Enum.Parse(typeof(Days), dayOweek);
                //prints newly created variable day if there is a match
                Console.WriteLine("Day of the week: " + day);
            }
            catch
            { //prints error message if there is no match
                Console.WriteLine("Please enter a valid day of the week.");
            }


            Console.ReadLine();
            
            

        }
        //creates public enum Days
        public enum Days
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
    }
}
