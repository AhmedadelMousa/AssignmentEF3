﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentEF3.Entites
{
    internal class Course
    {
        public int Id { get; set; }
        public string Duration { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Stud_Course> CourseStudent {  get; set; }= new HashSet<Stud_Course>();
        public ICollection<Course_Inst> Inst_Course { get; set; } = new HashSet<Course_Inst>();
        [InverseProperty("Courses")]
        public Topic Topics { get; set; }
    }
}
