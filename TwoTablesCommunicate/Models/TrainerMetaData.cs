using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace TwoTablesCommunicate.Models
{
    [MetadataType(typeof(TrainerMetaData))]
    public partial class Trainer
    {
    }
    public class TrainerMetaData
    {
        public int TrainerId { get; set; }
        [Required(ErrorMessage ="Please Enter Student Name")]
        [StringLength(maximumLength:10,MinimumLength=5,ErrorMessage ="Name should have atleast 5 characters and " +
            "maximum 10 characters")]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage ="Only Alphabets are allow")]
        public string TrainerName { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<student> students { get; set; }
    }
}