using PortfolioApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PortfolioApp.Repositories
{
    public interface IWorkExperienceRepository
    {
        Task<bool> Add(WorkExperience entity);
        Task<bool> Update(WorkExperience entity);
        Task<bool> Delete(int id);
        Task<IEnumerable<WorkExperience>> GetAll();
        Task<WorkExperience> GetById(int id);
        Task<bool> Save();
    }
}