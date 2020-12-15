﻿using SwissTransport.Core;
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

    /*
     TODO
        - screw the auto thing for the moment and focus on the main functions
        - implement afterwards the auto thing ;)
     */
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
            string tbxStart = cbxStartLocation.Text;
            string tbxEnd = cbxTargetLocation.Text;
            cbxStartLocation.Text = tbxEnd;
            cbxTargetLocation.Text = tbxStart;
        }
        //send on btn click the mail preperated with the GenerateMailText() function
        private void BtnSendEmail_Click(object sender, EventArgs e)
        {
            string emailText = GenerateMailText();
            Process.Start("mailto: " + "?subject={SBB CFF FFS - Online Fahrplan}" + tbxMail.Text + "&body=" + emailText);
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
        private void TextBoxStartLocation_TextChanged(object sender, KeyEventArgs e)
        {
            // if fire event is not true (not key up, down, enter) update ComboBox
            if (!AutoComplete.CheckFireEvent(e))
            {
                UpdateAutoComplete(cbxStartLocation);
            }
            if (cbxStartLocation.Text.Length != 0)
            {
                btnMapZielStation.Enabled = true;
            }
            else
            {
                btnMapZielStation.Enabled = false;
            }
        }        
        private void TextBoxTargetLocation_TextChanged(object sender, KeyEventArgs e)
        {
            if (AutoComplete.CheckFireEvent(e))
            {
                UpdateAutoComplete(cbxTargetLocation);
            }

            if (cbxTargetLocation.Text.Length != 0)
            {
                btnMapZielStation.Enabled = true;
            }
            else
            {
                btnMapZielStation.Enabled = false;
            }
        }
        private void UpdateAutoComplete(ComboBox cbx)
        {
            while (cbx.Items.Count > 0)
            {
                cbx.Items.RemoveAt(0);
            }
            //cbx.Items.Add(AutoComplete.GenerateAutocomplete(cbx.Text));
            List<string> stations = AutoComplete.GenerateAutocomplete(cbx.Text);
            foreach (string station in stations)
            {
                if (station != null)
                {
                    cbx.Items.Add(station);
                }
            }
            cbx.DroppedDown = true;
        }
    }
}

