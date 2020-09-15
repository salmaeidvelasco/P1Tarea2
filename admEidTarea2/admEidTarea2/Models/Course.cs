using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace admEidTarea2.Models
{
    public class Course
    {
        [Key]
        public int CourseID { get; set; }

        [DisplayName("Título")]
        public string Title { get; set; }

        [DisplayName("Título")]
        public int Credits { get; set; }

        public int DepartmentID { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}