using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TwoTablesCommunicate.Models;

namespace TwoTablesCommunicate.common
{
    public class UniqueEmailAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                var db = new studentcontext(); // Update with your actual DbContext
                var email = value.ToString();
                var isEmailExists = db.students.Any(s => s.Email == email);
                if (isEmailExists)
                {
                    return new ValidationResult("Email already exists.");
                }
            }
            return ValidationResult.Success;
        }
    }
}