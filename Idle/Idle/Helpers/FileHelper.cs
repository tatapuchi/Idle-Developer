using Idle.Core.Models;
using Idle.Core.Models.Player;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Idle.Helpers
{
    //Non-instantiable Helper class that handles file IO for data persistence
    public static class FileHelper
    {

        //File Path to json file containing Player data
        private static readonly string file = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Player.json");


        //Serializes Player object and writes the content to Player.json
        public static void WritePlayer(PlayerDTO dto)
        {
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(dto);
            File.WriteAllText(file, json);
        }

        public static void WritePlayer(Player player)
        {
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(player.Convert());
            File.WriteAllText(file, json);
        }


        //Reads Player.json and returns a deserialized Player object from the file data
        public static PlayerDTO ReadPlayer()
        {
            string json = File.ReadAllText(file);
            var dto = Newtonsoft.Json.JsonConvert.DeserializeObject<PlayerDTO>(json);


            return dto;
        }

        public static void ClearPlayer()
        {
            File.WriteAllText(file, string.Empty);
        }



    }
}
