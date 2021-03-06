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

            SortedList<Field.Language, FieldDTO> fields = new SortedList<Field.Language, FieldDTO>(App.player.Languages);
            foreach (KeyValuePair<Field.Language, FieldDTO> pair in fields)
            {
                
                    foreach(Languages language in collection)
                    {
                        //ToString() must be done instead of using name property being there are outliers, eg: C# and CSharp is not the same thing
                        if (pair.Key.Equals(language.Language))
                        {
                            App.player.Languages[pair.Key] = language.ConvertToDTO();
                        }

                    }

                
            }

        }


        public static ObservableCollection<Languages> GetLanguageList(SortedList<Field.Language, FieldDTO> sortedlist)
        {


            ObservableCollection<Languages> languageCollection = new ObservableCollection<Languages>();
            foreach(KeyValuePair<Field.Language, FieldDTO> pair in sortedlist)
            {
                    Languages language = App.fieldinfo.GetLanguage(pair.Key);
                    language.UpdateFromDTO(pair.Value);

                    languageCollection.Add(language);
            }

            return languageCollection;

        }

        public static ObservableCollection<Frameworks> GetFrameworkList(SortedList<Field.Framework, FieldDTO> sortedlist)
        {
            ObservableCollection<Frameworks> frameworkCollection = new ObservableCollection<Frameworks>();

            foreach (KeyValuePair<Field.Framework, FieldDTO> pair in sortedlist)
            {
                    Frameworks framework = App.fieldinfo.GetFramework(pair.Key);
                    framework.UpdateFromDTO(pair.Value);

                    frameworkCollection.Add(framework);
                
            }

            return frameworkCollection;

        }

        public static ObservableCollection<Tools> GetToolList(SortedList<Field.Tool, FieldDTO> sortedlist)
        {
            ObservableCollection<Tools> toolCollection = new ObservableCollection<Tools>();
            foreach (KeyValuePair<Field.Tool, FieldDTO> pair in sortedlist)
            {

                    //Get the exact type of tool
                    Tools tool = App.fieldinfo.GetTool(pair.Key);
                    //Fill in values for our empty tool object
                    tool.UpdateFromDTO(pair.Value);

                    toolCollection.Add(tool);
                
            }

            return toolCollection;

        }

        //This should be in an ItemHelper class
        public static ObservableCollection<Item> GetInventory(SortedList<Item.ItemType, int> sortedlist)
        {
            //var items = sortedlist.Select(x => App.fieldinfo.GetItem(x.Key, x.Value));
            //return new ObservableCollection<Item>(items);

            ObservableCollection<Item> itemCollection = new ObservableCollection<Item>();
            foreach (KeyValuePair<Item.ItemType, int> pair in sortedlist)
            {
                itemCollection.Add(App.fieldinfo.GetItem(pair.Key, pair.Value));

            }

            return itemCollection;
        }




    }

}
