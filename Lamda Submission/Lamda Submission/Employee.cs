using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lamda_Submission
{
    //creates public class Employee
    public class Employee
    {
        //creates three properties of Employee
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }

        //creates a constructor for Employee with three properties
        public Employee(string FirstName, string LastName, int ID)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.ID = ID;
        }
    }
}
