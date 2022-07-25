using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PortfolioApp.Data;
using PortfolioApp.Models;
using PortfolioApp.ViewModels;
using System.Linq;


namespace PortfolioApp.Controllers
{
    public class AdminController : Controller
    {
       /* private readonly SignInManager<User> _signInManager;
        private readonly PortfolioAppContext _context;
        public AdminController(PortfolioAppContext context, SignInManager<User> signInManager)
        {
            _context = context;
            _signInManager = signInManager;
        }

        [Authorize]
        public IActionResult Dashboard()
        {
            DashboardViewModel dashboard = new()
            {
                WorkExperiences = _context.WorkExperiences.ToList(),
                Skills = _context.Skills.ToList(),
                Projects = _context.Projects.ToList()
            };


            return View(dashboard);

        }*/
        [Authorize]
        public IActionResult Dashboard()
        {
            return View();
        }
    }
}
