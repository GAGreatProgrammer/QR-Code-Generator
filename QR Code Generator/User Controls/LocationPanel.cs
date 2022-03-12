using Bunifu.UI.WinForms;
using GMap.NET;
using GMap.NET.MapProviders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QR_Code_Generator
{
    public partial class LocationPanel : UserControl
    {
        private static LocationPanel _instance;

        public static LocationPanel Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new LocationPanel();
                return _instance;
            }
        }

        public LocationPanel()
        {
            InitializeComponent();
        }

        public BunifuTextBox Latitude
        {
            get { return txtLatitude; }
            set { txtLatitude = value; }
        }

        public BunifuTextBox Longitude
        {
            get { return txtLongitude; }
            set { txtLongitude = value; }
        }

        private void btnClearAddress_Click(object sender, EventArgs e)
        {
            try
            {
                this.Map.MapProvider = (GMapProvider)GMapProviders.GoogleMap;
                this.Map.DragButton = MouseButtons.Left;
                this.Map.Position = new PointLatLng(double.Parse(this.txtLatitude.Text), double.Parse(this.txtLongitude.Text));
            }
            catch
            {

            }
        }

        private void LocationPanel_Load(object sender, EventArgs e)
        {

        }
    }
}
