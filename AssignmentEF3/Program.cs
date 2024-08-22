using AssignmentEF3.Context;
using AssignmentEF3.Entites;
using Microsoft.EntityFrameworkCore;

namespace AssignmentEF3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ItiDbContext itiDbContext = new ItiDbContext();
            using (ItiDbContext dbContext = new ItiDbContext())
            {
                Student student = new Student()
                {
                    Id = 1,
                    Fname = "Ahmed",
                    Lname = "Wael",
                    Address = "Shoubra-Street",
                    Age = 22,
                };
                Student student2 = new Student()
                {
                    Id = 1,
                    Fname = "Ahmed",
                    Lname = "Wael",
                    Address = "Shoubra-Street",
                    Age = 22,
                };
                dbContext.Students.Add(student);
                dbContext.Students.Add(student2);
                
            }
            
        }
    }
}
