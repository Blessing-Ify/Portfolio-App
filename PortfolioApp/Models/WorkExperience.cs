namespace PortfolioApp.Models
{
    public class WorkExperience
    {
        public int WorkExperienceId { get; set; }
        public string WorkExperiences { get; set; }

        public string Role { get; set; }

        public string Location { get; set; }    

        public int Years { get; set; }  

        public User User { get; set; } //navigation property
    }
}

