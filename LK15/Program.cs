using LK15.Models;
using LK15.Repositories;
using Microsoft.VisualBasic;
using System.Collections.ObjectModel;

namespace LK15
{
    public class Program
    {
        static void Main()
        {
            var itemRepository = new ItemsRepository();
            var shopRepository = new ShopRepository();
            var shopNetRepository = new ShopNetRepository();
            var dbContext = new ShopContext();
            var frame = new UnitOfWork(dbContext,itemRepository,shopRepository,shopNetRepository);

            var item = frame.AddItem("Item2", 15);
            var shop = frame.AddShop("Shop2");
            var shopNet = frame.AddShopNet("Net3");
            frame.SaveDatabase();
            frame.AddShopItem(item, shop);
            frame.AddShopShopNet(shopNet, shop);
            frame.SaveDatabase();

        }
    }
}