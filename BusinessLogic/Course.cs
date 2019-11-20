using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class Course
    {
        private readonly int maxCredits = 30;
        public Course(string courseName)
        {
            CourseName = courseName;
            InstructorName = "Staff";
        }

        /// <summary>
        /// The instructor teaching the course
        /// </summary>
        public string InstructorName { get; set; }

        /// <summary>
        /// The name of the course
        /// </summary>
        public string CourseName { get; set; }

        /// <summary>
        /// Number of credits for the course
        /// </summary>     
		public byte NumberOfCredits { get; set; }
    }
        
}
