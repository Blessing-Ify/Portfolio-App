using Microsoft.AspNetCore.Mvc;
using PortfolioApp.Services;
using PortfolioApp.ViewModels;
using System.Threading.Tasks;
using System;
using PortfolioApp.Models;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using PortfolioApp.Data;
using AutoMapper;

namespace PortfolioApp.Controllers
{
    public class ProjectController : Controller
    {
        private readonly IProjectService _project;
        private readonly PortfolioAppContext _context;
 
        public ProjectController(IProjectService project, PortfolioAppContext context)
        {
            _project = project;
            _context = context;
        }

        public async Task<ActionResult> IndexP()
        {
            IQueryable<Project> items = from i in _context.Projects orderby i.ProjectId select i;
            List<Project> project = await items.ToListAsync();
            return View(project);
        }
        /*public async Task<ActionResult> IndexP()
        {
            IQueryable<ProjectListViewModel> items = from i in _context.ProjectListViewModel orderby i.Id select i;
            List<ProjectListViewModel> project = await items.ToListAsync();
            return View(project);
        }*/

        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            if (id == 0)
                return NotFound();
            var data = await _project.GetById(id);
            return View(data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(ProjectListViewModel project)
        {
            if (!ModelState.IsValid)
            {
                return View(project);
            } 
            else
            {
                await _project.EditProject(project);
                TempData["Success"] = "The item has been successfully Updated!";

            }

            return RedirectToAction("IndexP");
        }

        public IActionResult Add() => View();

        [HttpPost]
        public async Task<IActionResult> Add(ProjectListViewModel project)
        {
            if (ModelState.IsValid)
            {
                await _project.AddProject(project);
                TempData["Success"] = "Item successfully Added";
            }
            return RedirectToAction("IndexP");
        }
        public async Task<IActionResult> Delete(int id)
        {
            if (ModelState.IsValid)
            {
                await _project.DeleteProject(id);
                TempData["Success"] = "Item successfully deleted";
            }

            return RedirectToAction("IndexP");

        }
    }
}
