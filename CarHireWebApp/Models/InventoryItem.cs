using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarHireWebApp.Models {
    public class InventoryItem {
        [Required, Key]
        public Guid Id { get; set; }
        [Required]
        public string RegistrationMark { get; set; }
        [Required]
        public VehicleType VehicleType { get; set; }
        [Required]
        public FuelType FuelType { get; set; }
        [Required]
        public string Make { get; set; }
        [Required]
        public string Model { get; set; }
        [Required]
        public Size Size { get; set; }
        [Required]
        public BodyType BodyType { get; set; }
        [Required]
        public int Seats { get; set; }
        [Required]
        public bool AirCon { get; set; }
        [Required]
        public decimal HourlyCost { get; set; }
        [Required]
        public DateTime PurchaseDate { get; set; }
    }





    public enum VehicleType {
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
        Hybrid = 4,
        Hydrogen = 5,
        SolarElectric = 6,
        Biodiesel = 7
    }

    public enum Size {
        Other = 0,
        Small = 1,
        Medium = 2,
        Large = 3
    }

    public enum BodyType {
        Other = 0,
        Hatchback = 1,
        Saloon = 2,
        Sedan = 3,
        Estate = 4,
        Van = 5
    }
}
