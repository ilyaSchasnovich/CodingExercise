namespace Business.Models
{
    public record Balance
    {
        public int Amount { get; init; }
        public string CreditDebitIndicator { get; init; }
        public string CreditLines { get; init; }
    }
}
