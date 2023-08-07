using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_and_Objects
{
    public class Program
    {
        public static void Main()
        {
            //instantiates class Employee. Gives values to properties FirstName and LastName
            Employee employees = new Employee() { FirstName="Sample ", LastName="Student" };
            //runs method SayName() inherited from Person
            employees.SayName();
            
            Console.ReadLine();

        }
    }
}
