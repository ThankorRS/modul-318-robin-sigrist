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
            // Setting default Values on Formload
            InitializeComponent();
            timePicker.Text = DateTime.Now.ToString("HH:mm");
            datePicker.Text = DateTime.Now.ToString("dd.MM.yyyy");
            btnAnkunft.Enabled = false;
            btnSearch.Enabled = false;
            btnSendEmail.Enabled = false;
            gbLocation.BackColor = Color.FromArgb(100, 255, 255, 255);
            gbWeiteres.BackColor = Color.FromArgb(100, 255, 255, 255);
            gbZeitDatum.BackColor = Color.FromArgb(100, 255, 255, 255);
            // Check if the user has an Internet Connection
            //CheckConnection();
        }

        private void btnAbfahrt_Click(object sender, EventArgs e)
        {
            btnAnkunft.FlatAppearance.BorderColor = Color.LightGray;
            btnAnkunft.BackColor = Color.LightGray;
            btnAbfahrt.Enabled = false;
            btnAbfahrt.FlatAppearance.BorderColor = Color.Green;
            btnAbfahrt.BackColor = Color.Green;
            btnAnkunft.Enabled = true;
        }

        private void btnAnkunft_Click(object sender, EventArgs e)
        {
            btnAbfahrt.FlatAppearance.BorderColor = Color.LightGray;
            btnAbfahrt.BackColor = Color.LightGray;
            btnAnkunft.Enabled = false;
            btnAnkunft.FlatAppearance.BorderColor = Color.Green;
            btnAnkunft.BackColor = Color.Green;
            btnAbfahrt.Enabled = true;
        }
    }
}

