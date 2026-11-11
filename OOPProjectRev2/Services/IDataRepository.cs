using OOPProjectRev2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPProjectRev2.Services
{
    internal interface IDataRepository
    {
        void SaveData(AppState state);
        AppState LoadData();
        List<MenuItem> LoadRegularMenuItems();
        List<SeasonalItem> LoadSeasonalMenuItems();

        void SaveCart(Cart cart);
        Cart LoadCart();
        List<OrderLine> LoadOrderLines();
        UserAccount LoadCustomer();
        Order LoadOrder();
    }
}
