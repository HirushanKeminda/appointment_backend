using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Project.DTO;
using Project.DTO.InternalDTO;
using Project.Interfaces.IServices;
using Project.Models;

namespace Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpPost("add-user", Name = "AddUser")]
        public async Task<IActionResult> AddUser(UserRegisterRequestDTO request)
        {
            
            try
            {
                UserModel user = new UserModel();
                
                Guid userId = Guid.NewGuid();
                user.Id = userId.ToString();
                user.Name = request.UserName;
                user.Email = request.UserEmail;
                user.contactNumber=request.UserContactNumber;
                user.Message= request.UserMessage;
                var result = await _userService.AddUser(user);

                return result.Status ? Created("User created", result):BadRequest(result);




            }
            catch (Exception ex)
            {
                GeneralResponseDTO response = new GeneralResponseDTO(false, ex.Message);
                return BadRequest(response);
            }
        }
    }
}
