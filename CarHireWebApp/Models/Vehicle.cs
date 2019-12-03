﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarHireWebApp.Models {
    public abstract class Vehicle {
        [Required, Key]
        public Guid VehicleId { get; set; }

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

        [Required, Range(0,9)]
        public int Seats { get; set; }

        [Required]
        public bool AirCon { get; set; }

        [Required, DataType(DataType.Currency)]
        public decimal HourlyCost { get; set; }

        [Required, DataType(DataType.Date)]
        public DateTime PurchaseDate { get; set; }
    }
}