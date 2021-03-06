﻿using SwissTransport.Core;
using SwissTransport.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Windows.Forms;


namespace SwissTransportApp
{
    partial class OnlineFahrplanForm : Form
    {
        // Global Variables
        Transport transp = new Transport();
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
            btnStationBoard.Enabled = false;
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
            Process.Start("mailto: "+ tbxMail.Text + "?subject=SBB CFF FFS - Online Fahrplan" + "&body=" + emailText);
        }
        // generate Mail text to send on btn click
        private string GenerateMailText()
        {
            string emailText = "";
            emailText += "Verbindungen: \n";
            foreach (DataGridViewRow row in gridResult.SelectedRows)
            {
                emailText += "\n";
                foreach (DataGridViewCell cell in row.Cells)
                {
                    emailText += cell.Value + "; ";
                }
            }

            return emailText;
        }
        // Click handler for generating a Mail with the connections
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cbxStartLocation.Text != "" || cbxStartLocation.Text.Length != 0)
            {
                Cursor.Current = Cursors.WaitCursor;
                int isArrival = 0;
                string Date = DateTime.Parse(datePicker.Text).ToString("dd.MM.yyyy");
                string Time = DateTime.Parse(timePicker.Text).ToString("HH:mm");
                try
                {
                    if(cbxTargetLocation.Text != "" || cbxTargetLocation.Text.Length != 0)
                    {
                        if (btnArrival.Enabled == false)
                            isArrival = 1;

                        Connections Connections = transp.GetConnections(
                            cbxStartLocation.Text, 
                            cbxTargetLocation.Text, 
                            Time, 
                            Date, 
                            isArrival.ToString()
                        );

                        if (Connections.ConnectionList.Count != 0)
                        {
                            RenewConnections(Connections);
                        }
                        else
                        {
                            // Error
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        // Renew in DataGrid the Connections after Search Button is pressd
        private void RenewConnections(Connections connections)
        {
            gridResult.Rows.Clear();
            gridResult.Columns.Clear();
            gridResult.Columns.Add("Datum", "Datum");
            gridResult.Columns.Add("Abfahrtsort", "Abfahrtsort");
            gridResult.Columns.Add("Abfahrtzeit", "Abfahrtzeit");
            gridResult.Columns.Add("Ankunftsort", "Ankunftsort");
            gridResult.Columns.Add("Ankunftzeit", "Ankunftzeit");
            gridResult.Columns.Add("Dauer", "Dauer");
            gridResult.Columns.Add("Kante Abfahrtsort", "Kante Abfahrtsort");
            gridResult.Columns.Add("Kante Ankunftsort", "Kante Ankunftsort");

            foreach (Connection connection in connections.ConnectionList)
            {
                TimeSpan duration = TimeSpan.Parse(connection.Duration.Replace("d", ":"));
                gridResult.Rows.Add(new[] {
                    DateTime.Parse(connection.From.Departure.Value.ToString()).ToString("dd.MM.yyyy"), 
                    connection.From.Station.Name, 
                    DateTime.Parse(connection.From.Departure.Value.ToString()).ToString("HH:mm"), 
                    connection.To.Station.Name, 
                    DateTime.Parse(connection.To.Arrival.ToString()).ToString("HH:mm"), 
                    duration.ToString(@"hh\:mm"), 
                    connection.From.Platform, 
                    connection.To.Platform 
                });
            }
        }
        // Autocomplete for Start Location using UpdateAutocomplete();
        private void ComboBoxStartLocation_TextChanged(object sender, KeyEventArgs e)
        {
           // if fire event is not true (not key up, down, enter) update ComboBox
           if (!AutoComplete.CheckFireEvent(e))
           {
           if (cbxStartLocation.Text.Length > 1)
            {
                UpdateAutoComplete(cbxStartLocation);
           }
           }
           if (cbxStartLocation.Text.Length != 0)
           {
                btnMapStartLocation.Enabled = true;
           }
           else
           {
                btnMapStartLocation.Enabled = false;
           }
            CheckStartTargetCbxEmpty();
        }
        // Autocomplete for Target Location using UpdateAutocomplete();
        private void ComboBoxTargetLocation_TextChanged(object sender, KeyEventArgs e)
        {
           if (!AutoComplete.CheckFireEvent(e))
           {
                if (cbxTargetLocation.Text.Length > 1)
                {
                    UpdateAutoComplete(cbxTargetLocation);
                }
           }
           if (cbxTargetLocation.Text.Length != 0)
           {
               btnMapTargetLocation.Enabled = true;
           }
           else
           {
               btnMapTargetLocation.Enabled = false;
           }
            CheckStartTargetCbxEmpty();
        }
        // Autocomplete for Departure Board using UpdateAutocomplete();
        private void ComboBoxDepartureBoard_TextChanged(object sender, KeyEventArgs e)
        {
            if (!AutoComplete.CheckFireEvent(e))
            {
                if (cbxDepartureBoard.Text.Length > 1)
                {
                    btnStationBoard.Enabled = true;
                    UpdateAutoComplete(cbxDepartureBoard);
                }
            }
        }
        // function to have a intellisense feeling in the form
        private void UpdateAutoComplete(ComboBox cbx)
        {
            string item = cbx.Text;
            while (cbx.Items.Count > 0)
            {
                    cbx.Items.RemoveAt(0);
            }
            List<string> stations = AutoComplete.GenerateAutocomplete(cbx.Text);
            foreach (string station in stations)
            {
                if (station != null)
                {
                    cbx.Items.Add(station);
                }
            }            
            cbx.DroppedDown = true;
            cbx.SelectionLength = 0;
            cbx.AutoCompleteMode = AutoCompleteMode.None;
            cbx.AutoCompleteSource = AutoCompleteSource.None;
            cbx.Text = item;
            cbx.SelectionStart = cbx.Text.Length + 1;
        }
        // Funtion to check if eighter Start or Target Location is empty
        private void CheckStartTargetCbxEmpty()
        {
            if ((cbxStartLocation.Text.Length != 0 && cbxStartLocation.Text != "") && (cbxTargetLocation.Text.Length != 0 && cbxTargetLocation.Text != ""))
            {
                btnSearch.Enabled = true;
            }
            else
            {
                btnSearch.Enabled = false;
            }
        }
        // Click handler for the Station Board 
        private void btnStationBoard_Click(object sender, EventArgs e)
        {
            string stationID = "";
            Stations stations = transp.GetStations(cbxDepartureBoard.Text);
            foreach(Station station in stations.StationList)
            {
                stationID = station.Id;
            }
            StationBoardRoot stationBoard = transp.GetStationBoard(
                cbxDepartureBoard.Text,
                stationID
            );
            if (stationBoard.Entries.Count == 0)
            {
                // Error
            }
            else
            {
                StationBoardUpdate(stationBoard);
            }

        }
        // Function to update the Stationboard
        private void StationBoardUpdate(StationBoardRoot stationBoardRoot)
        {
            int i = 0;
            gridResult.Rows.Clear();
            gridResult.Columns.Clear();
            gridResult.Columns.Add("Datum", "Datum");
            gridResult.Columns.Add("Abfahrtzeit", "Abfahrtzeit");
            gridResult.Columns.Add("Abfahrtsort", "Abfahrtsort");
            gridResult.Columns.Add("Richtung", "Richtung");
            gridResult.Columns.Add("Linie", "Linie");
            foreach (StationBoard stationBoard in stationBoardRoot.Entries)
            {
                if (i <= 10)
                {
                    gridResult.Rows.Add(new[] { 
                        stationBoard.Stop.Departure.ToString("dd.MM.yyyy"), 
                        stationBoard.Stop.Departure.ToString("HH:mm"), 
                        stationBoardRoot.Station.Name, 
                        stationBoard.To, 
                        stationBoard.Name 
                    });
                    i++;
                }
            }
        }
        // Open Start Location Map in Google Maps
        private void btnMapStartLocation_Click(object sender, EventArgs e)
        {
            GoogleMaps.Show(cbxStartLocation.Text);
        }
        // Open Target Location Map in Google Maps
        private void btnMapTargetLocation_Click(object sender, EventArgs e)
        {
            GoogleMaps.Show(cbxTargetLocation.Text);
        }
        // check if e-mail addres is changed
        private void tbxMail_TextChanged(object sender, EventArgs e)
        {
            if (tbxMail.Text.Length != 0 && tbxMail.Text != "")
            {
                btnSendEmail.Enabled = true;
            }
            else
            {
                btnSendEmail.Enabled = false;
            }
        }
        // Dialog handler for telling user input incorrect
        public static string ShowDialog(string text, string caption)
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
    }
}