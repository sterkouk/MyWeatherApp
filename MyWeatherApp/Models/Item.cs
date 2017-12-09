using MyWeatherApp.Assets.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MyWeatherApp.Assets.Models.FutureWeather;

namespace MyWeatherApp.Models
{
    public class Item
    {
        public string Temperature;
        public string Pressure;
        public string Humidity;
        public string Description;
        public string Icon;
        public string Time;
        public string City;
    }
    
    public  static class ItemManager
    {
      
        public static async Task<ObservableCollection<Item>> GetInfoAsync()
        {
            var items = new ObservableCollection<Item>();
            var position = await LocationManager.GetPosition();
            var lat = position.Coordinate.Point.Position.Latitude;
            var lon = position.Coordinate.Point.Position.Longitude;
            RootObject1 myWeather1 = await GetFutureWeather(lat, lon);
            //RootObject myWeather = await OpenWeatherMapProxy.GetWeather(lat, lon);
            //items.Add(new Item { Pressure = myWeather.main.pressure.ToString(), Humidity = myWeather.main.humidity.ToString() });
            foreach (var forecast in myWeather1.list)
            {
                //string icon = String.Format("ms-appx:///Assets/Weather/{0}.png",myWeather.weather[0].icon);
                //ResultImage.Source = new BitmapImage(new Uri(icon, UriKind.Absolute));
                items.Add(new Item
                {
                    Temperature = forecast.main.temp.ToString(),
                    Pressure = forecast.main.pressure.ToString(),
                    Humidity = forecast.main.humidity.ToString(),
                    Description = forecast.weather[0].description,
                    Icon = String.Format("ms-appx:///Assets/Weather/{0}.png", forecast.weather[0].icon),
                    Time = forecast.dt_txt,
                    //City = myWeather1.city.name.ToString()
                });
               
            }

                return items;
        }

        /*public static void GetAllItemsAsync(ObservableCollection<Item> items)
        {
            var allItems = GetInfoAsync();
            items.Clear();
            //allItems.ForEach(p => items.Add(p));
            ObservableCollection<Item> all;
            all = allItems.Result;
            all.ForEach(p => items.Add(p));
           
        }
        public static void ForEach<T>(this IEnumerable<T> enumerable, Action<T> action)
        {
            foreach (var cur in enumerable)
            {
                action(cur);
            }
        }
        
        public static void GetItemsByName(ObservableCollection<Item> items,string city)
        {
            var allItmes = GetInfoAsync();
            var filteredItems = allItmes.Result.Where(p => p.City == city).ToList();
            items.Clear();
            filteredItems.ForEach(p => items.Add(p));
        }*/
    }
}
