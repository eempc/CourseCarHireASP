using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarHireWebApp.Models {
    public class BookingItem {
        public int Id { get; set; }
        public string UserGuIdAdded { get; set; }
        public DateTime DateTimeAdded { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public string InventoryIdBooked { get; set; }
    }
}
