using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LK15
{
    public class Shop
    {
        public int ShopId { get; set; }
        public string ShopName { get; set; }
        public  ICollection<Item> Items { get; set; } = new List<Item>();
        public ICollection<ShopNet> ShopNets { get; set; } = new List<ShopNet>();

    }

}
