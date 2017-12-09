using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MyWeatherApp.Models.FutureWeatherByCity;

namespace MyWeatherApp.Models
{
    public class Suggestions
    {
        public string Temperature;
        public string Pressure;
        public string Humidity;
        public string Description;
        public string Icon;
        public string Time;
        public string City;
    }

    public static class SuggestionsManager
    {
        public static void GetAllCities(ObservableCollection<String> cities)
        {
            var allcities = City.getCities();
            cities.Clear();
            allcities.ForEach(p => cities.Add(p));
             
        }

        public static void GetCitiesByName(ObservableCollection<String> cities,string name)
        {
            var allcities = City.getCities();
            var filteredCities = cities.Where(p => p.Contains(name)).ToList();
            cities.Clear();
            filteredCities.ForEach(p => cities.Add(p));
        }
        public static void ForEach<T>(this IEnumerable<T> enumerable, Action<T> action)
        {
            foreach (var cur in enumerable)
            {
                action(cur);
            }
        }

        public static async Task<ObservableCollection<Suggestions>> GetFutureInfoAsync(string city)
        {
            var data = new ObservableCollection<Suggestions>();
            RootObject2 myWeather2 = await GetFutureWeatherByCity(city);
            foreach(var forecast in myWeather2.list)
            {
                data.Add(new Suggestions
                {
                    Temperature = forecast.main.temp.ToString(),
                    Pressure = forecast.main.pressure.ToString(),
                    Humidity = forecast.main.humidity.ToString(),
                    Description = forecast.weather[0].description,
                    Icon = String.Format("ms-appx:///Assets/Weather/{0}.png", forecast.weather[0].icon),
                    Time = forecast.dt_txt,
                });
            }
            return data;
        }
    }
}
