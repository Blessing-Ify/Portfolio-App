using PortfolioApp.Models;
using PortfolioApp.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PortfolioApp.Services
{
    public interface ISkillService
    {
        Task<IEnumerable<Skill>> Allskill();
        Task<bool> AddSkill(SkillListViewModel skill);
        Task<bool> EditSkill(SkillListViewModel skill);
        Task<bool> DeleteSkill(int id);
        Task<Skill> GetById(int id);
    }
}