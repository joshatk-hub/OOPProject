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
        private readonly IDataRepository _dataRepository;
        public MenuService(IDataRepository dataRepository)
        {
            _dataRepository = dataRepository;
        }
        public List<MenuItem> GetAvailableRegularMenu()
        {
            return _dataRepository.LoadRegularMenuItems();
        }

    }
}
