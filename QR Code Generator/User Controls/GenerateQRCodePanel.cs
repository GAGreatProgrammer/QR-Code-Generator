using QR_Code_Generator.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QR_Code_Generator.User_Controls
{
    public partial class GenerateQRCodePanel : UserControl
    {
        private static GenerateQRCodePanel _instance;


        public static GenerateQRCodePanel Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new GenerateQRCodePanel();
                return _instance;
            }
        }

        public GenerateQRCodePanel()
        {
            InitializeComponent();

            GlobalVariables.PixelsPerModule = 50;
            lblPixelsPerModule.Text = "50 PX";
            GenerateQRCode.Preview(QRCode);
        }

        public PictureBox QRCodeImage
        {
            get { return QRCode; }
            set { QRCode = value; }
        }

        private void btnCreateQRCode_Click(object sender, EventArgs e)
        {
            GenerateQRCode.Generate(QRCode);
        }

        private void SliderPixelsPerModule_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
            GlobalVariables.PixelsPerModule = SliderPixelsPerModule.Value;
            lblPixelsPerModule.Text = $"{SliderPixelsPerModule.Value} PX";
        }

        private void btnDownloadImage_Click(object sender, EventArgs e)
        {
            DownloadImage.SaveQRCode(QRCode);
        }

        private void GenerateQRCodePanel_Load(object sender, EventArgs e)
        {

        }
    }
}
