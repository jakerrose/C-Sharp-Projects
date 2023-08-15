using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Submission_Assignment
{
    class New1
    {
        public var id = 500;
        public const string name= "fresh";
        public New1() : this(0, "")
        {

        }
        public New1(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
