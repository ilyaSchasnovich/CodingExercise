namespace Business.Models
{
    public record AccountIdentifiers
    {
        public int SortCode { get; init; }
        public string AccountNumber { get; init; }
        public string SecondaryIndentiofication { get; init; }
    }
}
