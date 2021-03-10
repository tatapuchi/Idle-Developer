using Idle.Core.Models.Fields;
using Idle.Core.Models.Items;
using Idle.Core.Models.Jobs;
using Idle.Core.Models.Projects;
using System;
using System.Collections.Generic;
using System.Text;
using static Idle.Core.Models.Fields.IField;
using static Idle.Core.Models.Items.Item;
using static Idle.Core.Models.Jobs.Job;
using static Idle.Core.Models.Projects.Project;

namespace Idle.Core.Models
{
    public class Info
    {
        public Job GetJob(JobType type)
        {
            switch (type)
            {
                case JobType.Junior_Developer:
                    return new Job() { Title = "Junior Developer", Description = "Markup for the web", Salary = 120, Type = type };
                case JobType.Senior_Developer:
                    return new Job() { Title = "Senior Developer", Description = "Style Sheets for the web", Salary = 205, Type = type };
                case JobType.Tester:
                    return new Job() { Title = "Tester", Description = "Not the same as Java", Salary = 150, Type = type };

                default:
                    return null;
            }
        }

        public Project GetProject(ProjectType type)
        {
            switch (type)
            {
                case ProjectType.OS:
                    return new Project() { Title = "OS", Description = "Markup for the web", Income = 20, Type = type };
                case ProjectType.Website:
                    return new Project() { Title = "Webiste", Description = "Style Sheets for the web", Income = 25, Type = type };
                case ProjectType.Game:
                    return new Project() { Title = "Game", Description = "Not the same as Java", Income = 150, Type = type };

                default:
                    return null;
            }
        }

        #region Item Methods

        public Item GetItem(ItemType type)
        {
            switch (type)
            {
                case ItemType.GitHubEnterprise:
                    return new Item() { Name = "Github Enterprise", Type = type , rarity = Rarity.Legendary};
                case ItemType.GitHubOne:
                    return new Item() { Name = "Github One", Type = type, rarity = Rarity.Mythical };
                case ItemType.GitHubPro:
                    return new Item() { Name = "Github Pro", Type = type, rarity = Rarity.Epic };
                case ItemType.GitHubTeam:
                    return new Item() { Name = "Github Team", Type = type, rarity = Rarity.Rare };
                default:
                    return null;
            }

        }

        public Item GetItem(ItemType type, int amount)
        {
            switch (type)
            {
                case ItemType.GitHubEnterprise:
                    return new Item() { Name = "Github Enterprise", Type = type, rarity = Rarity.Legendary, Amount = amount};
                case ItemType.GitHubOne:
                    return new Item() { Name = "Github One", Type = type, rarity = Rarity.Mythical, Amount = amount };
                case ItemType.GitHubPro:
                    return new Item() { Name = "Github Pro", Type = type, rarity = Rarity.Epic, Amount = amount };
                case ItemType.GitHubTeam:
                    return new Item() { Name = "Github Team", Type = type, rarity = Rarity.Rare, Amount = amount };
                default:
                    return null;
            }

        }

        #endregion

        #region Field Methods
        public Language GetLanguage(LanguageType type)
        {
            switch (type)
            {
                case LanguageType.HTML:
                    return new Language() { Name = "HTML", Description = "Markup for the web", Cost = 20, Type = type};
                case LanguageType.CSS:
                    return new Language() { Name = "CSS", Description = "Style Sheets for the web", Cost = 25, Type = type };
                case LanguageType.JavaScript:
                    return new Language() { Name = "JavaScript", Description = "Not the same as Java", Cost = 150, Type = type };
                case LanguageType.Python:
                    return new Language() { Name = "Python", Description = "Snake Language", Cost = 200, Type = type };
                case LanguageType.PHP:
                    return new Language() { Name = "PHP", Description = "Backend", Cost = 150, Type = type };
                case LanguageType.C:
                    return new Language() { Name = "C", Description = "old language", Cost = 650, Type = type };
                case LanguageType.CPP:
                    return new Language() { Name = "C++", Description = "The ultimate", Cost = 1000, Type = type };
                case LanguageType.CSharp:
                    return new Language() { Name = "C#", Description = ".NET Language", Cost = 800, Type = type };
                case LanguageType.Java:
                    return new Language() { Name = "Java", Description = "Cool language", Cost = 1000, Type = type };
                case LanguageType.Kotlin:
                    return new Language() { Name = "Kotlin", Description = "android Language", Cost = 800, Type = type };

                default:
                    return null;
            }
        }

        public Framework GetFramework(FrameworkType type)
        {
            switch (type)
            {
                case FrameworkType.BootStrap:
                    return new Framework() { Name = "BootStrap", Description = "BootStrap", Cost = 20, Type = type };
                case FrameworkType.Nodejs:
                    return new Framework() { Name = "Node.js", Description = "Style Sheets for the web", Cost = 25, Type = type };
                case FrameworkType.React:
                    return new Framework() { Name = "React", Description = "Not the same as Java", Cost = 150, Type = type };
                case FrameworkType.Angular:
                    return new Framework() { Name = "Angular", Description = "Snake Language", Cost = 200, Type = type };
                case FrameworkType.Vue:
                    return new Framework() { Name = "Vue", Description = "Backend", Cost = 150, Type = type };
                case FrameworkType.Rails:
                    return new Framework() { Name = "Rails", Description = "old language", Cost = 650, Type = type };
                case FrameworkType.LibGDX:
                    return new Framework() { Name = "LibGDX", Description = "The ultimate", Cost = 1000, Type = type };
                case FrameworkType.Flutter:
                    return new Framework() { Name = "Flutter", Description = ".NET Language", Cost = 800, Type = type };
                case FrameworkType.Xamarin:
                    return new Framework() { Name = "Xamarin", Description = ".NET Language", Cost = 800, Type = type };

                default:
                    return null;
            }
        }

        public Tool GetTool(ToolType type)
        {
            switch (type)
            {
                case ToolType.GitHub:
                    return new Tool() { Name = "GitHub", Description = "BootStrap", Cost = 20, Type = type };
                case ToolType.Jenkins:
                    return new Tool() { Name = "Jenkins", Description = "Style Sheets for the web", Cost = 25, Type = type };
                case ToolType.Trello:
                    return new Tool() { Name = "Trello", Description = "Not the same as Java", Cost = 150, Type = type };
                case ToolType.PyCharm:
                    return new Tool() { Name = "PyCharm", Description = "Snake Language", Cost = 200, Type = type };
                case ToolType.VSCode:
                    return new Tool() { Name = "VSCode", Description = "Backend", Cost = 150, Type = type };
                case ToolType.Atom:
                    return new Tool() { Name = "Atom", Description = "old language", Cost = 650, Type = type };

                default:
                    return null;
            }
        }
        #endregion

    }
}
