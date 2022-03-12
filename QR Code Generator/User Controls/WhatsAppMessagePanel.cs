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
    public partial class WhatsAppMessagePanel : UserControl
    {
        private static WhatsAppMessagePanel _instance;

        public static WhatsAppMessagePanel Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new WhatsAppMessagePanel();
                return _instance;
            }
        }

        public WhatsAppMessagePanel()
        {
            InitializeComponent();
        }

        public BunifuTextBox Phone
        {
            get { return txtPhone; }
            set { txtPhone = value; }
        }

        public BunifuTextBox Message
        {
            get { return txtMessage; }
            set { txtMessage = value; }
        }

        private void btnClearPhone_Click(object sender, EventArgs e)
        {
            txtPhone.Clear();
        }
    }
}
