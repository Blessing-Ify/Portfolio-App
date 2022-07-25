using PortfolioApp.Models;
using PortfolioApp.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PortfolioApp.Services
{
    public interface IProjectService
    {
        Task<IEnumerable<Project>> Allproject();
        Task<bool> AddProject(ProjectListViewModel project);
        Task<bool> EditProject(ProjectListViewModel project);
        Task<bool> DeleteProject(int id);
        Task<Project> GetById(int id);

    }
}
