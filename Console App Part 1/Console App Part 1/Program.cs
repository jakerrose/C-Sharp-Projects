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
            //Creates bool data type to determine when correct word is found
            bool found = false;
            //Prints question for user input
            Console.WriteLine("Would you like to search our list off stuff to see if we have what you want? Type a search term.");
            //creates string variable using user input
            string userTerm = Console.ReadLine();
            //uses for loop, goes through each index item to see if userTerm matches
            for (int i = 0; i < randomStuff.Count; i++)
            {
                //if statement, if userTerm matches item, it will write the name of the string and index number
                if (userTerm == randomStuff[i])
                {
                    Console.WriteLine("Yes we have {0} at index {1}", userTerm, i);
                    //if bool found is true, breaks out of loop
                    found = true;
                    break;
                }

            }
            //if item is not found, will print message
            if (!found)
            {
                Console.WriteLine("Sorry, we don't have " + userTerm + ".");
            }
            Console.ReadLine();

            //Creates new list
            List<String> randomStuff2 = new List<string>() { "hamburger", "socks", "toys", "records", "games", "hamburger" };
            //Creates bool data type to determine when correct word is found
            bool find = false;
            //Prints question for user input
            Console.WriteLine("Would you like to search our list off stuff to see if we have what you want? Type a search term.");
            //creates string variable using user input
            string userWord = Console.ReadLine();
            //uses for loop, goes through each index item to see if userTerm matches
            for (int i = 0; i < randomStuff2.Count; i++)
            {
                //if statement, if userTerm matches item, it will write the name of the string and index number
                if (userWord == randomStuff2[i])
                {
                    Console.WriteLine("Yes we have {0} at index {1}", userWord, i);
                    find = true;
                }
            }
            //if item is not found, will print message
            if (!find)
            {
                Console.WriteLine("Sorry, we don't have " + userWord + ".");
            }
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
