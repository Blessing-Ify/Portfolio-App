using PortfolioApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PortfolioApp.Repositories
{
    public interface ISkillRepository
    {
        Task<bool> Add(Skill entity);
        Task<bool> Update(Skill entity);
        Task<bool> Delete(int id);
        Task<IEnumerable<Skill>> GetAll();
        Task<Skill> GetById(int id);
        Task<bool> Save();
    }
}