using project.Helpers;
using project.Views;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;
using Windows.UI.Xaml.Controls.Maps;

namespace project.ViewModels
{
    public class MapUserControlViewModel:BaseViewModel
    {
        public MapUserControlViewModel(MapWindow mapUserControl)
        {
            var mapcontrol = new MapControl();
            mapcontrol.Loaded += Mapcontrol_Loaded1;
            mapcontrol.MapServiceToken = App.Token;
            //mapUserControl.MainGrid.Children.Add(mapcontrol);
        }

        private async void Mapcontrol_Loaded1(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            BasicGeoposition basicGeoposition = new BasicGeoposition() { Latitude = HelperClass.CurrentLocation[0], Longitude = HelperClass.CurrentLocation[1] };
            var center = new Geopoint(basicGeoposition);
            await((MapControl)sender).TrySetViewAsync(center, 16);
        }
    }
}
