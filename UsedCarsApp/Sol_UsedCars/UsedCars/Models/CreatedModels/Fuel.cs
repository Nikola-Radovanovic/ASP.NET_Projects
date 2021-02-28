using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UsedCars.Models.CreatedModels
{
    public class Fuel
    {
        public int Id { get; set; }

        [Display(Name = "Fuel")]
        public string Type { get; set; }
    }
}