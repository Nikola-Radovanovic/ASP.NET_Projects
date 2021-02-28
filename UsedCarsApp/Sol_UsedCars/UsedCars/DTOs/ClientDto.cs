using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using UsedCars.Models.CreatedModels;

namespace UsedCars.DTOs
{
    public class ClientDto
    {
        public int Id { get; set; }

        public virtual ICollection<Ad> Ads { get; set; }

        [Required(ErrorMessage = "Enter the client name")]
        [StringLength(40)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Enter the client lastname")]
        [StringLength(40)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Enter the client address")]
        [StringLength(70)]
        public string Address { get; set; }

        [Required(ErrorMessage = "Enter the client city")]
        [StringLength(40)]
        public string City { get; set; }

        [Required(ErrorMessage = "Enter the zip code")]
        [StringLength(10)]
        public string PostalCode { get; set; }

        [Required(ErrorMessage = "Enter the name of the country")]
        [StringLength(30)]
        public string Country { get; set; }

        [Required(ErrorMessage = "Enter the client phone number")]
        [StringLength(20)]
        public string Phone { get; set; }
    }
}