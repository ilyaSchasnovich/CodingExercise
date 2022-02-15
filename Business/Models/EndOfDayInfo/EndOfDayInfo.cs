using System.Collections.Generic;

namespace Business.Models
{
    public record EndOfDayInfo
    {
        public int AccountId { get; init; }
        public int TotalDebit { get; init; }
        public int TotalCredit { get; init; }
        public ICollection<EndOfDayBalance> EndOfDayBalances { get; init; }
    }
}
