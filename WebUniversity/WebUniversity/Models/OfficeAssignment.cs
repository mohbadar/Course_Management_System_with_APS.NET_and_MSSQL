using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebUniversity.Models
{
    public class OfficeAssignment
    {
        [Key]
        [ForeignKey("Instructor")]
        public int InstructorID { get; set; }

        [Display(Name = "Office Location")]
        [StringLength(100, MinimumLength =5)]
        public string Location { get; set; }

        public virtual Instructor Instructor { get; set; }
    }
}