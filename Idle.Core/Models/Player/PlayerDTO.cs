using Idle.Core.Models.Fields;
using Idle.Core.Models.Jobs;
using Idle.Core.Models.Projects;
using System;
using System.Collections.Generic;
using System.Text;
using static Idle.Core.Models.Fields.IField;
using static Idle.Core.Models.Items.Item;
using static Idle.Core.Models.Jobs.Job;
using static Idle.Core.Models.Projects.Project;

namespace Idle.Core.Models.Player
{
    public class PlayerDTO
    {
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
    }
}
