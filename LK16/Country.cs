using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LK16
{
    public class Country
    {
        public string countryName { get; set; }
        public Land land { get; set; }

        public Country() { }
        public Country(string countryName, Land land)
        {
            this.countryName = countryName;
            this.land = land;
        }
    }
}
