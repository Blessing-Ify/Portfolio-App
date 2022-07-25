using PortfolioApp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioApp.Repositories
{
    public interface IProjectRepository
    {
        //we need the whole entity to create hence it takes the type project
        Task<bool> Add(Project entity);
        //same with update
        Task<bool> Update(Project entity);
        //you need the id to delete
        Task<bool> Delete(int id);
        //we need a collection of project since we are getting all
        Task<IEnumerable<Project>> GetAll();
        //this is for a single searching
        Task<Project> GetById(int id);
        //we need to save anything we get or find
        Task<bool> Save();
    }
}