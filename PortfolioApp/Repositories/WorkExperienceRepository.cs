using Microsoft.EntityFrameworkCore;
using PortfolioApp.Data;
using PortfolioApp.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PortfolioApp.Repositories
{
    public class WorkExperienceRepository : IWorkExperienceRepository
    {
        //create a private field and inject the context to a constructor
        private readonly PortfolioAppContext _context;
        public WorkExperienceRepository(PortfolioAppContext context)
        {
            _context = context;
        }

        public async Task<bool> Save()
        {
            return await _context.SaveChangesAsync() > 0;
        }
        public async Task<bool> Add(WorkExperience entity)
        {
            _context.WorkExperiences.Add(entity);
            return await Save();
        }

        public async Task<bool> Delete(int id)
        {
            //first find the item
            var itemToDelete = await _context.WorkExperiences.FindAsync(id);
            //we need to confirm that something was found first b4 we delete
            if (itemToDelete == null)
            {
                throw new Exception("Not found");
            }
            _context.WorkExperiences.Remove(itemToDelete);
            return await Save();
        }

        public async Task<bool> Update(WorkExperience entity)
        {
            _context.WorkExperiences.Update(entity);
            return await Save();

        }
        public async Task<IEnumerable<WorkExperience>> GetAll()
        {
            return await _context.WorkExperiences.ToListAsync();
        }

        public async Task<WorkExperience> GetById(int id)
        {
            //return await _context.WorkExperiences.FirstOrDefaultAsync(x => x.WorkExperienceId == id);
            return await _context.WorkExperiences.FindAsync(id);
        }
    }
}
