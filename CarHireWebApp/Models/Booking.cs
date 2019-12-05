using CarHireWebApp.Areas.Identity.Data;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarHireWebApp.Models {
    public class Booking {
        [Required, Key]
        public int BookingId { get; set; } // Standard int

        [Required, DataType(DataType.DateTime)]
        public DateTime DateCreated { get; set; } // DateTime this entry was added to DB

        [Required, ForeignKey("User")]
        public string UserId { get; set; } // Which user booked the car
        public CarHireWebAppUser User { get; set; }

        [Required, DataType(DataType.DateTime)]
        public DateTime BookingStartDateTime { get; set; }

        [Required, DataType(DataType.DateTime)]
        public DateTime BookingEndDateTime { get; set; }

        [DataType(DataType.Currency)]
        public decimal PricePaid { get; set; }

        public bool PaymentConfirmed { get; set; }
         
        [Required, ForeignKey("Vehicle")]
        public string VehicleId { get; set; }
        public Vehicle Vehicle { get; set; }

    }
}
