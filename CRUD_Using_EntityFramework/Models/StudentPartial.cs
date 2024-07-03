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
        public int RollNumber { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public Nullable<System.DateTime> DOB { get; set; }


    }
}