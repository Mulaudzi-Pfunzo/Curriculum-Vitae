using System.Collections.Generic;

namespace CVProject.Models


{
    public class ProjectItem
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string TechStack { get; set; }
        public string GitHubUrl { get; set; }
        public string KeyAchievement { get; set; }
    }

    public class PortfolioViewModel
    {
        public string FullName { get; set; } = "Pfunzo Mulaudzi";
        public string ProfessionalTitle { get; set; } = "Aspiring Data Scientist | Final-Year IT Student";
        public string Email { get; set; } = "Pfunzo574@gmail.com";
        public string Location { get; set; } = "Centurion, Gauteng";
        public List<ProjectItem> Projects { get; set; }
    }
}