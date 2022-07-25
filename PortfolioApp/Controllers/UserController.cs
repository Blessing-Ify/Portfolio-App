using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PortfolioApp.Models;
using PortfolioApp.ViewModels;
using System.Threading.Tasks;

namespace PortfolioApp.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager<User> _userManager; //remember that User here is inheriting Identity user
        private readonly SignInManager<User> _signInManager;
        public UserController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
    
        
        [HttpGet]
        public IActionResult CreateUser()
        {
            return View();
        }

        [HttpPost] 
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateUser(AddUserViewModel model)// we need to use the addviewmodel for us to create an account for user
        {
            if(!ModelState.IsValid)
                return View(model); //return the model with the restriction on it

            //check if email exist
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user != null)//if the email is existing already
            {
                ModelState.AddModelError("", "Email already exists!");
                return View(model);
            }
            //else create user by first assigning the viewmodel inputed fields to the Model which goes to database
            var UserToAdd = new User
            { 
                UserName = model.Email,//rembember to add username even if its not in your model but b/c its in the usermanager
                Lastname = model.LastName,
                Firstname = model.FirstName,
                Email = model.Email
                //no need to put password blc the identity manager will hash it...
            };
            // create user
            var result = await _userManager.CreateAsync(UserToAdd, model.Password);
            if (!result.Succeeded) 
            {
                SetErrorMessage(result);
                return View(model);
            }
            //add role to user(define access)
            /*var roleResult = await _userManager.AddToRoleAsync(UserToAdd, "Decadev");
            if (!roleResult.Succeeded)
            {
               SetErrorMessage(roleResult);
                return View(model);
            }*/

            return RedirectToAction("Index", "Portfolio"); //Index action,Home controller
        }
        //a non action method
        public void SetErrorMessage(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(error.Code, error.Description);
            }
        }
    }
}
