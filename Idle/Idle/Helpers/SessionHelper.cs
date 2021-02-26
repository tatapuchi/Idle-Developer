using Idle.Core.Models;
using Idle.Core.Models.Fields;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Idle.Helpers
{
    //This class should contain static helper methods to calculate time taken for a session, XP earned, etc.
    public static class SessionHelper
    {
        public static ObservableCollection<Field> GetLanguageList(SortedList<string, FieldDTO> sortedlist)
        {
            ObservableCollection<Field> languagecollection = new ObservableCollection<Field>();
            foreach(KeyValuePair<string, FieldDTO> pair in sortedlist)
            {
                if (Languages.IsLanguage(pair.Key))
                {
                    Languages language = Languages.GetLanguage(pair.Key);
                    language.UpdateFromDTO(pair.Value);

                    languagecollection.Add(language);
                }
            }

            return languagecollection;

        }

        public static ObservableCollection<Field> GetFrameworkList(SortedList<string, FieldDTO> sortedlist)
        {
            ObservableCollection<Field> frameworkcollection = new ObservableCollection<Field>();
            foreach (KeyValuePair<string, FieldDTO> pair in sortedlist)
            {
                if (Frameworks.IsFramework(pair.Key))
                {
                    Frameworks framework = Frameworks.GetFramework(pair.Key);
                    framework.UpdateFromDTO(pair.Value);

                    frameworkcollection.Add(framework);
                }
            }

            return frameworkcollection;

        }

        public static ObservableCollection<Field> GetToolList(SortedList<string, FieldDTO> sortedlist)
        {
            ObservableCollection<Field> toolcollection = new ObservableCollection<Field>();
            foreach (KeyValuePair<string, FieldDTO> pair in sortedlist)
            {
                if (Tools.IsTool(pair.Key))
                {
                    Tools tool = Tools.GetTool(pair.Key);
                    tool.UpdateFromDTO(pair.Value);

                    toolcollection.Add(tool);
                }
            }

            return toolcollection;

        }

        public static List<Item> GetInventory(SortedList<string, int> sortedlist)
        {
            foreach(KeyValuePair<string, int> pair in sortedlist)
            {

            }

            return null;
        }

    }

}
