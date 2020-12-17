namespace SwissTransportApp
{
    partial class GoogleMapsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoogleMapsForm));
            this.gmapCtrl = new GMap.NET.WindowsForms.GMapControl();
            this.SuspendLayout();
            // 
            // gmapCtrl
            // 
            this.gmapCtrl.Bearing = 0F;
            this.gmapCtrl.CanDragMap = true;
            this.gmapCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gmapCtrl.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmapCtrl.GrayScaleMode = false;
            this.gmapCtrl.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmapCtrl.LevelsKeepInMemory = 5;
            this.gmapCtrl.Location = new System.Drawing.Point(0, 0);
            this.gmapCtrl.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.gmapCtrl.MarkersEnabled = true;
            this.gmapCtrl.MaxZoom = 2;
            this.gmapCtrl.MinZoom = 2;
            this.gmapCtrl.MouseWheelZoomEnabled = true;
            this.gmapCtrl.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmapCtrl.Name = "gmapCtrl";
            this.gmapCtrl.NegativeMode = false;
            this.gmapCtrl.PolygonsEnabled = true;
            this.gmapCtrl.RetryLoadTile = 0;
            this.gmapCtrl.RoutesEnabled = true;
            this.gmapCtrl.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmapCtrl.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmapCtrl.ShowTileGridLines = false;
            this.gmapCtrl.Size = new System.Drawing.Size(2226, 1540);
            this.gmapCtrl.TabIndex = 0;
            this.gmapCtrl.Zoom = 0D;
            this.gmapCtrl.Load += new System.EventHandler(this.GoogleMapsForm_Load);
            // 
            // GoogleMapsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2226, 1540);
            this.Controls.Add(this.gmapCtrl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "GoogleMapsForm";
            this.Text = "Google Maps";
            this.ResumeLayout(false);

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gmapCtrl;
    }
}