using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UsedCars.Models.CreatedModels
{
    public class Client
    {
        public int Id { get; set; }

        public virtual ICollection<Ad> Ads { get; set; }

        [Required(ErrorMessage = "Enter the client name")]
        [Display(Name = "Name")]
        [StringLength(40)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter the client lastname")]
        [Display(Name = "Lastname")]
        [StringLength(40)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Enter the client address")]
        [Display(Name = "Address")]
        [StringLength(70)]
        public string Address { get; set; }

        [Required(ErrorMessage = "Enter the client city")]
        [Display(Name = "City")]
        [StringLength(40)]
        public string City { get; set; }

        [Required(ErrorMessage = "Enter the zip code")]
        [Display(Name = "ZIP")]
        [StringLength(10)]
        public string PostalCode { get; set; }

        [Required(ErrorMessage = "Enter the name of the country")]
        [Display(Name = "Country")]
        [StringLength(30)]
        public string Country { get; set; }

        [Required(ErrorMessage = "Enter the client phone number")]
        [Display(Name = "Phone")]
        [StringLength(20)]
        public string Phone { get; set; }
    }
}