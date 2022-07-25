using AutoMapper;
using PortfolioApp.Models;
using PortfolioApp.Repositories;
using PortfolioApp.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PortfolioApp.Services
{
    public class SkillService : ISkillService
    {
        private readonly ISkillRepository _skill;
        private readonly IMapper _mapper;
        public SkillService(ISkillRepository skill, IMapper mapper)
        {
            _skill = skill;
            _mapper = mapper;
        }
        public async Task<bool> AddSkill(SkillListViewModel skill)
        {
            var addSkill = _mapper.Map<Skill>(skill);
            return await _skill.Add(addSkill);
        }

        public async Task<IEnumerable<Skill>> Allskill()
        {
            return await _skill.GetAll();
        }

        public async Task<bool> DeleteSkill(int id)
        {
            //var item = await GetById(id);
            return await _skill.Delete(id);
        }

        public async Task<bool> EditSkill(SkillListViewModel skill)
        {
            var editskill = _mapper.Map<Skill>(skill);
            return await _skill.Update(editskill);
        }
        public async Task<Skill> GetById(int id)
        {
            return await _skill.GetById(id);
        }
    }
}
