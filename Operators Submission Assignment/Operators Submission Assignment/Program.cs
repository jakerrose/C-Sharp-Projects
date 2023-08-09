using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Submission_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiates first object employee1, gives ID value 300
            Employee employee1 = new Employee() { ID = 300 };
            //passes argument to method
            employee1.printID();
            //instantiates second object employee2, gives ID value 301
            Employee employee2 = new Employee() { ID = 301 };
            employee2.printID();

            //if else statement using overloading the operator to check if values are equal
            if (employee1.ID == employee2.ID)
                Console.WriteLine("The employee IDs are identical.");
            else
                Console.WriteLine("The employee IDs are unique.");
            Console.ReadLine();
        }
    }
}
