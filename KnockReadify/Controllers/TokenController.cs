using Microsoft.AspNetCore.Mvc;
using System;

namespace KnockReadify.Controllers
{
    [Produces("application/json")]
    [Route("api/Token")]
    public class TokenController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok("a54f3fb8-1217-4970-9a7b-8df2d2f712df");
            }
            catch (Exception ex)
            {
                return BadRequest(ExceptionHelper.ProcessError(ex));
            }
            
        }

    }
}