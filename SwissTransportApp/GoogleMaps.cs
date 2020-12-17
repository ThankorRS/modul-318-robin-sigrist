using SwissTransport.Core;
using SwissTransport.Models;
using System.Windows.Forms;

namespace SwissTransportApp
{
    class GoogleMaps
    {
        static Transport transp = new Transport();

        public static void Show(string target)
        {
            Stations stations = transp.GetStations(target);
            if (stations.StationList.Count != 0)
            {
                // Get first entry of X and Y axis
                GoogleMapsForm gmap = new GoogleMapsForm(
                    stations.StationList[0].Coordinate.XCoordinate, 
                    stations.StationList[0].Coordinate.YCoordinate
                );
                // show form with the Google Maps nuGet Package
                gmap.Show();
            }
        }
    }
}
