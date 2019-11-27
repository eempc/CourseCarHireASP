using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarHireWebApp.Models {
    public class InventoryItem {
        [Required, Key]
        public int Id { get; set; }
        [Required]
        public string RegistrationMark { get; set; }
    }





    public enum ItemType {
        Other = 0,
        Car = 1,
        Van = 2,
        Motorcycle = 3,
        Motorhome = 4,
    }

    public enum FuelType {
        Other = 0,
        Petrol = 1,
        Diesel = 2,
        Electric = 3,
        Hybrid = 4
    }

    public enum Size {
        Other = 0,
        Small = 1,
        Medium = 2,
        Large = 3
    }

    public enum Body {

    }
}
