using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;


namespace ITSLocation.API.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[Controller]")]

    public class UsuarioController:ControllerBase
    {
    //    private readonly IUserService _userService;

    //    public UsuarioController(IUserService userService)
    //    {
    //        _userService = userService;
    //    }
    //    [HttpGet]
    //    public async Task<ActionResult<IEnumerable<UserDto>>> GetAll()
    //    {

    //    }
    }
}
