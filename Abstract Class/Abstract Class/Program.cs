using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            //instatiates Employee, creates new variable employees, populates properties with string input
            Employee employees = new Employee() { FirstName = "Sample ", LastName = "Student" };
            //calls method
            employees.SayName();
            Console.ReadLine();
        }
    }
}
