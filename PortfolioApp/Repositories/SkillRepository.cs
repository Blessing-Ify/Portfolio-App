using Microsoft.EntityFrameworkCore;
using PortfolioApp.Data;
using PortfolioApp.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PortfolioApp.Repositories
{
    public class SkillRepository : ISkillRepository
    {
        //create a private field and inject the context to a constructor
        private readonly PortfolioAppContext _context;
        public SkillRepository(PortfolioAppContext context)
        {
            _context = context;
        }

        public async Task<bool> Save()
        {
            return await _context.SaveChangesAsync() > 0;
        }
        public async Task<bool> Add(Skill entity)
        {
            _context.Skills.Add(entity);
            return await Save();
        }

        public async Task<bool> Delete(int id)
        {
            //first find the item
            var itemToDelete = await _context.Skills.FindAsync(id);
            //we need to confirm that something was found first b4 we delete
            if (itemToDelete == null)
            {
                throw new Exception("Not found");
            }
            _context.Skills.Remove(itemToDelete);
            return await Save();
        }

        public async Task<bool> Update(Skill entity)
        {
            _context.Skills.Update(entity);
            return await Save();

        }
        public async Task<IEnumerable<Skill>> GetAll()
        {
            return await _context.Skills.ToListAsync();
        }

        public async Task<Skill> GetById(int id)
        {
            //return await _context.Skills.FirstOrDefaultAsync(x => x.SkillId == id);
            return await _context.Skills.FindAsync(id);
        }
    }
}
