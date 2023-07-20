using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //User enters input which becomes variable userNumber. Is a string, so gets coverted to double. Creates new variable total which is userNumber * 50.
            Console.WriteLine("Please enter a number.");
            double userNumber = Convert.ToDouble(Console.ReadLine());
            double total = userNumber * 50;
            Console.WriteLine("Your number times 50 is " + total);
            Console.WriteLine("Press enter.");
            Console.ReadLine();

            //User enters input which becomes variable anotherNumber. Is a string, so gets coverted to int. Creates new variable sume which is anotherNumber + 25.
            Console.WriteLine("Please enter another number.");
            int anotherNumber = Convert.ToInt32(Console.ReadLine());
            int sum = anotherNumber + 25;
            Console.WriteLine("Your number plus 25 is " + sum);
            Console.WriteLine("Press enter.");
            Console.ReadLine();

            //User enters input which becomes variable dividedNumber. Is a string, so gets coverted to double. Creates new variable quotient which is dividedNumber / 12.5.
            Console.WriteLine("Won't you please humor me and enter another number?");
            double dividedNumber = Convert.ToDouble(Console.ReadLine());
            double quotient = dividedNumber / 12.5;
            Console.WriteLine("Your number divided by 12.5 is " + quotient);
            Console.WriteLine("Please enter.");
            Console.ReadLine();

            //User enters input which becomes variable newNumber. Is a string, so gets coverted to double. Bool variable isGreater asks if newNumber is greater than 50.
            Console.WriteLine("I beg you, enter another number!");
            double newNumber = Convert.ToDouble(Console.ReadLine());
            bool isGreater = newNumber > 50;
            Console.WriteLine("Your number is greater than 50: " + isGreater);
            Console.WriteLine("Please enter.");
            Console.ReadLine();

            //User enters input which becomes variable remainderNum. Is a string, so gets converted to double. New variable isRemainder equals the remainder of remainderNum when divided by 7.
            Console.WriteLine("Enter another number, I'll be your best friend.");
            double remainderNum = Convert.ToDouble(Console.ReadLine());
            double isRemainder = remainderNum % 7;
            Console.WriteLine("Your number divided by 7 has a remainder of " + isRemainder);
            Console.WriteLine("End of program.");
            Console.ReadLine();



        }
    }
}
