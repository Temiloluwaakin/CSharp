using BusinessLogicLayer.IService;
using DomainLayer.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }







        [HttpGet("{id}")]
        public async Task<ActionResult<UserDto>> GetUserById(int id)
        {
            var user = await _userService.GetUserById(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }






        [HttpPost]
        public async Task<IActionResult> CreateUser(UserDto userDto)
        {
            await _userService.CreateUser(userDto);
            return CreatedAtAction(nameof(GetUserById), new { id = userDto }, userDto);
        }
    }
}
