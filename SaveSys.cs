using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using TextRPGpractice.Entity_info;
using System.Runtime.Serialization.Json;

namespace TextRPGpractice
{
    class SaveSys : States
    {
        readonly JsonSerializerOptions jOptions = new() { DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull, WriteIndented = true };
        string[] path = { "../../../SaveData/playerSave1.Json", "../../../SaveData/playerSave2.Json", "../../../SaveData/playerSave3.Json", "../../../SaveData/playerSave4.Json", "../../../SaveData/playerSave5.Json", "../../../SaveData/playerSave6.Json", "../../../SaveData/playerSave7.Json" };
        public int currentSave = 0;
        public void SaveGame(Player charSave)
        {
            if (charSave.Class == null && charSave.Race == null)
            {
                Console.WriteLine("No character Created");
                Thread.Sleep(550);
                return;
            }
            if (!Directory.Exists("../../../SaveData"))
            {
                Directory.CreateDirectory("../../../SaveData");
            }
            string jsonString = JsonSerializer.Serialize(charSave, jOptions);
            File.WriteAllText(path[currentSave], jsonString);
        }
        public void LoadSave()
        {
            if (File.Exists(path[currentSave]) != false)
            {
                string loader = File.ReadAllText(path[currentSave]);
                player = JsonSerializer.Deserialize<Player>(loader);
            }
        }
    }
}
