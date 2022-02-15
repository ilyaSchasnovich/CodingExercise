using Business.Models;
using System.Collections.Generic;

namespace Business.Interfaces
{
    public interface ICountSevice
    {
        public List<EndOfDayInfo> CalculateEndOfDayBalances(Brand brand);
    }
}
