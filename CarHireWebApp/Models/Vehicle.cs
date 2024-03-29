﻿using System;
using System.ComponentModel.DataAnnotations;

namespace CarHireWebApp.Models {
    public class Vehicle {
        [Required, Key]
        public Guid VehicleId { get; set; }

        [Required]
        public string RegistrationMark { get; set; }

        [Required]
        public VehicleType VehicleType { get; set; }

        [Required]
        public string Make { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        public Size Size { get; set; }

        [Required, Range(0,9)]
        public int Seats { get; set; }

        [Required, DataType(DataType.Currency)]
        public decimal Rate { get; set; }
    }
}
