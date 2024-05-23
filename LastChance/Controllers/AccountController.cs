using LastChance.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LastChance.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        [HttpGet]
        [Route("test")]
        public string Test()
        {
            return "LOX";
        }
        [HttpPost]
        [Route("register")]
        public async Task<string> Register(ProUser u)
        {
                User user = new User { Email = u.Email, UserName = u.Email, Year = u.Year };
                // добавляем пользователя
                var result = await _userManager.CreateAsync(user, u.Password);
                if (result.Succeeded)
                {
                    // установка куки
                    await _signInManager.SignInAsync(user, false);
                    return "OK";
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                    return "ERROR";
                }
        }
    }
}
