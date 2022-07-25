using PortfolioApp.Models;
using PortfolioApp.Repositories;
using PortfolioApp.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;

namespace PortfolioApp.Services
{
    public class ProjectService : IProjectService
    {
        private readonly IProjectRepository _project;
        private readonly IMapper _mapper;
        public ProjectService(IProjectRepository project, IMapper mapper)
        {
            _project = project;
            _mapper = mapper;
        }
        public async Task<bool> AddProject(ProjectListViewModel project)
        {
            var addProject = _mapper.Map<Project>(project);
            return await _project.Add(addProject);
        }

        public async Task<IEnumerable<Project>> Allproject()
        {
            return await _project.GetAll();
        }

        public async Task<bool> DeleteProject(int id)
        {
            //var item = await GetById(id); 
            return await _project.Delete(id);
        }

        public async Task<bool> EditProject(ProjectListViewModel project)
        {
            var editproject = _mapper.Map<Project>(project);
            return await _project.Update(editproject);
        } 

        public async Task<Project> GetById(int id)
        {
            return await _project.GetById(id);
        }
    }
}
