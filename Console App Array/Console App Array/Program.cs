using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_App_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring new string array stringArray and defining the values of the index
            string[] stringArray = { "Ladies ", "and ", "gentlemen ", "we ", "are ", "floating ", "in ", "space." };
            //Writes line to accept user input
            Console.WriteLine("Please select an index of the array by typing in a number between 0 and 7 and pressing enter.");
            //reads user input, converts to integer data type
            int userString = Convert.ToInt32(Console.ReadLine());
            //if user puts in number between 0 and 7, the message will print
            try
            {
                Console.WriteLine("Your word is " + stringArray[userString]); }
            //if user puts in a different number, instead of an error, they will get this message and another chance to put in the correct number
            catch (Exception e)
            { Console.WriteLine("Please enter a number between 0 and 7");
                userString = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Your word is " + stringArray[userString]);

            }
            Console.ReadLine();

            //Declaring a number array
            int[] numArray = { 1, 3, 5, 7, 11, 13 };
            //Writes line to accept user input
            Console.WriteLine("Please select an index of the array by typing in a number between 0 and 5 and pressing enter.");
            //reads user input, converts string to integer
            int userNumber = Convert.ToInt32(Console.ReadLine());
            //if user types the correct number, this message will display
            try
            { 
            Console.WriteLine("Your number is " + numArray[userNumber]); }
            //if user does not type correct number, they will get this error message and another chance
            catch (Exception e)
            { Console.WriteLine("Please enter a number between 0 and 5");
                userNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Your number is " + numArray[userNumber]);
            }
            Console.ReadLine();

            //Declaring a list of animals, string data type
            List<string> Animals1 = new List<string>();
            //Adding 4 values to list
            Animals1.Add("Meerkat");
            Animals1.Add("Koala");
            Animals1.Add("Cat");
            Animals1.Add("Panda");
            //Displays message inviting user input
            Console.WriteLine("Please input a number between 0 to 3 to get your animal.");
            //Creates new string based on user input
            string userAnimal = Console.ReadLine();
            //converts string type to integer type
            int userAnimal1 = Convert.ToInt32(userAnimal);
            //if user input is acceptable, they will get this message
            try
            {
                Console.WriteLine("Your animal is " + Animals1[userAnimal1]); 
            }
            //if user's input number is outside of range, they will get another chance
            catch (Exception e)
            {
                Console.WriteLine("Please write a number between 0 and 3.");
                userAnimal = Console.ReadLine();
                userAnimal1 = Convert.ToInt32(userAnimal);
                Console.WriteLine("Your animal is " + Animals1[userAnimal1]);
            }
            Console.ReadLine();


        }
    }
}
