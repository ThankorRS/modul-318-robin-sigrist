using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwissTransport.Core;
using SwissTransport.Models;
using System.Windows.Forms;

namespace SwissTransportApp
{
    class AutoCompleteController
    {
        Transport transp = new Transport();

        // check if the key up
        public bool CheckFireEvent(KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Down && e.KeyCode != Keys.Up && e.KeyCode != Keys.Enter)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<string> GenerateAutocomplete(string query)
        {
            List<string> source = new List<string>();
            try
            {
                Stations stations = transp.GetStations(query);
                foreach (Station station in stations.StationList)
                {
                    source.Add(station.Name);
                }
                if (source.Count == 0)
                {
                    source.Add("Keine Ergebnisse");
                }
            }
            catch (Exception)
            {

            }

            return source;
        }
    }
}
