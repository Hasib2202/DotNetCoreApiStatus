using CheckStatusAPI.Models.Requests;
using CheckStatusAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CheckStatusAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CheckStatusController : ControllerBase
    {
        private readonly ICheckStatusService _checkStatusService;

        public CheckStatusController(ICheckStatusService checkStatusService)
        {
            _checkStatusService = checkStatusService;
        }

        /// <summary>
        /// Endpoint to check user status via GET with query parameter "msisdn"
        /// Example: GET /CheckStatus?msisdn=1234567890
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetUserStatus([FromQuery] string msisdn)
        {
            var result = await _checkStatusService.CheckUserStatusAsync(msisdn);
            return Ok(result);
        }

        /// <summary>
        /// Endpoint to check user status via POST with JSON body
        /// Example: POST /CheckStatus
        /// {
        ///   "msisdn": "1234567890"
        /// }
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> PostUserStatus([FromBody] CheckStatusRequest request)
        {
            if (request == null || string.IsNullOrEmpty(request.Msisdn))
                return BadRequest("Msisdn is required.");

            var result = await _checkStatusService.CheckUserStatusAsync(request.Msisdn);
            return Ok(result);
        }
    }
}
