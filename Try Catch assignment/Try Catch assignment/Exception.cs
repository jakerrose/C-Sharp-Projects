using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Try_Catch_assignment
{
    //creates public class Exception1, references System.Exception
    public class Exception1: Exception
    {
        //creates two methods that are overloaded so that program can reference the exception
        public Exception1()
            : base() { }
        public Exception1(string message)
            : base(message) { }
        
    }
}
