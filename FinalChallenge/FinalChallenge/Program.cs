using System;

    namespace FinalChallenge
{
    class Program
    {
        static void Main(string[] args) 
        {
            using (var ctx = new Context()) 
            {
                var stud = new Student()
                { firstName = "John", lastName = "Kennedy", GPA = 3.2m };

                ctx.Students.Add(stud);
                ctx.SaveChanges();
            }
        }
    }
}