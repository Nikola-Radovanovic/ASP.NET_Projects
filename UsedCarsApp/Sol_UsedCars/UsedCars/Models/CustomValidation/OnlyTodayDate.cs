using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using UsedCars.Models.CreatedModels;

namespace UsedCars.Models.CustomValidation
{
    public class OnlyTodayDate : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var ad = (Ad) validationContext.ObjectInstance;

            if (ad.DatePosted < DateTime.Now.Date || ad.DatePosted > DateTime.Now.Date)
            {
                return new ValidationResult("Enter today's date!");
            }
            else
            {
                return ValidationResult.Success;
            }
        }
    }
}