using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Submission_Assignment
{
    //creates public class Employee
    public class Employee
    {
        //creates three properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }

        //creates public void method to intake and display ID numbers
        public void printID()
        {
            Console.WriteLine("ID number is: " + ID);
        }
    }
}
