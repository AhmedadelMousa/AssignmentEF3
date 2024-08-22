

using AssignmentEF3.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentEF3.Context
{
    internal class ItiDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.; DataBase=ItiSchool;trusted_Connection=true");
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Topic> Topic { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course_Inst>course_Insts { get; set; }
        public DbSet<Stud_Course>Cour_Stud { get; set; }
        public DbSet<Instructor> Instructors { get; set; }

    }
}
