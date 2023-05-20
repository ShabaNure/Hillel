using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LK16
{
    public class City
    {
        public string cityName {  get; set; }
        public int population { get; set; }
        public DateTime date { get; set; }
        public Country country { get; set; }
        public bool isCapital { get; set; }

        public City() { }
        public City(string cityName, int population, DateTime date, Country country, bool isCapital)
        {
            this.cityName = cityName;
            this.population = population;
            this.date = date;
            this.country = country;
            this.isCapital = isCapital;
        }
    }
}
