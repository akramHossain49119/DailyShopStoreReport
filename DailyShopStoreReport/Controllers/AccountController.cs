using System;
using System.Threading.Tasks;
using DailyShopStoreReport.Data;
using DailyShopStoreReport.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using DailyShopStoreReport.Models; 

namespace DailyShopStoreReport.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<AppUser>_userManager; 
        private readonly SignInManager<AppUser>_signInManager;

        //string spAccountant = "SuperAccountant";
        //string srAccountant = "SrAccountant";
        //string jrAccountant = "JrAccountant";


        //string passwordSp = "P@$$w0rdSp";
        //string password = "P@$$w0rd";

        public AccountController(ApplicationDbContext context,UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
             _context = context;
             _userManager = userManager;
             _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(loginViewModel.Email, loginViewModel.Password, loginViewModel.RememberMe, false);

                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Dashboard");
                }
                ModelState.AddModelError(string.Empty, "Invalid login attempt");
            }
            return View(loginViewModel);
        }


        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "LandingPage");
        }



       [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

       
    } 

}