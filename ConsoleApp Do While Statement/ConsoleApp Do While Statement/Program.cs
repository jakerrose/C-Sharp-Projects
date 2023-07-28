using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Do_While_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Can you guess my number?");
            int numGuess = Convert.ToInt32(Console.ReadLine());
            bool rightGuess = numGuess == 28;

            do
            {
                switch (numGuess)
                {
                    case 1:
                        Console.WriteLine("You guessed 1. Wrong.");
                        Console.WriteLine("Guess another number");
                        numGuess = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 22:
                        Console.WriteLine("You guessed 22. You're so wrong!");
                        Console.WriteLine("Guess another number");
                        numGuess = Convert.ToInt32(Console.ReadLine());
                        break;

                    default:
                        Console.WriteLine("I can't believe how wrong you are.");
                        Console.WriteLine("Guess another number");
                        numGuess = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 28:
                        Console.WriteLine("OMG you guessed right!");
                        rightGuess = true;
                        break;
                }
            }
            while (!rightGuess);
            Console.ReadLine();
        }
    }
}
