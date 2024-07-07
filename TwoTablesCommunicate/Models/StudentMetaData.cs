using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using TwoTablesCommunicate.common;

namespace TwoTablesCommunicate.Models
{

    [MetadataType(typeof(StudentMetaData))]
    public  partial class student
    {
        [Required(ErrorMessage ="confirm Email is Required")]
        [Compare("Email",ErrorMessage ="Confirmed Email and Email should be same")]

        public string ConfirmEmail {  get; set; }
    } 
    public class StudentMetaData
    {

        public int RollNumber { get; set; }
        [Required (ErrorMessage ="Please Enter the Name")]
        [StringLength(maximumLength:10,MinimumLength =5,ErrorMessage ="NAme sholid have atlest 5 character and " +
            "maximum 10 character")]
        [RegularExpression("^[a-zA-Z]+$",ErrorMessage ="Only Alphabets allowed")]
        [DisplayName("StudentName")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Email should be required")]
        //   [RegularExpression(
        //@"^[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@" +
        //@"(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$",
        //ErrorMessage = "Invalid Email")]
        [RegularExpression(
@"^(?i)[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@" +
@"(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$",
ErrorMessage = "Invalid Email")]

        [DisplayName("StudentEmail")]
        public string Email { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        [CustomDateRangeAtrribute(ErrorMessage = "BOD not greater than todays")]

        public Nullable<System.DateTime> DOB { get; set; }
 
        public Nullable<int> TrainerId { get; set; }

        public virtual Trainer Trainer { get; set; }
    
}
}