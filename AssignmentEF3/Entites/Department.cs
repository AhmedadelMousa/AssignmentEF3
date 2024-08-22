using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentEF3.Entites
{
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime HiringDate { get; set; }
        [InverseProperty("departments")]
        public Instructor Instructors { get; set; }
        
    }
}
