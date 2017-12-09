using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWeatherApp.Models
{
    public class City
    {
        public string Name;
        public int id;
        public double lat;
        public double lon;
        public string Country_Code;

        public static ObservableCollection<String> getCities()
        {
            string filePath = ("Assets/greek_cities.txt");
            var search = File.ReadAllLines(filePath);
            ObservableCollection<String> cities = new ObservableCollection<String>(search); 
            return cities;
        }

    }
}
