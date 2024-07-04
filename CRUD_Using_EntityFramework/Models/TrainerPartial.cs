using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRUD_Using_EntityFramework.Models
{
    [MetadataType(typeof(metatrainer))]
    public  partial class TrainerPartial
    {
    }
    public class metatrainer
    {
        public int TrainerId { get; set; }
        public string TrainerName { get; set; }

        public virtual ICollection<student> students { get; set; }

    }
}