using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TaskTracking.Business.Services;  // <-- Service için using
using TaskTracking.Entities;           // <-- User için using

namespace TaskTracking.WebAPI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserService _userService;

        // Constructor injection
        public HomeController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(User user)
        {
            // Username kontrolü
            var existingUser = await _userService.GetUserByUsernameAsync(user.Username);
            if (existingUser != null)
            {
                ModelState.AddModelError("", "Bu kullanıcı adı zaten var.");
                return View(user);
            }

            // Yeni kullanıcıyı ekle
            await _userService.AddUserAsync(user);

            // Kayıttan sonra login sayfasına yönlendir
            return RedirectToAction("Login");
        }
    }
}
