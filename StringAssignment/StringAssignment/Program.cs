using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cretes string name
            string name = "Jake";
            //Prints string name in all upper case
            Console.WriteLine(name.ToUpper());
            Console.ReadLine();
            //Creates two more strings
            string middle = " is so ";
            string ending = "so great!";
            //Creates string that is a concatenation of three previous strings
            string sentence = name + middle + ending;
            Console.WriteLine(sentence);
            Console.ReadLine();

            //Uses StringBuilder to create three new objects, each is associated with a sentence
            StringBuilder beg = new StringBuilder("It was a dark and stormy night. ");
            StringBuilder mid = new StringBuilder("Suddently, a shot rang out! ");
            StringBuilder end = new StringBuilder("A door slammed. The maid screamed.");
            //assigns a variable to each sentence
            var snoopy = beg.ToString();
            var snoopy2 = mid.ToString();
            var snoopy3 = end.ToString();
            //creates string that is a concatenation of each sentence to create a paragraph
            string novel = snoopy + snoopy2 + snoopy3;
            Console.WriteLine(novel);
            Console.ReadLine();




        }
    }
}
