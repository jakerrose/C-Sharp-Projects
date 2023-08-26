using System.Data.Entity;

namespace FinalChallenge
{
    public class Context : DbContext
    {
        public Context(): base() { }
        public DbSet<Student> Students { get; set; }
    }
    public class Student
    {
        public int Id { get; set; }
        public string firstName  { get; set; }
        public string lastName { get; set; }
        public decimal GPA { get; set; }
    }
}
