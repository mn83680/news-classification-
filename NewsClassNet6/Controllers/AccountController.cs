using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using NewsClassNet6.Models;
using NewsClassNet6.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace NewsClassNet6.Controllers
{
    public class AccountController : Controller
    {
        // ingrction 
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInMAnager;
        public AccountController
                (UserManager<ApplicationUser> _UserManager,
                SignInManager<ApplicationUser> _SignInMAnager)
        {
            userManager = _UserManager;
            signInMAnager = _SignInMAnager;
        }

//..................................................................................Admin........................
        //Only the Admin sees these
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult AddAdmin()
        {
            return View();
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task <IActionResult> AddAdmin(RegisterUserViewModel newUserVM)
        {

            if (ModelState.IsValid)
            {
                //create user account
                ApplicationUser userModel = new ApplicationUser();
                userModel.UserName = newUserVM.Name;
                userModel.PasswordHash = newUserVM.Password;
                userModel.Address = newUserVM.Address;
                IdentityResult result = await userManager.CreateAsync(userModel, newUserVM.Password);
                if (result.Succeeded == true)
                {
                    //assign to role
                    await userManager.AddToRoleAsync(userModel, "Admin");
                    //creat cookie
                    await signInMAnager.SignInAsync(userModel, false);
                    return RedirectToAction("Index", "User");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }

            }
            return View(newUserVM);
        }
//..................................................................................Publisher........................
        //Only the Admin sees these
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult AddPublisher()
        {
            return View();
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> AddPublisher(RegisterUserViewModel newUserVM)
        {

            if (ModelState.IsValid)
            {
                //create user account
                ApplicationUser userModel = new ApplicationUser();
                userModel.UserName = newUserVM.Name;
                userModel.PasswordHash = newUserVM.Password;
                userModel.Address = newUserVM.Address;
                IdentityResult result = await userManager.CreateAsync(userModel, newUserVM.Password);
                if (result.Succeeded == true)
                {
                    //assign to role
                    await userManager.AddToRoleAsync(userModel, "Publisher");
                    //creat cookie
                    await signInMAnager.SignInAsync(userModel, false);
                    return RedirectToAction("Index", "User");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }

            }
            return View(newUserVM);
        }
        //...........................................................................lpgin.......................
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel UserVm)
        {
            if (ModelState.IsValid)
            {
                //check User Name
                ApplicationUser userModel = await userManager.FindByNameAsync(UserVm.Name);
                if (userModel != null)
                {
                    //check Pass
                    bool found = await userManager.CheckPasswordAsync(userModel, UserVm.Password);
                    if (found)
                    {
                        //ckokie
                        //    await signInMAnager.SignInAsync(userModel, UserVm.RememberMe);
                        List<Claim> Claims = new List<Claim>();
                        Claims.Add(new Claim("Address", userModel.Address));
                        await signInMAnager.SignInWithClaimsAsync
                            (userModel, UserVm.RememberMe, Claims);
                        return RedirectToAction("News", "News");
                    }
                }
                ModelState.AddModelError("", "Username and password invalid");
            }
            return View(UserVm);
        }
        //...........................................................................Register..............
        [HttpGet]//<a href>
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]//<a href>
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterUserViewModel newUserVM)
        {
            if (ModelState.IsValid)
            {
                //create user account
                ApplicationUser userModel = new ApplicationUser();
                userModel.UserName = newUserVM.Name;
                userModel.PasswordHash = newUserVM.Password;
                userModel.Address = newUserVM.Address;
                IdentityResult result = await userManager.CreateAsync(userModel, newUserVM.Password);
                if (result.Succeeded == true)
                {
                    //creat cookie
                    await signInMAnager.SignInAsync(userModel, false);
                    return RedirectToAction("Index", "News");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }

            }
            return View(newUserVM);
        }
        public async Task<IActionResult> Logout()
        {
            await signInMAnager.SignOutAsync();
            return RedirectToAction("Login", "Account");
        }
    }
}
