using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using MyWeatherApp.Assets.Models;
using MyWeatherApp.Models;
using System.Collections.ObjectModel;
using static MyWeatherApp.Assets.Models.FutureWeather;
using static MyWeatherApp.Models.FutureWeatherByCity;
using static MyWeatherApp.Models.Suggestions;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238
/*<VisualStateManager.VisualStateGroups>
                                    <VisualStateGroup x:Name="VisualStateGroup">
                                        <VisualState x:Name="Wide">
                                            <VisualState.StateTriggers>
                                                <AdaptiveTrigger MinWindowWidth="800" />
                                            </VisualState.StateTriggers>
                                            <VisualState.Setters>
                                                <Setter Target="MyGridTemplate.(Height)" Value="400"/>
                                                <Setter Target="MyGridTemplate.(Width)" Value="400"/>
                                            </VisualState.Setters>


                                        </VisualState>
                                    </VisualStateGroup>
                                    </VisualStateManager.VisualStateGroups>






    <!--<TextBlock FontSize="16" Name="Humidity_Text" Text="Humidity is:" />-->
                                    <!--<TextBlock FontSize="16" Name="HumidityTextBlock" RelativePanel.AlignHorizontalCenterWithPanel="True" Text="{x:Bind Humidity}" />-->
                                    <!--<TextBlock FontSize="16" Name="Pressure_Text" Text="Pressure is:" RelativePanel.Below="Humidity_Text"  />-->
                                    <!--<TextBlock RelativePanel.Below="HumidityTextBlock" FontSize="16" Name="PressureTextBlock" Text="{x:Bind Pressure}"/>-->
                                    <Image Name="MoreResultImage" Width="100" Height="100" Source="{x:Bind Icon}" RelativePanel.AlignHorizontalCenterWithPanel="True"/>
                                    <TextBlock FontSize="16" Name="Temperature_Text" Text="Temperature is:" RelativePanel.Below="MoreResultImage" />
                                    <TextBlock FontSize="16" Name="TemperatureTextBlock" Text="{x:Bind Temperature}" RelativePanel.RightOf="Temperature_Text" RelativePanel.Below="MoreResultImage" Margin="5,0,0,0"/>
                                    <TextBlock FontSize="16" Name="Description_Text" Text="Description:"  RelativePanel.Below="Temperature_Text" />
                                    <TextBlock FontSize="16" Name="DescriptionTextBlock" Text="{x:Bind Description}" RelativePanel.RightOf="Description_Text" RelativePanel.Below="Temperature_Text"  Margin="5,0,0,0"/>
                                    <TextBlock FontSize="16" Name="Time_Text" Text="Time:"  RelativePanel.Below="Description_Text" />
                                    <TextBlock FontSize="16" Name="TimeTextBlock" Text="{x:Bind Time}" RelativePanel.RightOf="Time_Text" RelativePanel.Below="Description_Text"  Margin="5,0,0,0"/>
*/

namespace MyWeatherApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CityFutureWeather : Page
    {
        private ObservableCollection<Suggestions> Suggestions;
        public CityFutureWeather()
        {
            this.InitializeComponent();

        }

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            Suggestions = await SuggestionsManager.GetFutureInfoAsync(e.Parameter.ToString());
            MyGridView.ItemsSource = Suggestions;
        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }
    }
}
