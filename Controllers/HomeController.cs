using Microsoft.AspNetCore.Mvc;
using CVProject.Models;

namespace CVProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new PortfolioViewModel
            {
                Projects = new List<ProjectItem>
                {
                    new ProjectItem
                    {
                        Title = "Ames Housing Price Predictor (92.5% R²)",
                        Description = "Advanced regression model predicting residential prices in Ames, Iowa. Optimized via Lasso (L1) Regularization to automate feature selection and mitigate overfitting.",
                        TechStack = "Python, Scikit-Learn, Pandas, Seaborn",
                        GitHubUrl = "https://github.com/pfunzom61-cmd/HousePriceProg.git",
                        KeyAchievement = "Achieved MAE of ~$15,270 by engineering 'Power Features' like Total_SF and handling luxury segment heteroscedasticity."
                    },
                    new ProjectItem
                    {
                        Title = "Contract Monthly Claim System",
                        Description = "An ASP.NET Core MVC management system designed to track and validate monthly claims. Features a clean architectural pattern for maintainability and scalability.",
                        TechStack = "C#, ASP.NET Core MVC, Entity Framework, Git",
                        GitHubUrl = "https://github.com/Mulaudzi-Pfunzo/PROG6212_POEPART1_PM.git",
                        KeyAchievement = "Followed strict SDLC and version control practices to ensure a traceable history of claim approval workflows."
                    }
                }
            };
            return View(model);
        }
    }
}