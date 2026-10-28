using OOPProjectRev2.Models;
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
        private readonly string _filePath = "C:\\Users\\josha\\source\\repos\\OOPProjectRev2\\OOPProjectRev2\\data.json";
        
        public void SaveData(AppState state)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true 
            };
            string jsonData = JsonSerializer.Serialize(state, options);
            File.WriteAllText(_filePath, jsonData);
        }
        public AppState LoadData()
        {
            if (!File.Exists(_filePath))
            {
                return new AppState(); // returns empty if there's a file pathing issue
            }

            string jsonString = File.ReadAllText(_filePath);
            return JsonSerializer.Deserialize<AppState>(jsonString) ?? new AppState();
        }
        public List<MenuItem> LoadMenuItems()
        {
            var state = LoadData();
            return state.MenuItems;
        }
    }
}
