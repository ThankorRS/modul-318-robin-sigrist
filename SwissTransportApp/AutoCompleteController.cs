using System;
using System.Collections.Generic;
using SwissTransport.Core;
using SwissTransport.Models;
using System.Windows.Forms;

namespace SwissTransportApp
{
    class AutoCompleteController
    {
        Transport transp = new Transport();
        // check if the key up down or enter is
        public bool CheckFireEvent(KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Down && e.KeyCode != Keys.Up && e.KeyCode != Keys.Enter && e.KeyCode != Keys.Left && e.KeyCode != Keys.Right)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public List<string> GenerateAutocomplete(string query)
        {
            List<string> src = new List<string>();
            try
            {
                Stations stations = transp.GetStations(query);
                foreach (Station station in stations.StationList)
                {
                    if (!string.IsNullOrEmpty(station.Name) && !string.IsNullOrEmpty(station.Id))
                        src.Add(station.Name);
                }
                if (src.Count == 0)
                {
                    src.Add("Keine Ergebnisse");
                }
            }
            catch (Exception)
            {
                // some exception

            }
            return src;
        }
    }
}
