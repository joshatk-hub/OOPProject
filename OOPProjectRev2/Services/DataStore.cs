using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace OOPProjectRev2.Services
{
    internal class DataStore
    {
        private readonly string filePath = "data.json";
        public void SaveData(AppState state)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true 
            };
            string jsonData = JsonSerializer.Serialize(state, options);
            File.WriteAllText(filePath, jsonData);
        }
        public AppState LoadData()
        {
            if (!File.Exists(filePath))
            {
                return new AppState(); // Returns empty or default seed structure
            }

            string jsonString = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<AppState>(jsonString) ?? new AppState();
        }
    }
}
