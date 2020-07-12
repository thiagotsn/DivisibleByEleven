using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IsDivisibleByEleven.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace IsDivisibleByEleven.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DivisibleByElevenController : ControllerBase
    {
        private readonly ILogger<DivisibleByElevenController> _logger;

        public DivisibleByElevenController(ILogger<DivisibleByElevenController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public Response Get([FromBody] DivisibleByEleven numbers)
        {
            return numbers.CheckDivisibility();
        }
    }
}
