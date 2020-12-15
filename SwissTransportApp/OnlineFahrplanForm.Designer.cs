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
            this.gbWeiteres = new System.Windows.Forms.GroupBox();
            this.btnShowMap = new System.Windows.Forms.Button();
            this.tbxMail = new System.Windows.Forms.TextBox();
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.btnToggleView = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gbZeitDatum = new System.Windows.Forms.GroupBox();
            this.btnAnkunft = new System.Windows.Forms.Button();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.btnAbfahrt = new System.Windows.Forms.Button();
            this.gbLocation = new System.Windows.Forms.GroupBox();
            this.tbxZielLocation = new System.Windows.Forms.ComboBox();
            this.tbxStartLocation = new System.Windows.Forms.ComboBox();
            this.btnMapZielStation = new System.Windows.Forms.Button();
            this.btnMapStartStation = new System.Windows.Forms.Button();
            this.lbZiel = new System.Windows.Forms.Label();
            this.lbStart = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // spContainer
            // 
            this.spContainer.AllowDrop = true;
            this.spContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spContainer.Location = new System.Drawing.Point(-2, 1);
            this.spContainer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.spContainer.Name = "spContainer";
            this.spContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spContainer.Panel1
            // 
            this.spContainer.Panel1.BackColor = System.Drawing.Color.Snow;
            this.spContainer.Panel1.BackgroundImage = global::SwissTransportApp.Properties.Resources.swiss_alps_snow_covered_mountains_glacier_switzerland_3840x2160_2443__2_;
            this.spContainer.Panel1.Controls.Add(this.gbWeiteres);
            this.spContainer.Panel1.Controls.Add(this.btnToggleView);
            this.spContainer.Panel1.Controls.Add(this.btnSearch);
            this.spContainer.Panel1.Controls.Add(this.gbZeitDatum);
            this.spContainer.Panel1.Controls.Add(this.gbLocation);
            // 
            // spContainer.Panel2
            // 
            this.spContainer.Panel2.Controls.Add(this.dgv);
            this.spContainer.Size = new System.Drawing.Size(836, 449);
            this.spContainer.SplitterDistance = 219;
            this.spContainer.SplitterWidth = 3;
            this.spContainer.TabIndex = 0;
            // 
            // gbWeiteres
            // 
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
            // btnToggleView
            // 
            this.btnToggleView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToggleView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToggleView.Location = new System.Drawing.Point(685, 29);
            this.btnToggleView.Name = "btnToggleView";
            this.btnToggleView.Size = new System.Drawing.Size(125, 68);
            this.btnToggleView.TabIndex = 7;
            this.btnToggleView.Text = "Abfahrtstafel";
            this.btnToggleView.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnToggleView.UseVisualStyleBackColor = true;

            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSearch.Enabled = false;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(685, 104);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(125, 59);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // gbZeitDatum
            // 
            this.gbZeitDatum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbZeitDatum.Controls.Add(this.btnAnkunft);
            this.gbZeitDatum.Controls.Add(this.datePicker);
            this.gbZeitDatum.Controls.Add(this.timePicker);
            this.gbZeitDatum.Controls.Add(this.btnAbfahrt);
            this.gbZeitDatum.Location = new System.Drawing.Point(211, 32);
            this.gbZeitDatum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbZeitDatum.Name = "gbZeitDatum";
            this.gbZeitDatum.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbZeitDatum.Size = new System.Drawing.Size(184, 146);
            this.gbZeitDatum.TabIndex = 4;
            this.gbZeitDatum.TabStop = false;
            this.gbZeitDatum.Text = "Zeit/Datum";
            // 
            // btnAnkunft
            // 
            this.btnAnkunft.Location = new System.Drawing.Point(25, 66);
            this.btnAnkunft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAnkunft.Name = "btnAnkunft";
            this.btnAnkunft.Size = new System.Drawing.Size(140, 24);
            this.btnAnkunft.TabIndex = 3;
            this.btnAnkunft.Text = "Ankunft um";
            this.btnAnkunft.UseVisualStyleBackColor = true;
            this.btnAnkunft.Click += new System.EventHandler(this.btnAnkunft_Click);
            // 
            // datePicker
            // 
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(79, 106);
            this.datePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(89, 20);
            this.datePicker.TabIndex = 2;
            // 
            // timePicker
            // 
            this.timePicker.CustomFormat = "HH:mm";
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker.Location = new System.Drawing.Point(25, 106);
            this.timePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(50, 20);
            this.timePicker.TabIndex = 1;
            this.timePicker.Value = new System.DateTime(2020, 11, 26, 11, 22, 0, 0);
            // 
            // btnAbfahrt
            // 
            this.btnAbfahrt.Location = new System.Drawing.Point(25, 27);
            this.btnAbfahrt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAbfahrt.Name = "btnAbfahrt";
            this.btnAbfahrt.Size = new System.Drawing.Size(140, 24);
            this.btnAbfahrt.TabIndex = 0;
            this.btnAbfahrt.Text = "Abfahrt um";
            this.btnAbfahrt.UseVisualStyleBackColor = true;
            this.btnAbfahrt.Click += new System.EventHandler(this.btnAbfahrt_Click);
            // 
            // gbLocation
            // 
            this.gbLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbLocation.BackColor = System.Drawing.Color.Transparent;
            this.gbLocation.Controls.Add(this.tbxZielLocation);
            this.gbLocation.Controls.Add(this.tbxStartLocation);
            this.gbLocation.Controls.Add(this.btnMapZielStation);
            this.gbLocation.Controls.Add(this.btnMapStartStation);
            this.gbLocation.Controls.Add(this.lbZiel);
            this.gbLocation.Controls.Add(this.lbStart);
            this.gbLocation.Location = new System.Drawing.Point(11, 26);
            this.gbLocation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbLocation.Name = "gbLocation";
            this.gbLocation.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbLocation.Size = new System.Drawing.Size(186, 152);
            this.gbLocation.TabIndex = 0;
            this.gbLocation.TabStop = false;
            // 
            // tbxZielLocation
            // 
            this.tbxZielLocation.FormattingEnabled = true;
            this.tbxZielLocation.Location = new System.Drawing.Point(65, 111);
            this.tbxZielLocation.Name = "tbxZielLocation";
            this.tbxZielLocation.Size = new System.Drawing.Size(111, 21);
            this.tbxZielLocation.TabIndex = 7;
            // 
            // tbxStartLocation
            // 
            this.tbxStartLocation.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbxStartLocation.FormattingEnabled = true;
            this.tbxStartLocation.Location = new System.Drawing.Point(65, 62);
            this.tbxStartLocation.Name = "tbxStartLocation";
            this.tbxStartLocation.Size = new System.Drawing.Size(111, 21);
            this.tbxStartLocation.TabIndex = 6;
            // 
            // btnMapZielStation
            // 
            this.btnMapZielStation.Enabled = false;
            this.btnMapZielStation.Image = global::SwissTransportApp.Properties.Resources.map_ico;
            this.btnMapZielStation.Location = new System.Drawing.Point(15, 85);
            this.btnMapZielStation.Name = "btnMapZielStation";
            this.btnMapZielStation.Size = new System.Drawing.Size(47, 42);
            this.btnMapZielStation.TabIndex = 5;
            this.btnMapZielStation.UseVisualStyleBackColor = true;
            // 
            // btnMapStartStation
            // 
            this.btnMapStartStation.Enabled = false;
            this.btnMapStartStation.Image = global::SwissTransportApp.Properties.Resources.map_ico;
            this.btnMapStartStation.Location = new System.Drawing.Point(15, 33);
            this.btnMapStartStation.Name = "btnMapStartStation";
            this.btnMapStartStation.Size = new System.Drawing.Size(47, 45);
            this.btnMapStartStation.TabIndex = 4;
            this.btnMapStartStation.UseVisualStyleBackColor = true;
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
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Datum,
            this.Abfahrtsort,
            this.Abfahrtzeit,
            this.Ankunftsort,
            this.Ankunftzeit,
            this.Dauer,
            this.Kante_Abfahrtsort,
            this.Kante_Ankunftsort});
            this.dgv.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv.Location = new System.Drawing.Point(3, 3);
            this.dgv.Name = "dgv";
            this.dgv.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgv.RowHeadersVisible = false;
            this.dgv.RowHeadersWidth = 123;
            this.dgv.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.Size = new System.Drawing.Size(833, 230);
            this.dgv.TabIndex = 0;
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
            this.ClientSize = new System.Drawing.Size(835, 352);
            this.Controls.Add(this.spContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(65, 61);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spContainer;
        private System.Windows.Forms.GroupBox gbLocation;
        private System.Windows.Forms.Label lbZiel;
        private System.Windows.Forms.Label lbStart;
        private System.Windows.Forms.GroupBox gbZeitDatum;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.Button btnAbfahrt;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnToggleView;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnMapZielStation;
        private System.Windows.Forms.Button btnMapStartStation;
        private System.Windows.Forms.Button btnSendEmail;
        private System.Windows.Forms.TextBox tbxMail;
        private System.Windows.Forms.GroupBox gbWeiteres;
        private System.Windows.Forms.Button btnShowMap;
        private System.Windows.Forms.ComboBox tbxStartLocation;
        private System.Windows.Forms.ComboBox tbxZielLocation;
        private System.Windows.Forms.Button btnAnkunft;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abfahrtsort;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abfahrtzeit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ankunftsort;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ankunftzeit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dauer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kante_Abfahrtsort;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kante_Ankunftsort;
    }
}

