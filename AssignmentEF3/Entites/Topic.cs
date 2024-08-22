using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentEF3.Entites
{
    internal class Topic
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [InverseProperty("Topics")]
        public Course Courses { get; set; }
    }
}
