using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRUD_Using_EntityFramework.Models
{

    [MetadataType(typeof(studentMetaData))]
    public partial class student
    {

       }

    public class studentMetaData
    {
        [Display(Name="Student Rollnumber")]
        public int RollNumber { get; set; }
        [Display(Name = "Student Name")]

        public string Name { get; set; }
        [Display(Name = "Student Email")]

        public string Email { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public Nullable<System.DateTime> DOB { get; set; }

        public Trainer Trainer { get; set; }


    }
}