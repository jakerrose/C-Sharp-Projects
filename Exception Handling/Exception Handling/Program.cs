﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)

        {
            List<String> randomStuff = new List<string>() { "hamburger", "socks", "toys", "records", "games" };
            //asks user to enter term to search for. Bool datatype is created to determine if item in list equals search item
            Console.WriteLine("Would you like to search our list off stuff to see if we have what you want? Type a search term.");
            string userTerm = Console.ReadLine();
            bool rightGuess = randomStuff.Contains(userTerm);
            //Do while loop to handle user searchs. If the item matches, the bool is true and message prints. If item does not match, it will switch to the default and the program will loop
            do
            {
                switch (userTerm)
                {
                    case "hamburger":
                        Console.WriteLine("Yes we have hamburger! Please press enter to continue.");
                        rightGuess = true;
                        break;

                    case "socks":
                        Console.WriteLine("Yes we have socks! Please press enter to continue.");
                        rightGuess = true;
                        break;

                    case "toys":
                        Console.WriteLine("Yes we have toys! Please press enter to continue.");
                        rightGuess = true;
                        break;

                    case "records":
                        Console.WriteLine("Yes we have records! Please press enter to continue.");
                        rightGuess = true;
                        break;

                    case "games":
                        Console.WriteLine("Yes we have games! Please press enter to continue.");
                        rightGuess = true;
                        break;

                    default:
                        Console.WriteLine("Sorry, we don't have " + userTerm + ".");
                        Console.WriteLine("Please trying searching for another term.");
                        userTerm = Console.ReadLine();
                        break;
                }
            }
            while (!rightGuess);
            Console.ReadLine();
        }
    }
}
    

