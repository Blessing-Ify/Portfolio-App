using Microsoft.AspNetCore.Mvc;
using PortfolioApp.Services;
using PortfolioApp.ViewModels;
using System.Threading.Tasks;
using System;
using PortfolioApp.Models;
using PortfolioApp.Data;
using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PortfolioApp.Controllers
{
    public class SkillController : Controller
    {
        private readonly ISkillService _skill;
        private readonly PortfolioAppContext _context;

        public SkillController(ISkillService skill, PortfolioAppContext context)
        {
            _skill = skill;
            _context = context;
        }
        public async Task<ActionResult> IndexS()
        {
            var items = from i in _context.Skills orderby i.SkillId select i;
            List<Skill> skill = await items.ToListAsync();
            return View(skill);
        }


        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            if (id == 0)
                return NotFound();
            var data = await _skill.GetById(id);
            return View(data);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(SkillListViewModel skill)
        {
            if (!ModelState.IsValid)
            {
                return View(skill);
            }
            else
            {
                await _skill.EditSkill(skill);
                TempData["Success"] = "The item has been successfully Updated!";

            }

            return RedirectToAction("IndexS");
        }

        public IActionResult Add() => View();

        [HttpPost]
        public async Task<IActionResult> Add(SkillListViewModel skill)
        {
            if (ModelState.IsValid)
            {
                await _skill.AddSkill(skill);
                TempData["Success"] = "The item has been successfully Created!";
            }
            return RedirectToAction("IndexS");
        }
        public async Task<IActionResult> Delete(int id)
        {
            if (ModelState.IsValid)
            {
                await _skill.DeleteSkill(id);
                TempData["Success"] = "The details has been deleted successfully";
            }

            return RedirectToAction("IndexS");

        }
    }
}
