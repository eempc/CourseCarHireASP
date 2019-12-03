using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarHireWebApp.Models {
    public enum VehicleType {
        Other = 0,
        Car = 1,
        Van = 2,
        Motorcycle = 3
    }

    public enum FuelType {
        Other = 0,
        Petrol = 1,
        Diesel = 2,
        Electric = 3,
        Hybrid = 4,
        Hydrogen = 5
    }

    public enum Size {
        Other = 0,
        Small,
        Medium,
        Large
    }
}
