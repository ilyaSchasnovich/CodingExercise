using Business.Models;
using Business.Services;
using Tests.Extention;
using Xunit;

namespace Tests.Services
{
    public class CountServiceTest:Tester
    {
        [Fact]
        public void CalculateEndOfDayBalances_ReturnEndOfDayInfo()
        {
            var brand = CreateOne<Brand>();
            var countService = new CountService();

            var result = countService.CalculateEndOfDayBalances(brand);

            Assert.NotNull(result);
        }
    }
}
