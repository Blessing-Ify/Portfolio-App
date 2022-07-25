using System;

namespace PortfolioApp.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }

        public User User { get; set; } //navigation property
    }
}
  