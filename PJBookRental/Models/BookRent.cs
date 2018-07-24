using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PJBookRental.Models
{
    public class BookRent
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int BookId { get; set; }

        public DateTime? StartDate { get; set; }
        public DateTime? ActualEndDate { get; set; }
        public DateTime? ScheduledEndDate { get; set; }

        public double? AdditionalCharge { get; set; }
        public double? RentalPrice { get; set; }

        public StatusEnum Status { get; set; }
        public enum StatusEnum
        {
            Requested,
            Approved,
            Rejected,
            Rented,
            Closed
        }

    }
}