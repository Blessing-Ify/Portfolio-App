using System;
using System.ComponentModel.DataAnnotations;

namespace PortfolioApp.ViewModels
{
    public class WorkExperienceListViewModel
    {
        public int Id { get; set; }
        [Required]
        public string WorkExperiences { get; set; }
        [Required]
        public string Role { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public int Years { get; set; }
        
    }
}
