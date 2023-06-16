using LK15.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LK15.Repositories
{
    internal class ItemsRepository : IRepository<Item>
    {
        public ShopContext shopContext { get; set; }

        public void Add(Item entity)
        {
            shopContext.Item.Add(entity);
        }

        public void Delete(int id)
        {
            var item = shopContext.Item.FirstOrDefault(s=>s.ItemId ==id);
            shopContext.Item.Remove(item);
        }

        public Item Get(int id)
        {
            return shopContext.Item.FirstOrDefault(item=>item.ItemId ==id);
        }

        public void Update(Item entity)
        {
            shopContext.Item.Update(entity);
        }
    }
}
