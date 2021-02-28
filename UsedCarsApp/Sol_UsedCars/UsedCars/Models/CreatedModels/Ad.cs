using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using UsedCars.Models.CustomValidation;

namespace UsedCars.Models.CreatedModels
{
    public class Ad
    {
        public int Id { get; set; }

        public virtual Client Client { get; set; }
        [Required(ErrorMessage = "Select client")]
        [Display(Name = "Client")]
        public int ClientId { get; set; }

        public virtual Car Car { get; set; }
        [Required(ErrorMessage = "Select a car model")]
        [Display(Name = "Car")]
        public int CarId { get; set; }

        [Required(ErrorMessage = "Enter post date")]
        [Display(Name = "Date Posted")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime DatePosted { get; set; } = DateTime.Now;

        [Display(Name = "Description")]
        [StringLength(1000)]
        public string Description { get; set; }
    }
}