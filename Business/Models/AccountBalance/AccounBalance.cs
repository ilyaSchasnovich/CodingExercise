
namespace Business.Models
{
    public record AccounBalance
    {
        public Balance Current { get; init; }
        public Balance Available { get; init; }
    }
}
