using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    //creates public abstract class Person
    public abstract class Person
    {
        //creates two properties, FirstName and LastName
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //creates new void method SayName()
        public abstract void SayName();
            public void method()
        {
            //will write name  when method is called
            Console.WriteLine("Name: " + FirstName + "" + LastName);
        }

    }
}
