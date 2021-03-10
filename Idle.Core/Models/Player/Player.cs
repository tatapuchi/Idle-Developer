using Idle.Core.Models.Fields;
using Idle.Core.Models.Items;
using Idle.Core.Models.Jobs;
using Idle.Core.Models.Projects;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using static Idle.Core.Models.Fields.IField;
using static Idle.Core.Models.Items.Item;
using static Idle.Core.Models.Jobs.Job;
using static Idle.Core.Models.Projects.Project;

namespace Idle.Core.Models.Player
{
    //maybe add username password system
    public class Player
    {
        public Player()
        {

            Username = "0xB01b";
            XP = 0;
            Level = 1;
            Coins = 0;
            Languages = new SortedList<LanguageType, FieldDTO>();
            Frameworks = new SortedList<FrameworkType, FieldDTO>();
            Tools = new SortedList<ToolType, FieldDTO>();
            Inventory = new SortedList<ItemType, int>();
            Jobs = new SortedList<JobType, JobDTO>();
            Projects = new SortedList<ProjectType, ProjectDTO>();

        }

        public string Username { get; set; }
        public int XP { get; set; }
        public int Level { get; set; }
        public int Coins { get; set; }

        public SortedList<LanguageType, FieldDTO> Languages { get; set; }
        public SortedList<FrameworkType, FieldDTO> Frameworks { get; set; }
        public SortedList<ToolType, FieldDTO> Tools { get; set; }

        public SortedList<ItemType, int> Inventory { get; set; }

        public SortedList<JobType, JobDTO> Jobs { get; set; }

        public SortedList<ProjectType, ProjectDTO> Projects { get; set; }

        #region Field System
        public void AddLanguage(LanguageType type)
        {
            Info info = new Info();
            if (Languages.ContainsKey(type)) { return; }
            Languages.Add(type, info.GetLanguage(type).Convert());

        }

        public void AddFramework(FrameworkType type)
        {
            Info info = new Info();
            if (Frameworks.ContainsKey(type)) { return; }
            Frameworks.Add(type, info.GetFramework(type).Convert());
        }

        public void AddTool(ToolType type)
        {
            Info info = new Info();
            if (Tools.ContainsKey(type)) { return; }
            Tools.Add(type, info.GetTool(type).Convert());
        }

        public void AddJob(JobType type)
        {
            Info info = new Info();
            if (Jobs.ContainsKey(type)) { return; }
            Jobs.Add(type, info.GetJob(type).Convert());

        }

        public void RemoveJob(JobType type)
        {
            Jobs.Remove(type);
        }

        public void AddProject(ProjectType type)
        {
            Info info = new Info();
            if (Projects.ContainsKey(type)) { return; }
            Projects.Add(type, info.GetProject(type).Convert());
        }

        #endregion

        #region Inventory System
        public void AddItem(Item.ItemType type)
        {
            Info info = new Info();
            //add method that takes in name and gives back maxstackamount
            if (Inventory.ContainsKey(type))
            {
                if (info.GetItem(type).MaxStackAmount <= Inventory[type]) { return; }

                Inventory[type]++;
                return;
            }

            Inventory.Add(type, 1);

        }

        public void AddItem(Item item)
        {
            Info info = new Info();
            //add method that takes in name and gives back maxstackamount
            if (Inventory.ContainsKey(item.Type))
            {
                if (info.GetItem(item.Type).MaxStackAmount <= Inventory[item.Type]) { return; }

                Inventory[item.Type] = item.Amount;
                return;
            }

            Inventory.Add(item.Type, item.Amount);

        }

        public void RemoveItem(Item.ItemType type)
        {
            if (Inventory.ContainsKey(type))
            {
                if (Inventory[type] > 1)
                {
                    Inventory[type]--;
                    return;
                }

                Inventory.Remove(type);

            }

        }

        public void RemoveItem(Item item)
        {
            if (Inventory.ContainsKey(item.Type))
            {
                if (Inventory[item.Type] > 1)
                {
                    Inventory[item.Type]--;
                    return;
                }

                Inventory.Remove(item.Type);

            }

        }

        #endregion

        #region DTO System
        public PlayerDTO Convert()
        {
            PlayerDTO dto = new PlayerDTO
            {
                XP = XP,
                Level = Level,
                Coins = Coins,
                Jobs = Jobs,
                Projects = Projects,
                Languages = Languages,
                Frameworks = Frameworks,
                Tools = Tools,
                Inventory = Inventory,
                Username = Username
            };


            return dto;

        }

        public void Update(PlayerDTO dto)
        {
            XP = dto.XP;
            Level = dto.Level;
            Coins = dto.Coins;
            Jobs = dto.Jobs;
            Projects = dto.Projects;
            Languages = dto.Languages;
            Frameworks = dto.Frameworks;
            Tools = dto.Tools;
            Inventory = dto.Inventory;
            Username = dto.Username;
        }


        #endregion

        #region Conversion System
        //conversion from sortedlists to observablecollections and back
        public void UpdateLanguages(ObservableCollection<Language> collection) 
        {
            SortedList<LanguageType, FieldDTO> sortedList = new SortedList<LanguageType, FieldDTO>(Languages);
            foreach (KeyValuePair<LanguageType, FieldDTO> pair in sortedList)
            {
                foreach (Language language in collection)
                {
                    //ToString() must be done instead of using name property being there are outliers, eg: C# and CSharp is not the same thing
                    if (pair.Key.Equals(language.Type))
                    {
                        Languages[pair.Key] = language.Convert();
                    }
                }
            }
        }

        public void UpdateFrameworks(ObservableCollection<Framework> collection)
        {
            SortedList<FrameworkType, FieldDTO> sortedList = new SortedList<FrameworkType, FieldDTO>(Frameworks);
            foreach (KeyValuePair<FrameworkType, FieldDTO> pair in sortedList)
            {
                foreach (Framework framework in collection)
                {
                    //ToString() must be done instead of using name property being there are outliers, eg: C# and CSharp is not the same thing
                    if (pair.Key.Equals(framework.Type))
                    {
                        Frameworks[pair.Key] = framework.Convert();
                    }
                }
            }
        }

        public void UpdateTools(ObservableCollection<Tool> collection)
        {
            SortedList<ToolType, FieldDTO> sortedList = new SortedList<ToolType, FieldDTO>(Tools);
            foreach (KeyValuePair<ToolType, FieldDTO> pair in sortedList)
            {
                foreach (Tool tool in collection)
                {
                    //ToString() must be done instead of using name property being there are outliers, eg: C# and CSharp is not the same thing
                    if (pair.Key.Equals(tool.Type))
                    {
                        Tools[pair.Key] = tool.Convert();
                    }
                }
            }
        }

        public void UpdateJobs(ObservableCollection<Job> collection)
        {
            SortedList<JobType, JobDTO> sortedList = new SortedList<JobType, JobDTO>(Jobs);
            foreach (KeyValuePair<JobType, JobDTO> pair in sortedList)
            {
                foreach (Job job in collection)
                {
                    //ToString() must be done instead of using name property being there are outliers, eg: C# and CSharp is not the same thing
                    if (pair.Key.Equals(job.Type))
                    {
                        Jobs[pair.Key] = job.Convert();
                    }
                }
            }
        }

        public void UpdateProjects(ObservableCollection<Project> collection)
        {

            SortedList<ProjectType, ProjectDTO> sortedList = new SortedList<ProjectType, ProjectDTO>(Projects);
            foreach (KeyValuePair<ProjectType, ProjectDTO> pair in sortedList)
            {
                foreach (Project project in collection)
                {
                    //ToString() must be done instead of using name property being there are outliers, eg: C# and CSharp is not the same thing
                    if (pair.Key.Equals(project.Type))
                    {
                        Projects[pair.Key] = project.Convert();
                    }
                }
            }
        }


        public ObservableCollection<Language> GetLanguageCollection()
        {
            Info info = new Info();
            ObservableCollection<Language> collection = new ObservableCollection<Language>();
            foreach (KeyValuePair<LanguageType, FieldDTO> pair in Languages)
            {
                Language language = info.GetLanguage(pair.Key);
                language.Update(pair.Value);

                collection.Add(language);
            }

            return collection;
        }

        public ObservableCollection<Framework> GetFrameworkCollection()
        {
            Info info = new Info();
            ObservableCollection<Framework> collection = new ObservableCollection<Framework>();
            foreach (KeyValuePair<FrameworkType, FieldDTO> pair in Frameworks)
            {
                Framework framework = info.GetFramework(pair.Key);
                framework.Update(pair.Value);

                collection.Add(framework);
            }

            return collection;
        }

        public ObservableCollection<Tool> GetToolCollection()
        {
            Info info = new Info();
            ObservableCollection<Tool> collection = new ObservableCollection<Tool>();
            foreach (KeyValuePair<ToolType, FieldDTO> pair in Tools)
            {
                Tool tool = info.GetTool(pair.Key);
                tool.Update(pair.Value);

                collection.Add(tool);
            }

            return collection;
        }

        public ObservableCollection<Job> GetJobCollection()
        {
            Info info = new Info();
            ObservableCollection<Job> collection = new ObservableCollection<Job>();
            foreach (KeyValuePair<JobType, JobDTO> pair in Jobs)
            {
                Job job = info.GetJob(pair.Key);
                job.Update(pair.Value);

                collection.Add(job);
            }

            return collection;
        }

        public ObservableCollection<Project> GetProjectCollection()
        {
            Info info = new Info();
            ObservableCollection<Project> collection = new ObservableCollection<Project>();
            foreach (KeyValuePair<ProjectType, ProjectDTO> pair in Projects)
            {
                Project project = info.GetProject(pair.Key);
                project.Update(pair.Value);

                collection.Add(project);
            }

            return collection;
        }

        public ObservableCollection<Item> GetInventoryCollection()
        {
            Info info = new Info();
            ObservableCollection<Item> collection = new ObservableCollection<Item>();
            foreach (KeyValuePair<ItemType, int> pair in Inventory)
            {
                Item item = info.GetItem(pair.Key, pair.Value);

                collection.Add(item);
            }

            return collection;
        }

        #endregion

    }
}
