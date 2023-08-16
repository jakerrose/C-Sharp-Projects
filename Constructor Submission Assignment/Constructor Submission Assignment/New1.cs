using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Submission_Assignment
{
    class New1
    {
        //creates public int id equal to 500
        public int id = 500;
        //creates public string name equal to "fresh"
        public string name= "fresh";
        //creates empty constructor that takes two arguments, int and string
        public New1() : this(0, "")
        {

        }
        //inputs the values id and name into the method New1
        public New1(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
