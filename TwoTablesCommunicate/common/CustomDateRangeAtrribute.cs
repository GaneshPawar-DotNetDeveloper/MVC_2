using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TwoTablesCommunicate.common
{
    public class CustomDateRangeAtrribute:RangeAttribute
    {
      public  CustomDateRangeAtrribute() : base(typeof(DateTime),DateTime.Now.ToString(),DateTime.Now.ToString()) { }

        public override bool IsValid(object value)
        {
           
            DateTime inputtime = (DateTime)value;
            if (inputtime < DateTime.Now)
            {
                return true;
            } 
            else
            {
                return false;
            }
        
           
        }

    }
}