using DotnetBootcamp.Core.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotnetBootcamp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomBaseController : ControllerBase
    {
        [NonAction]
        public IActionResult CreateActionResult<T>(GlobalResultDto<T> result)
        {
            if (result.StatusCode == 204)
            {
                return new ObjectResult(null)
                {
                    StatusCode = result.StatusCode
                };
            }

            return new ObjectResult(result)
            {
                StatusCode = result.StatusCode
            };
        }
    }
}
