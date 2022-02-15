using System;
using System.Collections.Generic;

namespace Business.Models
{
    public record Brand
    {
        public string BrandName { get; init; }
        public string DataSourceName { get; init; }
        public string DataSourceType { get; init; }
        public DateTime RequestDateTime { get; init; }
        public ICollection<Account> Accounts { get; init; } 
    }
}
