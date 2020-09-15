using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace admEidTarea2.Models
{
    public class Student
    {

        [Key]
        public int ID { get; set; }


        [Required]
        public string LastName { get; set; }

        [StringLength(30)]
        public string FirstMidName { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd:MM:yyyy)",ApplyFormatInEditMode =true)]
        public DateTime EnrollmentDate { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}