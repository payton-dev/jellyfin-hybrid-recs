using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HybridRecs.Plugin.Api
{
    [ApiController]
    [Route("HybridRecs/Recommendations")]
    public class RecommendationsController : ControllerBase
    {
        [HttpGet("user/{userId}")]
        public async Task<ActionResult<object>> GetUserRecs([FromRoute] string userId, [FromQuery] int limit = 20)
        {
            // TODO: real logic; return stub
            return Ok(new {
                userId,
                generatedAt = DateTime.UtcNow,
                items = new List<object>()
            });
        }

        [HttpGet("trending")]
        public async Task<ActionResult<object>> GetTrending([FromQuery] int limit = 20)
        {
            return Ok(new {
                generatedAt = DateTime.UtcNow,
                items = new List<object>()
            });
        }
    }
}