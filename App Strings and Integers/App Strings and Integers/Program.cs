using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Strings_and_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating a new list with data type integer
            List<int> numList = new List<int>() { 2, 11, 55, 24, 1 };

            //Begins try block
            try
            {
                //Asks user for whole number, converts string to integer type
                Console.WriteLine("Please enter a whole number to divide each number in the list by:");
                int userNumber = Convert.ToInt32(Console.ReadLine());
                //Begins foreach loop which will divide each number in list by userNumber
                foreach (int num in numList)
                {
                    Console.WriteLine("List number divided by your number is " + num / userNumber);
                }
            }
            //catches exception and prints error when user trys to divide by zero
            catch (DivideByZeroException)
            {
                Console.WriteLine("Please don't divide by zero.");
            }
            //catches exception and prints error when user tries to enter a string or number with decimal
            catch (FormatException e)
            {
                Console.WriteLine("Please enter a whole number.");
            }
            //catches exception and prints error message for other errors such as the number is too long
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //will always default to readline method so results show in terminal
            finally
                {
                Console.ReadLine();
                }
            }   
        }
    }

