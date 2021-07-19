using System.Threading.Tasks;
using CheckbizApi;
using CheckbizApi.Model;
using Microsoft.AspNetCore.Mvc;
using NSwag.Annotations;

namespace WebApp.Controllers
{
    [Route("norway-lookup")]
    public class NorwayLookupController : ControllerBase
    {
        private readonly CheckbizClient _checkbizClient;

        public NorwayLookupController(CheckbizClient checkbizClient)
        {
            _checkbizClient = checkbizClient;
        }

        [HttpGet("ssn/{ssn}")]
        [OpenApiOperation("LookupBySsn")]
        [OpenApiTag("NorwayLookup")]
        [ProducesResponseType(200, Type = typeof(LookupIdNoResult))]
        public async Task<IActionResult> LookupBySsn(string ssn)
        {
            if (string.IsNullOrEmpty(ssn))
            {
                return BadRequest("missing ssn");
            }

            var result = await _checkbizClient.LookupIdNoAsync(ssn);

            return Ok(result);
        }
    }
}