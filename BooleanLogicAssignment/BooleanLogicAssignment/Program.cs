using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogicAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write name of program
            Console.WriteLine("Car Insurance Approval Program");
            //takes user input as int data type, converts to variable userAge
            Console.WriteLine("What is your age?");
            int userAge = Convert.ToInt32(Console.ReadLine());

            //takes boolean true or false input, converts to variable result
            Console.WriteLine("Have you ever had a DUI? Please enter True or False.");
            bool result = Convert.ToBoolean(Console.ReadLine());
            
            //takes user input as int data type, converts to variable userTickets
            Console.WriteLine("How many speeding tickets have you had?");
            int userTickets = Convert.ToInt32(Console.ReadLine());

            //checks if age is over or equal to 15, if user has 3 or less tickets, if they have no DUI. If all are true, they are qualified.
            Console.WriteLine("Are you qualified for car insurance?");
            bool qualified = (userAge >= 15 && userTickets <= 3 && result==false);
            Console.WriteLine(qualified);
            Console.ReadLine();
        }
    }
}
