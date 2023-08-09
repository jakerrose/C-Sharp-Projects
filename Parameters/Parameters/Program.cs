using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> list1 = new Employee<string>() { Things= "ball", "mitt"};
            
            foreach (string item in list1.Things)
            {
                Console.WriteLine(item);
                Console.ReadLine();
            }








        }
    }
}
