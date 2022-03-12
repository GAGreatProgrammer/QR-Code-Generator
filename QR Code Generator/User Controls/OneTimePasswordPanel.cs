using Bunifu.UI.WinForms;
using QRCoder;
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
    public partial class OneTimePasswordPanel : UserControl
    {
        private static OneTimePasswordPanel _instance;

        public PayloadGenerator.OneTimePassword.OneTimePasswordAuthType oneTimePasswordAuthType;
        public PayloadGenerator.OneTimePassword.OneTimePasswordAuthAlgorithm oneTimePasswordAuthAlgorithm;

        public static OneTimePasswordPanel Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new OneTimePasswordPanel();
                return _instance;
            }
        }

        public OneTimePasswordPanel()
        {
            InitializeComponent();
            cboType.SelectedIndex = 0;
            cboAuthAlgorithm.SelectedIndex = 0;
            txtDigits.Text = "6";
        }

        public BunifuDropdown Type
        {
            get { return cboType; }
            set { cboType = value; }
        }

        public BunifuDropdown AuthAlgorithm
        {
            get { return cboAuthAlgorithm; }
            set { cboAuthAlgorithm = value; }
        }

        public BunifuTextBox Secret
        {
            get { return txtSecret; }
            set { txtSecret = value; }
        }

        public BunifuTextBox Issuer
        {
            get { return txtIssuer; }
            set { txtIssuer = value; }
        }

        public BunifuTextBox Label
        {
            get { return txtLabel; }
            set { txtLabel = value; }
        }

        public BunifuTextBox Digits
        {
            get { return txtDigits; }
            set { txtDigits = value; }
        }

        public BunifuTextBox Counter
        {
            get { return txtCounter; }
            set { txtCounter = value; }
        }

        public BunifuTextBox Period
        {
            get { return txtPeriod; }
            set { txtPeriod = value; }
        }

        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboType.SelectedIndex == 0)
                oneTimePasswordAuthType = PayloadGenerator.OneTimePassword.OneTimePasswordAuthType.TOTP;
            else if (cboType.SelectedIndex == 1)
                oneTimePasswordAuthType = PayloadGenerator.OneTimePassword.OneTimePasswordAuthType.HOTP;
        }

        private void cboAuthAlgorithm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboAuthAlgorithm.SelectedIndex == 0)
                oneTimePasswordAuthAlgorithm = PayloadGenerator.OneTimePassword.OneTimePasswordAuthAlgorithm.SHA1;
            else if (cboAuthAlgorithm.SelectedIndex == 1)
                oneTimePasswordAuthAlgorithm = PayloadGenerator.OneTimePassword.OneTimePasswordAuthAlgorithm.SHA256;
            else if (cboAuthAlgorithm.SelectedIndex == 2)
                oneTimePasswordAuthAlgorithm = PayloadGenerator.OneTimePassword.OneTimePasswordAuthAlgorithm.SHA512;

        }
    }
}
