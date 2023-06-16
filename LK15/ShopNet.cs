using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LK15
{
    public class ShopNet
    {
        public int Id { get; set; }
        public string NetName { get; set; }

        public ICollection<Shop> Shops { get; set; } = new List<Shop>();


    }
}
