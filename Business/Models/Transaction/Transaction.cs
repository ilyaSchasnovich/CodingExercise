using System;

namespace Business.Models
{
    public record Transaction
    {
        public string Description { get; init; }
        public int Amount { get; init; }
        public string CreditDebitIndicator { get; init; }
        public DateTime BookingDate { get; init; }
        public object MerchanDetails { get; init; }
    }
}
