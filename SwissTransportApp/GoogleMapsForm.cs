using System;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;


namespace SwissTransportApp
{
    public partial class GoogleMapsForm : Form
    {
        double XCoordinate;
        double YCoordinate;

        public GoogleMapsForm(double XCoordinate, double YCoordinate)
        {
            InitializeComponent();
            this.XCoordinate = XCoordinate;
            this.YCoordinate = YCoordinate;
        }

        private void GoogleMapsForm_Load(object sender, EventArgs e)
        {
            gmapCtrl.DragButton = MouseButtons.Left;
            gmapCtrl.CanDragMap = true;
            gmapCtrl.MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance;
            gmapCtrl.Position = new PointLatLng(XCoordinate, YCoordinate);
            gmapCtrl.MinZoom = 0;
            gmapCtrl.MaxZoom = 24;
            gmapCtrl.Zoom = 9;
            gmapCtrl.AutoScroll = true;
            GMapOverlay markersOverlay = new GMapOverlay("Position der Station");
            GMapMarker marker = new GMarkerGoogle(
                new PointLatLng(XCoordinate, YCoordinate),
                GMarkerGoogleType.red);
            markersOverlay.Markers.Add(marker);
            gmapCtrl.Overlays.Add(markersOverlay);
        }
    }
}
