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
            Employee<string> list1 = new Employee<string>();
            list1.Things = new List<string>() { "ball", "bat", "mit" };

            Employee<int> list2 = new Employee<int>();
            list2.Things = new List<int>() { 1, 23, 99, 103 };
            
            foreach (string item in list1.Things)
            {
                Console.WriteLine(item);
                
            }

            foreach (int item in list2.Things)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
