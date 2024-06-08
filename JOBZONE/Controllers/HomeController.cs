using JOBZONE.Models;
using JOBZONE.Services;
using JOBZONE.Services.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace JOBZONE.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<UserModel> _userManager;       
        private readonly SignInManager<UserModel> _signInManager;
        

        public HomeController(ILogger<HomeController> logger, UserManager<UserModel> userManager, SignInManager<UserModel> signInManager)
        {
            _logger = logger;
            _userManager = userManager;
            _signInManager= signInManager;
        }

        public IActionResult Index()
        {
            return View(); 
            
        }

        public IActionResult LoginPage()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(Register userData)
        {
            if(!ModelState.IsValid)
            {
                return View(userData);
            }
            var newUser = new UserModel
            {
                UserName = userData.Email,
                Email = userData.Email,
                Name = userData.Name,
                Surname = userData.SurName,
                PhoneNumber = userData.Telephone
            };
            var result = await _userManager.CreateAsync(newUser,userData.Password);    
            if(!result.Succeeded)
            {
                foreach(var error in result.Errors) 
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
                return View(userData);
            }

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> LoginPage(Login userData)
        {
            if(!ModelState.IsValid)
            {
                return View(userData);
            }
            var result = await _signInManager.PasswordSignInAsync(userData.Email, userData.Password,true,false);
            if (!result.Succeeded)
            {
                ModelState.AddModelError(string.Empty, "Nie prawidłowy login lub hasło!");
                return View();
            }
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}