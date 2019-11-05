using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class Course
    {
        private int maxCredits = 30;
        private string courseName;
        private byte numberOfCredits;

        public Course(string courseName)
        {
            CourseName = courseName;
            InstructorName = "STAFF";
        }

        /// <summary>
        /// The instructor teaching the course
        /// </summary>
        public string InstructorName { get; set; }

        /// <summary>
        /// The name of the course
        /// </summary>
        public string CourseName
        {
            get => courseName;
            set
            {
                if (value is null)
                    throw new ArgumentNullException("CouseName is null");

                courseName = value;
            }
        }

        /// <summary>
        /// Number of credits for the course
        /// </summary>     
		public byte NumberOfCredits
        {
            get => numberOfCredits;
            set
            {
                if (value == maxCredits || value > maxCredits)
                    throw new ArgumentException("Credits over max value");
                if (value == 0)
                    throw new ArgumentException("Credits zero value");

                numberOfCredits = value;
            }
        }
    }

}
