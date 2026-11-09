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


    }
}
