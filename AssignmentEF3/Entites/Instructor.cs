using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentEF3.Entites
{
    internal class Instructor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Bouns { get; set; }
        public double Salary { get; set; }
        public string Adress { get; set; }
        public double HourRate { get; set; }
        public ICollection<Course_Inst> course_Insts { get; set; } = new HashSet<Course_Inst>();
        public ICollection<Department> departments { get; set; }= new HashSet<Department>();
    }
}
