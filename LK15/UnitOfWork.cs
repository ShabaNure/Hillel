using LK15.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LK15
{
    internal class UnitOfWork
    {
        private IRepository<Item> itemRepository;
        private IRepository<Shop> shopRepository;
        private IRepository<ShopNet> shopNetRepository;
        private ShopContext shopContext { get; set; }

        public UnitOfWork(ShopContext shopContext, IRepository<Item> itemRepository, IRepository<Shop> shopRepository, IRepository<ShopNet> shopNetRepository)
        {
            this.shopContext = shopContext;
            this.itemRepository = itemRepository;
            this.shopRepository = shopRepository;
            this.shopNetRepository = shopNetRepository;
            this.itemRepository.shopContext = shopContext;
            this.shopRepository.shopContext = shopContext;
            this.shopNetRepository.shopContext = shopContext;

        }
        public Item AddItem(string name , int count ) 
        {
            var item = new Item { ItemName = name, Count = count };
            shopContext.Item.Add(item);
            return item;
        }
        public Shop AddShop(string name)
        {
            var shop =new Shop { ShopName = name };
            shopContext.Shop.Add(shop);
            return shop;
        }
        public ShopNet AddShopNet(string name)
        {
            var shopNet = new ShopNet { NetName = name };
            shopContext.ShopNets.Add(shopNet);
            return shopNet;
        }
        public void AddShopItem(Item item,Shop shop)
        {
            shop.Items.Add(item);
        }
        public void AddShopShopNet(ShopNet shopNet, Shop shop)
        {
            shopNet.Shops.Add(shop);
        }
        public void SaveDatabase()
        {
            shopContext.SaveChanges();
        }
    }
}
