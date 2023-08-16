using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Try_Catch_assignment
{
    public class Program 
    {
        static void Main(string[] args)
        {
            //initializes try. Console asks user for age.
            try
            {
                Console.WriteLine("Please enter your age.");
                //converts string to data type int, creates variable age
                int age = Convert.ToInt32(Console.ReadLine());
                //if statement, if age is less than or equal to zero, throw Exception1
                if (age <= 0)
                {
                    throw new Exception1();
                }
                //if age is greater than zero, subract age from current year, convert to int yearBorn
                int yearBorn = 2023 - age;
                //prints yearBorn
                Console.WriteLine("You were born in " + yearBorn + ".");
                Console.ReadLine();
            }
            //if age is less than or equal to zero, is thrown to Exception1. Console will print message
            catch (Exception1)
            {
                Console.WriteLine("Please enter an integer larger than 0.");
                Console.ReadLine();
            }
            //if age is something other than an integer, is thrown to general catch, this message is printed.
            catch
            {
                Console.WriteLine("Please enter only integers.");
                Console.ReadLine();
            }


        }
    }
}
