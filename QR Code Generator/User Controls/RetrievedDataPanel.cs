using Bunifu.UI.WinForms;
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
    public partial class RetrievedDataPanel : UserControl
    {
        private static RetrievedDataPanel _instance;

        public static RetrievedDataPanel Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new RetrievedDataPanel();
                return _instance;
            }
        }

        public RetrievedDataPanel()
        {
            InitializeComponent();
        }

        public BunifuTextBox QRCodeData
        {
            get { return txtQRCodeData; }
            set { txtQRCodeData = value; }
        }
    }
}
