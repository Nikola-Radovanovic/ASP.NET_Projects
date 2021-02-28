using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UsedCars.Models.CreatedModels
{
    public class YearMake
    {
        public int Id { get; set; }

        [Display(Name = "Year of production")]
        public string Year { get; set; }
    }
}