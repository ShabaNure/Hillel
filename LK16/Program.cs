using System.Collections.Immutable;
using System.Linq;
namespace LK16
{
    public class Program
    {
        static void Main()
        {
            var cityList = new List<City>();
            var countryList = new List<Country>();

            var Europe = new Land("Europe");
            var SouthAmerica = new Land("South America");

            var Germany = new Country("Germany", Europe);
            var France = new Country("France", Europe);
            var Poland = new Country("Poland", Europe);
            var America = new Country("America", SouthAmerica);
            var Canada = new Country("Canada", SouthAmerica);
            var ctl = new[] { Germany, France, Poland ,America,Canada };
            countryList.AddRange(ctl);

            cityList.Add(new City("Berlin", 1800000, new DateTime(1000, 2, 10), Germany, true));
            cityList.Add(new City("Munchen", 650000, new DateTime(1300, 2, 10), Germany, false));
            cityList.Add(new City("Hamburg", 1100000, new DateTime(1500, 2, 10), Germany, false));

            cityList.Add(new City("Paris", 2500000, new DateTime(800, 2, 10), France, true));          
            cityList.Add(new City("Toulouse", 1500000, new DateTime(2000, 2, 10), France, false));
            cityList.Add(new City("Montpellier", 500000, new DateTime(1100, 2, 10), France, false));

            cityList.Add(new City("Warszawa", 1500000, new DateTime(1250, 2, 10), Poland, true));
            cityList.Add(new City("Krakow", 2000000, new DateTime(1300, 2, 10), Poland, false));
            cityList.Add(new City("Katowice", 160000, new DateTime(1600, 2, 10), Poland, false));

            cityList.Add(new City("Washington", 3160000, new DateTime(600, 2, 10), America, true));
            cityList.Add(new City("Miami", 1600000, new DateTime(1850, 2, 10), America, false));
            cityList.Add(new City("NewYork", 1910000, new DateTime(1600, 2, 10), America, false));

            cityList.Add(new City("Ottawa", 100000, new DateTime(1150, 2, 10), Canada, true));
            cityList.Add(new City("Montreal", 2160000, new DateTime(1200, 2, 10), Canada, false));
            cityList.Add(new City("Vancouver", 360000, new DateTime(950, 2, 10), Canada, false));


            var countryCount = countryList.GroupBy(s => s.land.landName);
            foreach (var country in countryCount)
            {
                Console.WriteLine(country.Key+" - "+country.Count());
            }

            var top3 = cityList.OrderByDescending(s => s.population).Where(s => s.date.Year < 1200).ToList().Take(3);
            int i = 1;
            foreach(var city in top3)
            {
                Console.WriteLine($"Number {i} - "+city.cityName+" - "+city.population);
                i++;
            }

            var mostPopulatedCountry = cityList.GroupBy(g => g.country).OrderByDescending(r => r.Sum(k => k.population)).Take(1).ToList().First();
            foreach (var cap in mostPopulatedCountry)
            {
                if(cap.isCapital) 
                {
                    Console.WriteLine(mostPopulatedCountry.Key.countryName+" - "+ cap.cityName);
                }

            }

            var mostPopulatedLand = cityList.Where(s => s.population >= 1000000).GroupBy(g => g.country.land).OrderBy(r => r.Count()).Take(1).ToList().ToList().First();
            Console.WriteLine(mostPopulatedLand.Key.landName);
        }
    }
}