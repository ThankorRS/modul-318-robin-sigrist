using SwissTransport;
using SwissTransport.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Device.Location;


namespace SwissTransportApp
{
    partial class OnlineFahrplanForm : Form
    {

        public OnlineFahrplanForm()
        {
            InitializeComponent();
            timePicker.Text = DateTime.Now.ToString("HH:mm");
            datePicker.Text = DateTime.Now.ToString("dd.MM.yyyy");
            gbLocation.BackColor = Color.FromArgb(100, 255, 255, 255);
            gbWeiteres.BackColor = Color.FromArgb(100, 255, 255, 255);
            gbZeitDatum.BackColor = Color.FromArgb(100, 255, 255, 255);
            //CheckConnection();
        }

        private void btnToggleView_Click(object sender, EventArgs e)
        {

        }
    }
}

