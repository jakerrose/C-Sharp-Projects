using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //instatiates Employee, creates new variable employees
            Employee employees = new Employee();
            //calls Quit() method from class Employee
            employees.Quit();
            Console.ReadLine();
        }
    }
}
