using Microsoft.AspNetCore.Mvc;
using PortfolioApp.Services;
using PortfolioApp.ViewModels;
using System.Threading.Tasks;
using System;
using PortfolioApp.Models;
using AutoMapper;
using PortfolioApp.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace PortfolioApp.Controllers
{
    public class WorkExperienceController : Controller
    {
        private readonly IWorkExperienceService _experience;
        private readonly PortfolioAppContext _context;

        public WorkExperienceController(IWorkExperienceService experience, PortfolioAppContext context)
        {
            _experience = experience;
            _context = context;
        }
        public async Task<ActionResult> IndexE()
        {
            IQueryable<WorkExperience> items = from i in _context.WorkExperiences orderby i.WorkExperienceId select i;
            List<WorkExperience> workExperience = await items.ToListAsync();
            return View(workExperience);
        }


        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            if (id == 0)
                return NotFound();
            var data = await _experience.GetById(id);
            return View(data);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(WorkExperienceListViewModel workExperience)
        {
            if (!ModelState.IsValid)
            {
                return View(workExperience);
            }
            else
            {
                await _experience.EditWorkExperience(workExperience);
                TempData["Success"] = "The item has been successfully Updated!";

            }

            return RedirectToAction("IndexE");
        }
        //Get
        public  IActionResult Add() => View();

        [HttpPost]
        public async Task<IActionResult> Add(WorkExperienceListViewModel workExperience)
        {
            if (ModelState.IsValid)
            {
                await _experience.AddWorkExperience(workExperience);
                TempData["Success"] = "The item has been successfully Created!";
            }
            return RedirectToAction("IndexE");
        }
      
        public async Task<IActionResult> Delete(int id)
        {
            if (ModelState.IsValid)
            {
                await _experience.DeleteWorkExperience(id);
                TempData["Success"] = "The details has been deleted successfully";
            }

            return RedirectToAction("IndexE");

        }

    }
}
