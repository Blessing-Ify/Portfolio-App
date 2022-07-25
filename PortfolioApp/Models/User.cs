using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PortfolioApp.Models
{
    public class User : IdentityUser
    {
        //because of the inherented identityuser, no need for id and email cause it has been provides already 
        /*[Key]
        public int Id { get; set; }*/
        [Required]
        [StringLength(30, ErrorMessage ="First name should be between 2 and 30", MinimumLength =2)]
        public string Firstname { get; set; }
        [Required]
        [StringLength(30, ErrorMessage = "Last name should be between 2 and 30", MinimumLength = 2)]
        public string Lastname { get; set; }
        /*[Required]
        [EmailAddress(ErrorMessage = "Invalid email format!")]
        public string Email { get; set; }*/
        public List<Project> Project { get; set; }
        public List<Skill> Skill { get; set; }
        public List<WorkExperience> WorkExperience { get; set; }

        //create a constructor to instantiate your lists 
        public User()
        {
            Project = new List<Project>();
            Skill = new List<Skill>();
            WorkExperience = new List<WorkExperience>();
        }
    }
}
