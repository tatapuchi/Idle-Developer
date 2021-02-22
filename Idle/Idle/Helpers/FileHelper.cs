using Idle.Core.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Idle.Helpers
{
    //Non-instantiable Helper class that handles file IO for data persistence
    public class FileHelper
    {

        //Non-instantiable Helper Class
        private FileHelper()
        {
            throw new InvalidOperationException();
        }


        //File Path to json file containing Player data
        private static readonly string file = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Player.json");


        //Serializes Player object and writes the content to Player.json
        public static void WritePlayer(Player player)
        {
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(player);
            File.WriteAllText(file, json);
        }


        //Reads Player.json and returns a deserialized Player object from the file data
        public static Player ReadPlayer()
        {
            string json = File.ReadAllText(file);
            Player player = (Player) Newtonsoft.Json.JsonConvert.DeserializeObject(json);

            return player;
        }

    }
}
