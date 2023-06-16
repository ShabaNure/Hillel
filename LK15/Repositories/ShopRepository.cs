using LK15.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LK15.Repositories
{
    internal class ShopRepository : IRepository<Shop>
    {
        public ShopContext shopContext { get; set; }

        public void Add(Shop entity)
        {
            shopContext.Shop.Add(entity);
        }

        public void Delete(int id)
        {
            var shop = shopContext.Shop.FirstOrDefault(s => s.ShopId == id);
            shopContext.Shop.Remove(shop);
        }

        public Shop Get(int id)
        {
            return shopContext.Shop.FirstOrDefault(shop => shop.ShopId == id);
        }

        public void Update(Shop entity)
        {
            shopContext.Shop.Update(entity);
        }
    }
}
