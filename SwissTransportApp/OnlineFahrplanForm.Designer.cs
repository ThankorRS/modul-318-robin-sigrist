namespace SwissTransportApp
{
    partial class OnlineFahrplanForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OnlineFahrplanForm));
            this.spContainer = new System.Windows.Forms.SplitContainer();
            this.cbxDepartureBoard = new System.Windows.Forms.ComboBox();
            this.gbWeiteres = new System.Windows.Forms.GroupBox();
            this.btnShowMap = new System.Windows.Forms.Button();
            this.tbxMail = new System.Windows.Forms.TextBox();
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.btnStationBoard = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gbZeitDatum = new System.Windows.Forms.GroupBox();
            this.btnArrival = new System.Windows.Forms.Button();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.btnDeparture = new System.Windows.Forms.Button();
            this.gbLocation = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChangeTbx = new System.Windows.Forms.Button();
            this.cbxTargetLocation = new System.Windows.Forms.ComboBox();
            this.cbxStartLocation = new System.Windows.Forms.ComboBox();
            this.btnMapTargetLocation = new System.Windows.Forms.Button();
            this.btnMapStartLocation = new System.Windows.Forms.Button();
            this.lbZiel = new System.Windows.Forms.Label();
            this.lbStart = new System.Windows.Forms.Label();
            this.gridResult = new System.Windows.Forms.DataGridView();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abfahrtsort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Abfahrtzeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ankunftsort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ankunftzeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dauer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kante_Abfahrtsort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kante_Ankunftsort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.spContainer)).BeginInit();
            this.spContainer.Panel1.SuspendLayout();
            this.spContainer.Panel2.SuspendLayout();
            this.spContainer.SuspendLayout();
            this.gbWeiteres.SuspendLayout();
            this.gbZeitDatum.SuspendLayout();
            this.gbLocation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridResult)).BeginInit();
            this.SuspendLayout();
            // 
            // spContainer
            // 
            this.spContainer.AllowDrop = true;
            this.spContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spContainer.Location = new System.Drawing.Point(-2, 1);
            this.spContainer.Margin = new System.Windows.Forms.Padding(2);
            this.spContainer.Name = "spContainer";
            this.spContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spContainer.Panel1
            // 
            this.spContainer.Panel1.BackColor = System.Drawing.Color.Snow;
            this.spContainer.Panel1.BackgroundImage = global::SwissTransportApp.Properties.Resources.swiss_alps_snow_covered_mountains_glacier_switzerland_3840x2160_2443__2_;
            this.spContainer.Panel1.Controls.Add(this.cbxDepartureBoard);
            this.spContainer.Panel1.Controls.Add(this.gbWeiteres);
            this.spContainer.Panel1.Controls.Add(this.btnStationBoard);
            this.spContainer.Panel1.Controls.Add(this.btnSearch);
            this.spContainer.Panel1.Controls.Add(this.gbZeitDatum);
            this.spContainer.Panel1.Controls.Add(this.gbLocation);
            // 
            // spContainer.Panel2
            // 
            this.spContainer.Panel2.Controls.Add(this.gridResult);
            this.spContainer.Size = new System.Drawing.Size(838, 592);
            this.spContainer.SplitterDistance = 198;
            this.spContainer.SplitterWidth = 3;
            this.spContainer.TabIndex = 0;
            // 
            // cbxDepartureBoard
            // 
            this.cbxDepartureBoard.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbxDepartureBoard.FormattingEnabled = true;
            this.cbxDepartureBoard.Location = new System.Drawing.Point(685, 83);
            this.cbxDepartureBoard.Name = "cbxDepartureBoard";
            this.cbxDepartureBoard.Size = new System.Drawing.Size(127, 21);
            this.cbxDepartureBoard.TabIndex = 11;
            this.cbxDepartureBoard.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ComboBoxDepartureBoard_TextChanged);
            // 
            // gbWeiteres
            // 
            this.gbWeiteres.BackColor = System.Drawing.Color.Transparent;
            this.gbWeiteres.Controls.Add(this.btnShowMap);
            this.gbWeiteres.Controls.Add(this.tbxMail);
            this.gbWeiteres.Controls.Add(this.btnSendEmail);
            this.gbWeiteres.Location = new System.Drawing.Point(412, 32);
            this.gbWeiteres.Name = "gbWeiteres";
            this.gbWeiteres.Size = new System.Drawing.Size(251, 146);
            this.gbWeiteres.TabIndex = 10;
            this.gbWeiteres.TabStop = false;
            this.gbWeiteres.Text = "Weiteres";
            // 
            // btnShowMap
            // 
            this.btnShowMap.Location = new System.Drawing.Point(6, 38);
            this.btnShowMap.Name = "btnShowMap";
            this.btnShowMap.Size = new System.Drawing.Size(238, 23);
            this.btnShowMap.TabIndex = 10;
            this.btnShowMap.Text = "Nächste Stationen anzeigen";
            this.btnShowMap.UseVisualStyleBackColor = true;
            // 
            // tbxMail
            // 
            this.tbxMail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxMail.Location = new System.Drawing.Point(6, 95);
            this.tbxMail.Name = "tbxMail";
            this.tbxMail.Size = new System.Drawing.Size(160, 20);
            this.tbxMail.TabIndex = 9;
            this.tbxMail.Tag = "";
            this.tbxMail.Text = "max.mustermann@example.com";
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendEmail.Enabled = false;
            this.btnSendEmail.Location = new System.Drawing.Point(174, 88);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(70, 44);
            this.btnSendEmail.TabIndex = 8;
            this.btnSendEmail.Text = "Mailen";
            this.btnSendEmail.UseVisualStyleBackColor = true;
            // 
            // btnStationBoard
            // 
            this.btnStationBoard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStationBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStationBoard.Location = new System.Drawing.Point(685, 29);
            this.btnStationBoard.Name = "btnStationBoard";
            this.btnStationBoard.Size = new System.Drawing.Size(127, 54);
            this.btnStationBoard.TabIndex = 7;
            this.btnStationBoard.Text = "Abfahrtstafel";
            this.btnStationBoard.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnStationBoard.UseVisualStyleBackColor = true;
            this.btnStationBoard.Click += new System.EventHandler(this.btnStationBoard_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSearch.Enabled = false;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(685, 121);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(127, 59);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gbZeitDatum
            // 
            this.gbZeitDatum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbZeitDatum.BackColor = System.Drawing.Color.Transparent;
            this.gbZeitDatum.Controls.Add(this.btnArrival);
            this.gbZeitDatum.Controls.Add(this.datePicker);
            this.gbZeitDatum.Controls.Add(this.timePicker);
            this.gbZeitDatum.Controls.Add(this.btnDeparture);
            this.gbZeitDatum.Location = new System.Drawing.Point(211, 32);
            this.gbZeitDatum.Margin = new System.Windows.Forms.Padding(2);
            this.gbZeitDatum.Name = "gbZeitDatum";
            this.gbZeitDatum.Padding = new System.Windows.Forms.Padding(2);
            this.gbZeitDatum.Size = new System.Drawing.Size(186, 146);
            this.gbZeitDatum.TabIndex = 4;
            this.gbZeitDatum.TabStop = false;
            this.gbZeitDatum.Text = "Zeit/Datum";
            // 
            // btnArrival
            // 
            this.btnArrival.Location = new System.Drawing.Point(25, 66);
            this.btnArrival.Margin = new System.Windows.Forms.Padding(2);
            this.btnArrival.Name = "btnArrival";
            this.btnArrival.Size = new System.Drawing.Size(140, 24);
            this.btnArrival.TabIndex = 3;
            this.btnArrival.Text = "Ankunft um";
            this.btnArrival.UseVisualStyleBackColor = true;
            this.btnArrival.Click += new System.EventHandler(this.BtnArrival_Click);
            // 
            // datePicker
            // 
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(79, 106);
            this.datePicker.Margin = new System.Windows.Forms.Padding(2);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(89, 20);
            this.datePicker.TabIndex = 2;
            // 
            // timePicker
            // 
            this.timePicker.CustomFormat = "HH:mm";
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker.Location = new System.Drawing.Point(25, 106);
            this.timePicker.Margin = new System.Windows.Forms.Padding(2);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(50, 20);
            this.timePicker.TabIndex = 1;
            this.timePicker.Value = new System.DateTime(2020, 11, 26, 11, 22, 0, 0);
            // 
            // btnDeparture
            // 
            this.btnDeparture.Location = new System.Drawing.Point(25, 27);
            this.btnDeparture.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeparture.Name = "btnDeparture";
            this.btnDeparture.Size = new System.Drawing.Size(140, 24);
            this.btnDeparture.TabIndex = 0;
            this.btnDeparture.Text = "Abfahrt um";
            this.btnDeparture.UseVisualStyleBackColor = true;
            this.btnDeparture.Click += new System.EventHandler(this.BtnDeparture_Click);
            // 
            // gbLocation
            // 
            this.gbLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbLocation.BackColor = System.Drawing.Color.Transparent;
            this.gbLocation.Controls.Add(this.label1);
            this.gbLocation.Controls.Add(this.btnChangeTbx);
            this.gbLocation.Controls.Add(this.cbxTargetLocation);
            this.gbLocation.Controls.Add(this.cbxStartLocation);
            this.gbLocation.Controls.Add(this.btnMapTargetLocation);
            this.gbLocation.Controls.Add(this.btnMapStartLocation);
            this.gbLocation.Controls.Add(this.lbZiel);
            this.gbLocation.Controls.Add(this.lbStart);
            this.gbLocation.Location = new System.Drawing.Point(11, 26);
            this.gbLocation.Margin = new System.Windows.Forms.Padding(2);
            this.gbLocation.Name = "gbLocation";
            this.gbLocation.Padding = new System.Windows.Forms.Padding(2);
            this.gbLocation.Size = new System.Drawing.Size(188, 152);
            this.gbLocation.TabIndex = 0;
            this.gbLocation.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Umdrehen";
            // 
            // btnChangeTbx
            // 
            this.btnChangeTbx.Location = new System.Drawing.Point(133, 7);
            this.btnChangeTbx.Name = "btnChangeTbx";
            this.btnChangeTbx.Size = new System.Drawing.Size(53, 28);
            this.btnChangeTbx.TabIndex = 8;
            this.btnChangeTbx.Text = "<-->";
            this.btnChangeTbx.UseVisualStyleBackColor = true;
            this.btnChangeTbx.Click += new System.EventHandler(this.BtnChangeTbx_Click);
            // 
            // cbxTargetLocation
            // 
            this.cbxTargetLocation.FormattingEnabled = true;
            this.cbxTargetLocation.Location = new System.Drawing.Point(65, 111);
            this.cbxTargetLocation.Name = "cbxTargetLocation";
            this.cbxTargetLocation.Size = new System.Drawing.Size(111, 21);
            this.cbxTargetLocation.TabIndex = 7;
            this.cbxTargetLocation.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ComboBoxTargetLocation_TextChanged);
            // 
            // cbxStartLocation
            // 
            this.cbxStartLocation.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbxStartLocation.FormattingEnabled = true;
            this.cbxStartLocation.Location = new System.Drawing.Point(65, 62);
            this.cbxStartLocation.Name = "cbxStartLocation";
            this.cbxStartLocation.Size = new System.Drawing.Size(111, 21);
            this.cbxStartLocation.TabIndex = 6;
            this.cbxStartLocation.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ComboBoxStartLocation_TextChanged);
            // 
            // btnMapTargetLocation
            // 
            this.btnMapTargetLocation.Enabled = false;
            this.btnMapTargetLocation.Image = global::SwissTransportApp.Properties.Resources.map_ico;
            this.btnMapTargetLocation.Location = new System.Drawing.Point(15, 85);
            this.btnMapTargetLocation.Name = "btnMapTargetLocation";
            this.btnMapTargetLocation.Size = new System.Drawing.Size(47, 42);
            this.btnMapTargetLocation.TabIndex = 5;
            this.btnMapTargetLocation.UseVisualStyleBackColor = true;
            // 
            // btnMapStartLocation
            // 
            this.btnMapStartLocation.Enabled = false;
            this.btnMapStartLocation.Image = global::SwissTransportApp.Properties.Resources.map_ico;
            this.btnMapStartLocation.Location = new System.Drawing.Point(15, 33);
            this.btnMapStartLocation.Name = "btnMapStartLocation";
            this.btnMapStartLocation.Size = new System.Drawing.Size(47, 45);
            this.btnMapStartLocation.TabIndex = 4;
            this.btnMapStartLocation.UseVisualStyleBackColor = true;
            // 
            // lbZiel
            // 
            this.lbZiel.AutoSize = true;
            this.lbZiel.Location = new System.Drawing.Point(66, 95);
            this.lbZiel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbZiel.Name = "lbZiel";
            this.lbZiel.Size = new System.Drawing.Size(36, 13);
            this.lbZiel.TabIndex = 1;
            this.lbZiel.Text = "Zielort";
            // 
            // lbStart
            // 
            this.lbStart.AutoSize = true;
            this.lbStart.Location = new System.Drawing.Point(63, 40);
            this.lbStart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbStart.Name = "lbStart";
            this.lbStart.Size = new System.Drawing.Size(41, 13);
            this.lbStart.TabIndex = 0;
            this.lbStart.Text = "Startort";
            // 
            // gridResult
            // 
            this.gridResult.AllowUserToAddRows = false;
            this.gridResult.AllowUserToDeleteRows = false;
            this.gridResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridResult.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Datum,
            this.Abfahrtsort,
            this.Abfahrtzeit,
            this.Ankunftsort,
            this.Ankunftzeit,
            this.Dauer,
            this.Kante_Abfahrtsort,
            this.Kante_Ankunftsort});
            this.gridResult.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridResult.Location = new System.Drawing.Point(3, 3);
            this.gridResult.Name = "gridResult";
            this.gridResult.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gridResult.RowHeadersVisible = false;
            this.gridResult.RowHeadersWidth = 123;
            this.gridResult.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridResult.Size = new System.Drawing.Size(835, 339);
            this.gridResult.TabIndex = 0;
            // 
            // Datum
            // 
            this.Datum.HeaderText = "Datum";
            this.Datum.MinimumWidth = 15;
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // Abfahrtsort
            // 
            this.Abfahrtsort.HeaderText = "Abfahrtsort";
            this.Abfahrtsort.MinimumWidth = 15;
            this.Abfahrtsort.Name = "Abfahrtsort";
            this.Abfahrtsort.ReadOnly = true;
            // 
            // Abfahrtzeit
            // 
            this.Abfahrtzeit.HeaderText = "Abfahrtzeit";
            this.Abfahrtzeit.MinimumWidth = 15;
            this.Abfahrtzeit.Name = "Abfahrtzeit";
            this.Abfahrtzeit.ReadOnly = true;
            // 
            // Ankunftsort
            // 
            this.Ankunftsort.HeaderText = "Ankunftsort";
            this.Ankunftsort.MinimumWidth = 15;
            this.Ankunftsort.Name = "Ankunftsort";
            this.Ankunftsort.ReadOnly = true;
            // 
            // Ankunftzeit
            // 
            this.Ankunftzeit.HeaderText = "Ankunftzeit";
            this.Ankunftzeit.MinimumWidth = 15;
            this.Ankunftzeit.Name = "Ankunftzeit";
            this.Ankunftzeit.ReadOnly = true;
            // 
            // Dauer
            // 
            this.Dauer.HeaderText = "Dauer";
            this.Dauer.MinimumWidth = 15;
            this.Dauer.Name = "Dauer";
            this.Dauer.ReadOnly = true;
            // 
            // Kante_Abfahrtsort
            // 
            this.Kante_Abfahrtsort.HeaderText = "Kante Abfahrtsort";
            this.Kante_Abfahrtsort.MinimumWidth = 15;
            this.Kante_Abfahrtsort.Name = "Kante_Abfahrtsort";
            // 
            // Kante_Ankunftsort
            // 
            this.Kante_Ankunftsort.HeaderText = "Kante Ankunftsort";
            this.Kante_Ankunftsort.MinimumWidth = 15;
            this.Kante_Ankunftsort.Name = "Kante_Ankunftsort";
            this.Kante_Ankunftsort.ReadOnly = true;
            // 
            // OnlineFahrplanForm
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 472);
            this.Controls.Add(this.spContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(51, 61);
            this.Name = "OnlineFahrplanForm";
            this.Text = "SBB CFF FFS - Fahrplan";
            this.spContainer.Panel1.ResumeLayout(false);
            this.spContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spContainer)).EndInit();
            this.spContainer.ResumeLayout(false);
            this.gbWeiteres.ResumeLayout(false);
            this.gbWeiteres.PerformLayout();
            this.gbZeitDatum.ResumeLayout(false);
            this.gbLocation.ResumeLayout(false);
            this.gbLocation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spContainer;
        private System.Windows.Forms.GroupBox gbLocation;
        private System.Windows.Forms.Label lbZiel;
        private System.Windows.Forms.Label lbStart;
        private System.Windows.Forms.GroupBox gbZeitDatum;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.Button btnDeparture;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnStationBoard;
        private System.Windows.Forms.DataGridView gridResult;
        private System.Windows.Forms.Button btnMapTargetLocation;
        private System.Windows.Forms.Button btnMapStartLocation;
        private System.Windows.Forms.Button btnSendEmail;
        private System.Windows.Forms.TextBox tbxMail;
        private System.Windows.Forms.GroupBox gbWeiteres;
        private System.Windows.Forms.Button btnShowMap;
        private System.Windows.Forms.ComboBox cbxStartLocation;
        private System.Windows.Forms.ComboBox cbxTargetLocation;
        private System.Windows.Forms.Button btnArrival;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abfahrtsort;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abfahrtzeit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ankunftsort;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ankunftzeit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dauer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kante_Abfahrtsort;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kante_Ankunftsort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChangeTbx;
        private System.Windows.Forms.ComboBox cbxDepartureBoard;
    }
}

