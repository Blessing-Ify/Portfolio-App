using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PortfolioApp.Models;
using PortfolioApp.ViewModels;
using System.Threading.Tasks;

namespace PortfolioApp.Controllers
{
    public class AccountController : Controller
    {
        //for us to be able to check if email exists, we need the userManager
        //we inject the usermanager in charge of emails provided
        //by Identity to a constructor
        //also the signin manager too.  
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        
        //after getting the inputs, we need to post it to the
        //database using the loginviewmodel fields then check out for validations
        [HttpPost]
        [ValidateAntiForgeryToken] 
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl)
        {
            // if Modelstate is not valid, return View( model) means that
            // if whatever inputed is not valid, the validation from the model
            // or viewmodel would be returned
            if (!ModelState.IsValid)
                return View(model); 

            //check if email exist
            var user = await _userManager.FindByEmailAsync(model.Email); //(model.Email) means that email is in model an instance of LoginModel
            if(user == null)
            {
                ModelState.AddModelError("", "Invalid credential");
                return View(model); //because the error will be in the model
            }
            //else if it exists, we check for password
            var result = await _signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe , false); //it takes different parameters
             if(!result.Succeeded)
            {
                ModelState.AddModelError("", "Invalid credential");
                return View(model); //because the error will be in the model
            }
            //else
            if(!string.IsNullOrEmpty(returnUrl))
            {
                return LocalRedirect(returnUrl);
            }
           return RedirectToAction("Index", "Portfolio"); //(action, controller)
          //Return LocalRedirect(returnUrl); //for the url
        }
        [HttpPost]
        public async Task<IActionResult> Logout()
        { 
            //check if user is signed in first
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Portfolio"); 
        }
    }
}
