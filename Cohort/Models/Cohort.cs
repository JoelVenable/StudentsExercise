using System;
using System.Collections.Generic;
using System.Text;

namespace Cohort.Models
{
    public class Cohort
    {
        public List<Student> Students { get; set; } = new List<Student>();

        public List<Instructor> Instructors { get; set; } = new List<Instructor>();

        public int Id { get; set; };


    }
}
