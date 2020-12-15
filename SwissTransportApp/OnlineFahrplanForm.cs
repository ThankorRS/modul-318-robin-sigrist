using SwissTransport.Core;
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
        // Global Variables
        Transport transp = new Transport();
        bool departureBoard = false;
        AutoCompleteController AutoComplete = new AutoCompleteController();

        public OnlineFahrplanForm()
        {
            // Setting default Values on Formload
            InitializeComponent();
            timePicker.Text = DateTime.Now.ToString("HH:mm");
            datePicker.Text = DateTime.Now.ToString("dd.MM.yyyy");
            btnDeparture.Enabled = false;
            btnDeparture.BackColor = Color.Green;
            btnArrival.Enabled = true;
            btnSearch.Enabled = false;
            btnSendEmail.Enabled = false;
            gbLocation.BackColor = Color.FromArgb(100, 255, 255, 255);
            gbWeiteres.BackColor = Color.FromArgb(100, 255, 255, 255);
            gbZeitDatum.BackColor = Color.FromArgb(100, 255, 255, 255);
            // Check if the user has an Internet Connection
            HasConnention();
        }
        // Function to determine the connection between user and internet
        private void HasConnention()
        {
            PingReply res = null;
            while (res == null)
            {
                ConnectionForm connectingForm = new ConnectionForm();
                try
                {
                    connectingForm.Show();
                    res = new Ping().Send("simpit.ch", 300);
                    connectingForm.Close();
                }
                // if there is no connection it shows an error
                catch (Exception)
                {
                    connectingForm.Close();
                    DialogResult dialogResult = MessageBox.Show("Ihre Internetverbindung scheint gestört. Bitte beheben Sie dies um mit der Applikation fort zu fahren.",
                        "Fehlende Internetverbindung", 
                        MessageBoxButtons.RetryCancel, 
                        MessageBoxIcon.Error
                    );
                    if (dialogResult == DialogResult.Cancel)
                    {
                        Environment.Exit(0);
                    }
                }
            }
        }
        // change appearance of btnDeparture and btnArrival on click
        private void BtnDeparture_Click(object sender, EventArgs e)
        {
            btnArrival.FlatAppearance.BorderColor = Color.LightGray;
            btnArrival.BackColor = Color.LightGray;
            btnDeparture.Enabled = false;
            btnDeparture.FlatAppearance.BorderColor = Color.Green;
            btnDeparture.BackColor = Color.Green;
            btnArrival.Enabled = true;
        }
        // change appearance of btnArrival and btnDeparture on click
        private void BtnArrival_Click(object sender, EventArgs e)
        {
            btnDeparture.FlatAppearance.BorderColor = Color.LightGray;
            btnDeparture.BackColor = Color.LightGray;
            btnArrival.Enabled = false;
            btnArrival.FlatAppearance.BorderColor = Color.Green;
            btnArrival.BackColor = Color.Green;
            btnDeparture.Enabled = true;
        }
        // Change on btn click the directions
        private void BtnChangeTbx_Click(object sender, EventArgs e)
        {
            string tbxStart = tbxStartLocation.Text;
            string tbxEnd = tbxTargetLocation.Text;
            tbxStartLocation.Text = tbxEnd;
            tbxTargetLocation.Text = tbxStart;
        }
        //send on btn click the mail preperated with the GenerateMailText() function
        private void BtnSendEmail_Click(object sender, EventArgs e)
        {
            string emailText = GenerateMailText();
            Process.Start("mailto: " + "?subject={Online Fahrplan}" + tbxMail.Text + "&body=" + emailText);
        }
        // generate Mail text to send on btn click
        private string GenerateMailText()
        {
            string emailText = "";
            emailText += "Verbindungen: ";
            foreach (DataGridViewRow row in dgv.SelectedRows)
            {
                emailText += "\n";
                foreach (DataGridViewCell cell in row.Cells)
                {
                    emailText += cell.Value + "; ";
                }
            }

            return emailText;
        }
        private void TextBoxLocationChanged()
        {
            tbxStartLocation.BackColor = Color.White;
            tbxTargetLocation.BackColor = Color.White;
            if (tbxTargetLocation.Text.Length != 0 && tbxStartLocation.Text.Length != 0 && !departureBoard)
            {
                btnSearch.Enabled = true;
            }
            else if (departureBoard && tbxStartLocation.Text.Length != 0)
            {
                btnSearch.Enabled = true;
            }
            else
            {
                btnSearch.Enabled = false;
            }
        }
        private void TextBoxStartLocation_TextChanged(object sender, KeyEventArgs e)
        {
            if (AutoComplete.CheckFireEvent(e))
            {
                UpdateAutoCompleteForStart();
            }
            if (tbxStartLocation.Text.Length != 0)
            {
                btnMapStartStation.Enabled = true;
            }
            else
            {
                btnMapStartStation.Enabled = false;
            }
            TextBoxLocationChanged();
        }
        private void UpdateAutoCompleteForStart()
        {
            while (tbxStartLocation.Items.Count > 0)
            {
                tbxStartLocation.Items.RemoveAt(0);
            }
            List<string> stations = AutoComplete.GenerateAutocomplete(tbxStartLocation.Text);
            foreach (String station in stations)
            {
                if (station != null)
                {
                    tbxStartLocation.Items.Add(station);
                }
            }
            tbxStartLocation.DroppedDown = true;
        }
        private void TextBoxTargetLocation_TextChanged(object sender, KeyEventArgs e)
        {
            if (AutoComplete.CheckFireEvent(e))
            {
                UpdateAutoCompleteForTarget();
            }

            if (tbxTargetLocation.Text.Length != 0)
            {
                btnMapZielStation.Enabled = true;
            }
            else
            {
                btnMapZielStation.Enabled = false;
            }
            TextBoxLocationChanged();
        }
        private void UpdateAutoCompleteForTarget()
        {
            while (tbxTargetLocation.Items.Count > 0)
            {
                tbxTargetLocation.Items.RemoveAt(0);
            }
            List<string> stations = AutoComplete.GenerateAutocomplete(tbxTargetLocation.Text);
            foreach (String station in stations)
            {
                if (station != null)
                {
                    tbxTargetLocation.Items.Add(station);
                }
            }
            tbxTargetLocation.DroppedDown = true;
        }

    }
}

