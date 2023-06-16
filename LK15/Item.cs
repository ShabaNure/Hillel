using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LK15
{
    public class Item
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public int Count { get; set; }

        public ICollection<Shop> Shops { get; set; } = new List<Shop>();

    }
}
