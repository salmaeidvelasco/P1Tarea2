using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace admEidTarea2.Models
{
    public enum CategoryType
    {
        A=10,
        B=20,
        C = 30,
        D = 40,
        E = 50,
        F = 60
    }
    public class Enrollment
    {
        [Key]
        public int EnrollmentID { get; set; }

        public int CourseID { get; set; }

        public int StudentID { get; set; }


        [DisplayFormat(NullDisplayText = "")]
        public CategoryType Grade { get; set; }

        public virtual Course Courses { get; set; }
        public virtual Student Students { get; set; }


    }
}