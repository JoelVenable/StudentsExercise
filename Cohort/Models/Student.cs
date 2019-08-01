using System;
using System.Collections.Generic;
using System.Text;

namespace Cohort.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string SlackHandle { get; set; }
        public List<Exercise> Exercises = new List<Exercise>();
    }
}
