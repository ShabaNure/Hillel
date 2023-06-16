using LK15.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LK15.Repositories
{
    internal class ShopNetRepository : IRepository<ShopNet>
    {
        public ShopContext shopContext { get; set; }

        public void Add(ShopNet entity)
        {
            shopContext.ShopNets.Add(entity);
        }

        public void Delete(int id)
        {
            var shopNets = shopContext.ShopNets.FirstOrDefault(s => s.Id == id);
            shopContext.ShopNets.Remove(shopNets);
        }

        public ShopNet Get(int id)
        {
            return shopContext.ShopNets.FirstOrDefault(shopNets => shopNets.Id == id);
        }

        public void Update(ShopNet entity)
        {
            shopContext.ShopNets.Update(entity);
        }
    }
}
