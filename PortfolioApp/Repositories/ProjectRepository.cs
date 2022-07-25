using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortfolioApp.Data;
using PortfolioApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioApp.Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        //create a private field and inject the context to a constructor
        private readonly PortfolioAppContext _context;
        public ProjectRepository(PortfolioAppContext context)
        {
            _context = context;
        }
        //public List<Project> MyProjects => throw new System.NotImplementedException();

       public async Task<bool> Save()
        {
            return await _context.SaveChangesAsync() > 0;
        }
        public async Task<bool> Add(Project entity)
        {
            _context.Projects.Add(entity);
            return await Save();
        }

        public async Task<bool> Delete(int id)
        {
            //first find the item
            var itemToDelete = await _context.Projects.FindAsync(id);
            //we need to confirm that something was found first b4 we delete
            if (itemToDelete == null)
            {
                throw new Exception("Not found");
            }
            _context.Projects.Remove(itemToDelete);
            return await Save();
        }

        public async Task<bool> Update(Project entity)
        {
           _context.Projects.Update(entity);
          return await Save();
                
        }
        public async Task<IEnumerable<Project>> GetAll()
        {
            return await _context.Projects.ToListAsync();
        }

        public async Task<Project> GetById(int id) 
        {
            //return await _context.Projects.FirstOrDefaultAsync(x => x.ProjectId == id);
            return await _context.Projects.FindAsync(id);
        }
    }
}