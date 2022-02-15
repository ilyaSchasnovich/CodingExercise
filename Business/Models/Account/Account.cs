using System.Collections.Generic;

namespace Business.Models
{
    public record Account
    {
        public int AccountID { get; init; }
        public string CurrencyCode { get; init; }
        public string DisplayName { get; init; }
        public string AccountType { get; init; }
        public AccountIdentifiers Identifiers { get; init; }
        public ICollection<object> Parties { get; init; }
        public ICollection<object> StandingOders { get; init; }
        public ICollection<object> DirectDebits { get; init; }
        public AccounBalance Balances { get; init; }
        public ICollection<Transaction> Transactions { get; init; }

    }
}
