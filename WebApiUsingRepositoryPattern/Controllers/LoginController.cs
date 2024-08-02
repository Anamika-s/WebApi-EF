using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi_EF.Context;
using WebApiUsingRepositoryPattern.ViewModel;

namespace WebApiUsingRepositoryPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        StudentDbContext _context;
        public LoginController(StudentDbContext context) {
            _context = context;

        }
        [HttpPost]
        public IActionResult Login(LoginModel loginModel)
        {
            var user = _context.Users.FirstOrDefault(x=>x.Email == loginModel.EMail
            && x.Password== loginModel.Password);
            return Ok(user);

        }
    }
}
