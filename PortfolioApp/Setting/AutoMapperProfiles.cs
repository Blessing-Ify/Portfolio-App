using AutoMapper;
using PortfolioApp.Models;
using PortfolioApp.ViewModels;

namespace PortfolioApp.Setting
{
    public class AutoMapperProfiles: Profile
    {
            public AutoMapperProfiles()
            {
                CreateMap<Project, ProjectListViewModel>().ReverseMap();
                CreateMap<Skill, SkillListViewModel>().ReverseMap();
                CreateMap<WorkExperience, WorkExperienceListViewModel>().ReverseMap();
            }
    }
}
