using AutoMapper;
using PortfolioApp.Models;
using PortfolioApp.Repositories;
using PortfolioApp.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PortfolioApp.Services
{
    public class WorkExperienceService : IWorkExperienceService
    {
        private readonly IWorkExperienceRepository _workExperience;
        private readonly IMapper _mapper;
        public WorkExperienceService(IWorkExperienceRepository workExperience, IMapper mapper)
        {
            _workExperience = workExperience;
            _mapper = mapper;
        }
        public async Task<bool> AddWorkExperience(WorkExperienceListViewModel workExperience)
        {
            var addWorkExperience = _mapper.Map<WorkExperience>(workExperience);
            return await _workExperience.Add(addWorkExperience);
        }

        public async Task<IEnumerable<WorkExperience>> AllworkExperience()
        {
            return await _workExperience.GetAll();
        }

        public async Task<bool> DeleteWorkExperience(int id)
        {
            //var item = await GetById(id);
            return await _workExperience.Delete(id);

        }

        public async Task<bool> EditWorkExperience(WorkExperienceListViewModel workExperience)
        {
            var editworkExperience = _mapper.Map<WorkExperience>(workExperience);
            return await _workExperience.Update(editworkExperience);
        }
        public async Task<WorkExperience> GetById(int id)
        {
            return await _workExperience.GetById(id);
        }
    }
}