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
    internal class DataStore : IDataRepository
    {
        private readonly string _filePath = "C:\\Users\\josha\\source\\repos\\joshatk-hub\\OOPProject\\OOPProjectRev2\\data.json";
        private readonly string _filePathCart = "C:\\Users\\josha\\source\\repos\\joshatk-hub\\OOPProject\\OOPProjectRev2\\cart.json";
        private readonly string _filePathAccounts = "C:\\Users\\josha\\source\\repos\\joshatk-hub\\OOPProject\\OOPProjectRev2\\users.json";

        public void SaveData(AppState state)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonData = JsonSerializer.Serialize(state, options);
            File.WriteAllText(_filePath, jsonData);
        }
        public void SaveCart(Cart cart)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonData = JsonSerializer.Serialize(cart, options);
            File.WriteAllText(_filePathCart, jsonData);
        }
        public AppState LoadData()
        {
            if (!File.Exists(_filePath)) return new AppState();
            string jsonString = File.ReadAllText(_filePath);
            return JsonSerializer.Deserialize<AppState>(jsonString) ?? new AppState();
        }
        public Cart LoadCart()
        {
            if (!File.Exists(_filePathCart)) return new Cart();
            string jsonString = File.ReadAllText(_filePathCart);
            return JsonSerializer.Deserialize<Cart>(jsonString) ?? new Cart();
        }
        public UserAccount LoadCustomer()
        {
            if (!File.Exists(_filePathAccounts)) return new UserAccount();
            string jsonString = File.ReadAllText(_filePathAccounts);
            return JsonSerializer.Deserialize<UserAccount>(jsonString) ?? new UserAccount();
        }
        public List<OrderLine> LoadOrderLines()
        {
            var cart = LoadCart();
            return cart.OrderLines;
        }
        public List<MenuItem> LoadRegularMenuItems()
        {
            var state = LoadData();
            return state.MenuItems;
        }
        public List<SeasonalItem> LoadSeasonalMenuItems()
        {
            var state = LoadData();
            return state.SeasonalItems;
        }
    }
}
