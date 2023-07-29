using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_While_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prints question, creates variable string nameGuess, creates boolean variable rightGuess which is true when equals "Rumpelstiltskin"
            Console.WriteLine("What's my name?");
            string nameGuess = Console.ReadLine();
            bool rightGuess = nameGuess == "Rumpelstiltskin";
            
            //creates while loop which keeps loop going when rightGuess is false
            while (!rightGuess)
            {
                //Switch which takes user input as variable nameGuess and runs it through these cases
                switch (nameGuess)
                {
                    case "John":
                        Console.WriteLine("You guessed John. Try again. ");
                        Console.WriteLine("Guess a name");
                        nameGuess = Console.ReadLine();
                        break;
                    default:
                        Console.Write("Wrong name. Try again. ");
                        Console.WriteLine("Guess a name");
                        nameGuess = Console.ReadLine();
                        break;
                    case "Rumpelstiltskin":
                        Console.Write("You guessed my name! You win!");
                        rightGuess = true;
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
