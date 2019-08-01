using System;
using System.Collections.Generic;
using System.Text;

namespace Cohort.Models
{
    public class Instructor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string SlackHandle { get; set; }
        public string Specialty { get; set; }

        public void AssignExercise()
        {

        }
    }
}
