using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwissTransportApp
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                Application.Run(new OnlineFahrplanForm());
            }
            catch(Exception)
            {
                MessageBox.Show("" +
                    "Ein Fehler ist aufgetreten.\n Überprüfen der Eingabe ist notwendig.\n Falls die Station nicht aufgelistet wird, wenden Sie sich an die zuständige Software Firma.",
                    "Ein seltsamer Fehler ist erschienen!",
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
