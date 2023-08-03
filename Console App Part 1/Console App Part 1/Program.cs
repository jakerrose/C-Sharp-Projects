using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Part_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creates a string list
            string[] firstNames = { "Bill ", "Wendy ", "Calvin ", "Frank " };

            //Asks for user input, takes input and adds the last name to each first name.
            Console.WriteLine("Please type your favorite last name.");
            string word1 = Console.ReadLine();
            Console.WriteLine("Please press enter.");
            //Goes through each item in list, adds one to index of each and loops through
            for (int i=0; i< firstNames.Length; i++)
            {
                firstNames[i] = firstNames[i] + word1;
            }
            Console.ReadLine();

            for (int i=0; i< firstNames.Length; i++)
            {
                Console.WriteLine(firstNames[i]);
            }
            Console.ReadLine();
            Console.WriteLine("Please press enter.");

            //without the if statement, the console will write "Whoa, infinity!" infinitely because the length will always be higher than 0
            while (firstNames.Length > 0)
                {
                Console.WriteLine("Whoa, infinity!");

                if (firstNames.Length <5)
                    break;
            }
            Console.ReadLine();
            //Prints statement to console, if statement prevents infinite loop
            while (firstNames.Length <10)
            {
                Console.WriteLine("This array is less than ten.");

                if (firstNames.Length < 5)
                    break;
            }
            Console.ReadLine();

            //Prints statement to console, if statement prevents infinite loop
            while (firstNames.Length <=4)
            {
                Console.WriteLine("This array is only less than or equal to four.");

                if (firstNames.Length <5)
                    break;
            }
            Console.ReadLine();

            //Creates new list of stuff
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

            //Creates list of food. Asks user to search for matching food item.  Bool datatype is created to determine if item in list equals search item
            List<String> foodList = new List<string>() { "apple", "gardenburger", "fish", "steak", "apple" };

            Console.WriteLine("Type a search term and hit enter to see if we have the food you want.");
            string userFood = Console.ReadLine();
            bool rightFood = foodList.Contains(userFood);

            //Do while loop to see if user term matches item in list. The index number of the list item will also print
            do
            {
                switch (userFood)
                    {
                    case "apple":
                        Console.WriteLine("Yes we have apple! " + "It is in index number " + foodList.IndexOf("apple") + ". Please press enter to continue.");
                    rightFood= true;
                    break;

                    case "gardenburger":
                        Console.WriteLine("Yes we have gardenburger! " + "It is in index number " + foodList.IndexOf("gardenburger") + ". Please press enter to continue.");
                        rightFood = true;
                        break;

                    case "fish":
                        Console.WriteLine("Yes we have fish! " + "It is in index number " + foodList.IndexOf("fish") + ". Please press enter to continue.");
                        rightFood = true;
                        break;

                    case "steak":
                        Console.WriteLine("Yes we have steak! " + "It is in index number " + foodList.IndexOf("steak") + ". Please press enter to continue.");
                        rightFood = true;
                        break;

                    default:
                        Console.WriteLine("Sorry, we don't have " + userFood + ". Please press enter to continue.");
                        Console.WriteLine("Please search for another food.");
                        userFood = Console.ReadLine();
                        break;
                }
            }
            while (!rightFood);
            Console.ReadLine();

            //New string list of car names that contains a duplicate entry. Another list distinct is created as an empty list to populate with distinict entries
            List<String> carType = new List<string>() { "Chevy", "Dodge", "Subaru", "Toyota", "Toyota" };
            List<string> distinct = new List<string>();

            //Foreach loop to run each list entry through. Also long as the entry is unique, it will populate the distinct list. if else statement is used to print if item is in unique or a duplicate
            foreach (string car in carType)
            {
                if (!distinct.Contains(car))
                {
                    Console.WriteLine("Is unique: " + car);
                }
                else
                {
                    Console.WriteLine("Is duplicate: " + car);
                }
                distinct.Add(car);
            }
            Console.ReadLine();
        }
    }
}
