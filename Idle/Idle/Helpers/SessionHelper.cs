using Idle.Core.Models;
using Idle.Core.Models.Fields;
using Idle.Core.Models.Player;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Idle.Helpers
{
    //This class should contain static helper methods to calculate time taken for a session, XP earned, etc.
    public static class SessionHelper
    {




        //Change this, this is very bad?
        public static void UpdateFields(ObservableCollection<Languages> collection)
        {

            SortedList<string, FieldDTO> fields = new SortedList<string, FieldDTO>(App.player.Fields);
            foreach (KeyValuePair<string, FieldDTO> pair in fields)
            {
                if (App.fieldinfo.IsLanguage(pair.Key))
                {
                    foreach(Languages language in collection)
                    {
                        //ToString() must be done instead of using name property being there are outliers, eg: C# and CSharp is not the same thing
                        if (pair.Key.Equals(language.ToString()))
                        {
                            App.player.Fields[pair.Key] = language.ConvertToDTO();
                        }

                    }

                }
            }

        }


        public static ObservableCollection<Languages> GetLanguageList(SortedList<string, FieldDTO> sortedlist)
        {


            ObservableCollection<Languages> languageCollection = new ObservableCollection<Languages>();
            foreach(KeyValuePair<string, FieldDTO> pair in sortedlist)
            {
                if (App.fieldinfo.IsLanguage(pair.Key))
                {
                    Languages language = App.fieldinfo.GetLanguage(pair.Key);
                    language.UpdateFromDTO(pair.Value);

                    languageCollection.Add(language);
                }
            }

            return languageCollection;

        }

        public static ObservableCollection<Field> GetFrameworkList(SortedList<string, FieldDTO> sortedlist)
        {
            ObservableCollection<Field> frameworkCollection = new ObservableCollection<Field>();
            foreach (KeyValuePair<string, FieldDTO> pair in sortedlist)
            {
                if (App.fieldinfo.IsFramework(pair.Key))
                {
                    Frameworks framework = App.fieldinfo.GetFramework(pair.Key);
                    framework.UpdateFromDTO(pair.Value);

                    frameworkCollection.Add(framework);
                }
            }

            return frameworkCollection;

        }

        public static ObservableCollection<Field> GetToolList(SortedList<string, FieldDTO> sortedlist)
        {
            ObservableCollection<Field> toolCollection = new ObservableCollection<Field>();
            foreach (KeyValuePair<string, FieldDTO> pair in sortedlist)
            {
                if (App.fieldinfo.IsTool(pair.Key))
                {
                    //Get the exact type of tool
                    Tools tool = App.fieldinfo.GetTool(pair.Key);
                    //Fill in values for our empty tool object
                    tool.UpdateFromDTO(pair.Value);

                    toolCollection.Add(tool);
                }
            }

            return toolCollection;

        }

        //This should be in an ItemHelper class
        public static ObservableCollection<Item> GetInventory(SortedList<string, int> sortedlist)
        {
            var items = sortedlist.Select(x => App.fieldinfo.GetItem(x.Key, x.Value));
            return new ObservableCollection<Item>(items);

            //ObservableCollection<Item> itemCollection = new ObservableCollection<Item>();
            //foreach (KeyValuePair<string, int> pair in sortedlist)
            //{
            //    itemCollection.Add(App.fieldinfo.GetItem(pair.Key, pair.Value));

            //}

            //return itemCollection;
        }




    }

}
