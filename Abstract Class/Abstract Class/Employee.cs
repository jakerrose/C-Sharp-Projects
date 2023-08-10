using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    //creates new class Employee. Inherits from Person class
    public class Employee : Person
    {
        public override void SayName()
       
        {
            Console.WriteLine("Name: " + FirstName + "" + LastName);
        }
    }
}
