using System;
using System.ComponentModel.DataAnnotations;

namespace PortfolioApp.ViewModels
{
    public class ProjectListViewModel
    {

        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        //public string ProjectLink { get; set; }
        public DateTime Year { get; set; } = DateTime.Now;
    }
}
