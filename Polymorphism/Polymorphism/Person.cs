using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public abstract class Person
    {
        //creates two properties, FirstName and LastName
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //creates new void method SayName()
        public void SayName()
        {
            //will write name  when method is called
            Console.WriteLine("Name: " + FirstName + "" + LastName);
        }
    }
}
