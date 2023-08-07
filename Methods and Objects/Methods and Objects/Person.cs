using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_and_Objects
{
    public class Person
    {
        //constructor with two parameters
        //public Person(string firstName, string lastName)
        //{
        //    FirstName = firstName;
        //    LastName = lastName;
        //}
        //adding two properties to class Person
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //creating public void method SayName
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + "" + LastName);
        }
    }
}
