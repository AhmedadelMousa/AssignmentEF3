using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentEF3.Entites
{
    internal class Student
    {
        public int Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public ICollection<Stud_Course> StudentCourse { get; set; } = new HashSet<Stud_Course>();
    }
}
