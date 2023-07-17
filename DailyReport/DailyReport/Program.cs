using System;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy"); //Displays the string
            Console.WriteLine("Student Daily Report"); //Displays the string
            Console.WriteLine("What is your name?"); //Displays string as question
            string yourName = Console.ReadLine(); //Creates string input as variable yourName. ReadLine() method accepts user input when 'enter' is pressed
            Console.WriteLine("What course are you on?");//Displays string question
            string courseName = Console.ReadLine();//Creates string input as variable yourName. ReadLine() method accepts user input when 'enter' is pressed
            Console.WriteLine("What page number?");//Displays string question
            int pageNumber = Convert.ToInt32(Console.ReadLine());//Accepts string user input, converts to integer. INT used because possibility of higher number than byte could handle
            Console.WriteLine("Do you need help with anything? Please answer true or false.");//Displays string question, asks for true or false answser
            bool boolResult;//Creats variable boolResult, uses data type bool for true or false answer
            bool.TryParse("true", out boolResult);//Uses TryParse method to check to see if input is "true", otherwise output "false
            Console.ReadLine();//Takes in user input
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");//Displays string as question
            string experiences = Console.ReadLine();//Creates string input as variable yourName. ReadLine() method accepts user input when 'enter' is pressed
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");//Displays string as question
            string feedback = Console.ReadLine();//Creates string input as variable yourName. ReadLine() method accepts user input when 'enter' is pressed
            Console.WriteLine("How many hours did you study today?");//Displays string as question
            byte studyHours = Convert.ToByte(Console.ReadLine());//Accepts string user input, converts to integer. BYTE used because max value is 24
            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");//Displays string message
            Console.ReadLine();//Code in order to prevent program from closing before message could be read
         }
    }
}
