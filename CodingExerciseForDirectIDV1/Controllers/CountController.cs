using Business.Interfaces;
using Business.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApi.ActionFilters;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [LogActionFilterAttribute]
    public class CountController : Controller
    {
        private readonly ICountSevice _countSevice;

        public CountController(ICountSevice countSevice)
        {
            _countSevice = countSevice;
        }

        [HttpPost("get-end-of-day-info")]
        public ActionResult<List<EndOfDayInfo>> GetEndOfDayInfo([FromBody]Brand brand) => _countSevice.CalculateEndOfDayBalances(brand);
    }
}
