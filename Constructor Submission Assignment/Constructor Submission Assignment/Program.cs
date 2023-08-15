using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Submission_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            New1 a = new New1();
            
            Console.WriteLine($"The prince was {a.name} even though he was {a.id} years old.");
            Console.ReadLine();

        }
    }
}
