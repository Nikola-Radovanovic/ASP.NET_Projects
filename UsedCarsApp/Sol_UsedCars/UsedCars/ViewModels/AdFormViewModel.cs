using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UsedCars.Models.CreatedModels;

namespace UsedCars.ViewModels
{
    public class AdFormViewModel
    {
        public Ad Ad { get; set; }
        public IEnumerable<Client> Clients { get; set; }
        public IEnumerable<Car> Cars { get; set; }
    }
}