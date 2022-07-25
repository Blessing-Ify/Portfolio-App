using System.ComponentModel.DataAnnotations;

namespace PortfolioApp.ViewModels
{
    public class SkillListViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Skills { get; set; }
    }
}
