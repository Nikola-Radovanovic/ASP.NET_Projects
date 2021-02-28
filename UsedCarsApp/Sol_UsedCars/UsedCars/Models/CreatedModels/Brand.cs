using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UsedCars.Models.CreatedModels
{
    public class Brand
    {
        public int Id { get; set; }

        [Display(Name = "Brand")]
        public string Name { get; set; }
    }
}