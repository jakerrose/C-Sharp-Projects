using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    //public class Employee inherits class Person and interface IQuittable
    public class Employee : Person, IQuittable
    {
        //provides body of Quit() method
        public void Quit()
        {
            Console.WriteLine("I quit!");
        }
    }
}
