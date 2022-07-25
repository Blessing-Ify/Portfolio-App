using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PortfolioApp.Data;
using PortfolioApp.Models;
using PortfolioApp.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioApp.Controllers
{
    public class PortfolioController : Controller
    {
        private readonly ILogger<PortfolioController> _logger;
        private readonly IProjectService _project;
        private readonly PortfolioAppContext _context;

        public PortfolioController(ILogger<PortfolioController> logger, IProjectService project, PortfolioAppContext context)
        {
            _logger = logger;
            _project = project;
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public async Task<ActionResult> ProjectIndex()
        {
            IQueryable<Project> items = from i in _context.Projects orderby i.ProjectId select i;
            List<Project> project = await items.ToListAsync();
            return View(project);
        }
        public async Task<ActionResult> SkillIndex()
        {
            IQueryable<Skill> items = from i in _context.Skills orderby i.SkillId select i;
            List<Skill> skill = await items.ToListAsync();
            return View(skill);
        } public async Task<ActionResult> ExperienceIndex()
        {
            IQueryable<WorkExperience> items = from i in _context.WorkExperiences orderby i.WorkExperienceId select i;
            List<WorkExperience> workExperience = await items.ToListAsync();
            return View(workExperience);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
