using Apitest.Services;
using Microsoft.AspNetCore.Mvc;
using Serilog;


namespace Apitest.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        

        [HttpGet]
        public async Task<IActionResult> GetUser()
        {
           //_logger.LogInformation("starting method");
            var data = await _userService.Getdata();
          
           // Log.Information("starting method  => {@data}", data);
          
            return Ok(data);
        }

      

    }
}
