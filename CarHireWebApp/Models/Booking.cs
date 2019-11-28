using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarHireWebApp.Models {
    public class Booking {
        public int Id { get; set; }
        public string UserGuIdAdded { get; set; }
        public DateTime DateTimeAdded { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public string InventoryIdBooked { get; set; }
        public decimal PricePaid { get; set; }
        public CardIssuer CardIssuer { get; set;}
        public bool PaymentConfirmed { get; set; }
    }

    public enum CardIssuer {
        Other = 0,
        Visa = 1,
        Mastercard = 2
    }
}
