using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwissTransport.Core;
using SwissTransport.Models;

namespace SwissTransportApp
{
    class Map
    {
        static Transport transp = new Transport();

        public static void Show(string query)
        {
            Stations stations = transp.GetStations(query);
            if (stations.StationList.Count != 0)
            {
                _ = new GMapForm(
                    stations.StationList[0].Coordinate.XCoordinate,
                    stations.StationList[0].Coordinate.YCoordinate
                );
                Show();
            }
        }
        public static void Show()
        {

        }
    }
}
