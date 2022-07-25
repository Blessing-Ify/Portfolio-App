using PortfolioApp.Models;
using PortfolioApp.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PortfolioApp.Services
{
    public interface IWorkExperienceService
    {
        Task<IEnumerable<WorkExperience>> AllworkExperience();
        Task<bool> AddWorkExperience(WorkExperienceListViewModel workExperience);
        Task<bool> EditWorkExperience(WorkExperienceListViewModel workExperience);
        Task<bool> DeleteWorkExperience(int id);
        Task<WorkExperience> GetById(int id);
    }
}
