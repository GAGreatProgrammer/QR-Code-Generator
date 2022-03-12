using Bunifu.UI.WinForms;
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

namespace QR_Code_Generator
{
    public partial class TextPanel : UserControl
    {
        private static TextPanel _instance;

        public static TextPanel Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new TextPanel();
                return _instance;
            }
        }

        public TextPanel()
        {
            InitializeComponent();
        }

        public BunifuTextBox TextData
        {
            get { return txtTextInput; }
            set { txtTextInput = value; }
        }

    }
}
