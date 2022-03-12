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

namespace QR_Code_Generator
{
    public partial class EmailPanel : UserControl
    {
        private static EmailPanel _instance;

        public static EmailPanel Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new EmailPanel();
                return _instance;
            }
        }

        public EmailPanel()
        {
            InitializeComponent();
        }

        public BunifuTextBox To
        {
            get { return txtTo; }
            set { txtTo = value; }
        }

        public BunifuTextBox Subject
        {
            get { return txtSubject; }
            set { txtSubject = value; }
        }

        public BunifuTextBox Message
        {
            get { return txtMessage; }
            set { txtMessage = value; }
        }

        private void btnClearTo_Click(object sender, EventArgs e)
        {
            txtTo.Clear();
        }

        private void btnClearSubject_Click(object sender, EventArgs e)
        {
            txtSubject.Clear();
        }
    }
}
