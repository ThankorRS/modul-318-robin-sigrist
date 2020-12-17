using SwissTransport.Core;
using SwissTransport.Models;

namespace SwissTransportApp
{
    class GoogleMaps
    {
        static Transport transp = new Transport();
        
        public static void Show(string target)
        {
            double xCoord = 0;
            double yCoord = 0;
            Stations stations = transp.GetStations(target);
            if (stations.StationList.Count != 0)
            {
                if(stations.StationList[0].Coordinate.XCoordinate.HasValue)
                {
                    xCoord = stations.StationList[0].Coordinate.XCoordinate.Value;
                }
                if (stations.StationList[0].Coordinate.YCoordinate.HasValue)
                {
                    yCoord = stations.StationList[0].Coordinate.YCoordinate.Value;
                }
                // Get first entry of X and Y axis
                GoogleMapsForm SwissTransportGoogleMap = new GoogleMapsForm(
                    xCoord,
                    yCoord
                );
                // show form with the Google Maps nuGet Package
                SwissTransportGoogleMap.Show();
            }
        }
    }
}
