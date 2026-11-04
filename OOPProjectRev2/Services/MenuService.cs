using OOPProjectRev2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProjectRev2.Services
{
    internal class MenuService
    {
        private readonly DataStore _dataStore;

        public MenuService(DataStore dataStore)
        {
            _dataStore = dataStore;
        }

        public List<MenuItem> GetAllActiveMenuItems(DateTime currentDate)
        {
            var allItems = _dataStore.LoadMenuItems();
            return allItems.Where(item => item.InSeason(currentDate)).ToList(); // filter items seasonally
        }

        public List<MenuItem> GetItemsByCategory(string category, DateTime currentDate)
        {
            return GetAllActiveMenuItems(currentDate)
                .Where(item => string.Equals(item.Category, category, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        public List<string> GetAvailableCategories(DateTime currentDate)
        {
            return GetAllActiveMenuItems(currentDate)
                .Select(item => item.Category)
                .Distinct()
                .OrderBy(c => c)
                .ToList();
        }
    }
}
