namespace PortfolioApp.Models
{
    public class Skill
    {
        public int SkillId { get; set; }
        public string Skills { get; set; }

        public User User { get; set; } //navigation property
       // public int UserId { get; set; } 
    }
}
