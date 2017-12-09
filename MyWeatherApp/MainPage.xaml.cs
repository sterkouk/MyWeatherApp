using MyWeatherApp.Assets.Models;
using MyWeatherApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Notifications;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using static MyWeatherApp.Assets.Models.FutureWeather;
using static MyWeatherApp.Models.FutureWeatherByCity;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MyWeatherApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private ObservableCollection<String> Cities;
        private List<String> Suggestions;
        private ObservableCollection<Item> Items;
        public MainPage()
        {
            this.InitializeComponent();
            Cities = new ObservableCollection<String>();
        }


        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var position = await LocationManager.GetPosition();
                var lat = position.Coordinate.Point.Position.Latitude;
                var lon = position.Coordinate.Point.Position.Longitude;
                RootObject myWeather = await OpenWeatherMapProxy.GetWeather(lat, lon);//exei 8ema
                var uri = String.Format("http://myweatherservice1.azurewebsites.net/?lat={0}&lon={1}", lat, lon);
                var tileContent = new Uri(uri);
                var requestedInterval = PeriodicUpdateRecurrence.HalfHour;
                var updater = TileUpdateManager.CreateTileUpdaterForApplication();
                updater.StartPeriodicUpdate(tileContent, requestedInterval);
                string icon = String.Format("ms-appx:///Assets/Weather/{0}.png",myWeather.weather[0].icon);
                ResultImage.Source = new BitmapImage(new Uri(icon, UriKind.Absolute));
                TempTextBlock.Text = ((int)myWeather.main.temp).ToString();
                DescriptionTextBlock.Text = myWeather.weather[0].description;
                LocationTextBlock.Text = myWeather.name;
                //RootObject1 FutureWeather = await GetFutureWeather(lat, lon);
                //FutureWeather.
                
            }
            catch
            {
                LocationTextBlock.Text = "Check your Internet connection or open your location";
            }
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitview.IsPaneOpen = !MySplitview.IsPaneOpen;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private async void MoreInfoButton_ClickAsync(object sender, RoutedEventArgs e)
        {
            Items = await ItemManager.GetInfoAsync();
            MyGridView.ItemsSource = Items;

        }

        private void MyAutoSuggestBox_TextChangedAsync(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            if (String.IsNullOrEmpty(sender.Text)) goBack();

            SuggestionsManager.GetAllCities(Cities);
            Suggestions = Cities.Where(p => p.StartsWith(sender.Text)).Select(p => p.ToString()).ToList();
            MyAutoSuggestBox.ItemsSource = Suggestions;
            
        }

        private void goBack()
        {
            SuggestionsManager.GetAllCities(Cities);
            CategoryTextBlock.Text = "All Cities";
        }

        private void MyAutoSuggestBox_QuerySubmitted(AutoSuggestBox sender, AutoSuggestBoxQuerySubmittedEventArgs args)
        {
            SuggestionsManager.GetCitiesByName(Cities, sender.Text);
            CategoryTextBlock.Text = sender.Text;
            Frame.Navigate(typeof(CityFutureWeather),sender.Text);
        }

        public string TextMemberPath { get; set; }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void MyAutoSuggestBox_SuggestionChosen(AutoSuggestBox sender, AutoSuggestBoxSuggestionChosenEventArgs args)
        {
            sender.Text = args.SelectedItem.ToString();
            SuggestionsManager.GetCitiesByName(Cities, sender.Text);
            CategoryTextBlock.Text = sender.Text;
            Frame.Navigate(typeof(CityFutureWeather), sender.Text);
        }
    }
}
