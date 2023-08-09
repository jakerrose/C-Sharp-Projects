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
            //instatiates IQuittable, creates new variable employees
            IQuittable employees = new Employee();
            //calls Quit() method from class Employee
            employees.Quit();
            Console.ReadLine();
        }
    }
}
