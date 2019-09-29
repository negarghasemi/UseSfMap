using System;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Acr.UserDialogs;
using Bit.ViewModel;
using Plugin.Geolocator;
using Prism.Navigation;
using Syncfusion.UI.Xaml.Maps;
using UseMap.Resources;
using Xamarin.Forms;

namespace UseMap.ViewModels
{
    public class MapViewModel : BitViewModelBase
    {
        public Point coordinate { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public MapViewModel()
        {
            Latitude = 0;
            Longitude = 0;
            coordinate = new Point(35.715298, 51.404343);
        
            }
    

  

        public override async Task OnNavigatedToAsync(INavigationParameters parameters)
        {
            await Task.Delay(TimeSpan.FromSeconds(5));
            var locator = CrossGeolocator.Current;
            locator.DesiredAccuracy = 20;
            if (locator.IsGeolocationAvailable && locator.IsGeolocationEnabled)
            {
                var position = await locator.GetPositionAsync();
                coordinate = new Point(position.Latitude, position.Longitude);
                Latitude = position.Latitude;
                Longitude = position.Longitude;
            }

            await base.OnNavigatedFromAsync(parameters);
        }
    }
}
