using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TennisSatisfaction.Model
{
    public class Student : Person  // Ensure Person exists
    {
        [Required]
        public string Gender { get; set; }

        [Required]
        [EmailAddress]  // Adds validation for correct email format
        public string Email { get; set; }

        [Required]
        public string University { get; set; }

        [Required]
        public string CourseTime { get; set; }

        // Navigation property
        public List<Response> Responses { get; set; } = new List<Response>();

        // Constructor for initialization
        public Student(string name, string gender, string email, string university, string courseTime)
            : base(name)
        {
            Gender = gender;
            Email = email;
            University = university;
            CourseTime = courseTime;
        }
    }
}
