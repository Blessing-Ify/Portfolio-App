using Microsoft.EntityFrameworkCore;
using PortfolioApp.Data;
using PortfolioApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioApp.Repositories
{
    public interface ILearningRepository
    {
        //we need the entity hence it takes the class project
        Task<bool> Create(Project proj);
        //same with update
        Task<bool> Update(Project proj);
        //you need the id to delete
        Task<bool> Delete(string id);
        //we need a collection of project since we are getting all
        Task <IEnumerable<Project>> GetAll();
        //this is for a single searching
        Task<Project> Get(string id);
        //we need to save anything we get or find
        Task <bool> save();
    }
    public class Learning : ILearningRepository
    {
        private readonly PortfolioAppContext _context;

        public Learning(PortfolioAppContext context)
        {
            _context = context;
        }
        public async Task<bool> Create(Project proj)
        {
            await _context.Projects.AddAsync(proj);
            return await save();
            
        }

        public async Task<bool> Delete(string id)
        {
           var Id=  Convert.ToInt32(id);
            var delete = await _context.Projects.FindAsync(Id);
            //we need to confirm that something was found first b4 we delete
            if (delete == null)
            {
                throw new Exception("To/sin");
            }
            //else
             _context.Projects.Remove(delete);
            return await save();
        }

        public async Task<Project> Get(string id)
        {
            var Id = Convert.ToInt32(id);
            return await _context.Projects.FindAsync(Id);
        }

        public async Task<IEnumerable<Project>> GetAll()
        {
            return await _context.Projects.ToListAsync();
        }

        public async Task<bool> save()
        {
           return await _context.SaveChangesAsync() > 0? true: false;   
        }

        public  async Task<bool> Update(Project proj)
        {
             _context.Projects.Update(proj);
            return await save();
        }
    }
}
