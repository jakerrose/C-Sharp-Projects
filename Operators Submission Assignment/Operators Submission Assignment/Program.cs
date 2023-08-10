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

            //uses bool operator, writes true or false for the two comparisons
            Console.WriteLine(employee1 == employee2);
            Console.WriteLine(employee1 != employee2);
            Console.ReadLine();
        }
    }
}
