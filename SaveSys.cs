using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Threading.Tasks;
using TextRPGpractice.Player_info;

namespace TextRPGpractice
{
    internal class SaveSys
    {
        Player player = new();
        readonly JsonSerializerOptions jOptions = new() { DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull, WriteIndented = true };
        string[] path = { "../../../Saves/playerSave1.Json", "../../../SaveData/playerSave2.Json", "../../../SaveData/playerSave3.Json", "../../../SaveData/playerSave4.Json", "../../../SaveData/playerSave5.Json", "../../../SaveData/playerSave6.Json", "../../../SaveData/playerSave7.Json" };
        public int currentSave = 0;
        public void SaveGame(Player charSave)
        {
            if (!Directory.Exists("../../../Saves"))
            {
                Directory.CreateDirectory("../../../Saves");
            }
            string jsonString = JsonSerializer.Serialize(charSave, jOptions);
            File.WriteAllText(path[currentSave], jsonString);
        }
        /*void LoadSave()
        {
            if (File.Exists(path[currentSave]) != false)
            {
                string allSaves = File.ReadAllText(path[currentSave]);
                player = JsonSerializer.Deserialize(allSaves);
            }
        }*/
    }
}
