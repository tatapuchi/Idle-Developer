using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Idle.Helpers
{
    //Helper class that handles file IO for data persistence
    public class FileHelper
    {
        //File Path to json file containing Player data
        private static readonly string file = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Player.json");


        //Serializes Player object and writes the content to Player.json
        public static void WritePlayer(object obj)
        {
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(obj);
            File.WriteAllText(file, json);
        }


        //Reads Player.json and returns a deserialized Player object from the file data
        public static object ReadPlayer()
        {
            string json = File.ReadAllText(file);
            object obj = Newtonsoft.Json.JsonConvert.DeserializeObject(json);

            return obj;
        }


    }
}
