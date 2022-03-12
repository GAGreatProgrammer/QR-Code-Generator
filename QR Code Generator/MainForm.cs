using QR_Code_Generator.Classes;
using QR_Code_Generator.User_Controls;
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
    public partial class MainForm : Form
    {
        List<Bunifu.UI.WinForms.BunifuButton.BunifuButton> buttons;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            this.Icon = Properties.Resources.Icon;
            buttons = new List<Bunifu.UI.WinForms.BunifuButton.BunifuButton>()
              {
                btnText,
                btnEmail,
                btnVCard,
                btnLocation,
                btnCalendar,
                btnSMS,
                btnWhatsApp,
                btnPassword
              };

            GlobalVariables.CurrentContentPanel = "Text";
            SeparatorOff();
            StartupConfig();
        }

        private void SeparatorOff()
        {
            TextSeparator.Visible = false;
            EmailSeparator.Visible = false;
            VCardSeparator.Visible = false;
            LocationSeparator.Visible = false;
            CalendarSeparator.Visible = false;
            SMSSeparator.Visible = false;
            WhatsAppSeparator.Visible = false;
            PasswordSeparator.Visible = false;
        }

        private void StartupConfig()
        {
            SeparatorOff();
            TextSeparator.Visible = true;

            if (!ContentPanel.Controls.Contains(TextPanel.Instance))
            {
                ContentPanel.Controls.Add(TextPanel.Instance);
                TextPanel.Instance.Dock = DockStyle.Fill;
                TextPanel.Instance.BringToFront();
            }

            else
            {
                TextPanel.Instance.BringToFront();
            }


            ReadSeparator.Visible = false;
            GenerateSeparator.Visible = true;

            if (!QRCodePanel.Controls.Contains(GenerateQRCodePanel.Instance))
            {
                QRCodePanel.Controls.Add(GenerateQRCodePanel.Instance);
                GenerateQRCodePanel.Instance.Dock = DockStyle.Fill;
                GenerateQRCodePanel.Instance.BringToFront();
            }

            else
            {
                GenerateQRCodePanel.Instance.BringToFront();
            }
        }


        private void btnText_Click(object sender, EventArgs e)
        {
            SeparatorOff();
            TextSeparator.Visible = true;

            GlobalVariables.CurrentContentPanel = "Text";

            if (!ContentPanel.Controls.Contains(TextPanel.Instance))
            {
                ContentPanel.Controls.Add(TextPanel.Instance);
                TextPanel.Instance.Dock = DockStyle.Fill;
                TextPanel.Instance.BringToFront();
            }

            else
            {
                TextPanel.Instance.BringToFront();
            }
        }

        private void btnEmail_Click(object sender, EventArgs e)
        {
            SeparatorOff();
            EmailSeparator.Visible = true;

            GlobalVariables.CurrentContentPanel = "Email";

            if (!ContentPanel.Controls.Contains(EmailPanel.Instance))
            {
                ContentPanel.Controls.Add(EmailPanel.Instance);
                EmailPanel.Instance.Dock = DockStyle.Fill;
                EmailPanel.Instance.BringToFront();
            }

            else
            {
                EmailPanel.Instance.BringToFront();
            }
        }

        private void btnVCard_Click(object sender, EventArgs e)
        {
            SeparatorOff();
            VCardSeparator.Visible = true;

            GlobalVariables.CurrentContentPanel = "VCard";

            if (!ContentPanel.Controls.Contains(VCardPanel.Instance))
            {
                ContentPanel.Controls.Add(VCardPanel.Instance);
                VCardPanel.Instance.Dock = DockStyle.Fill;
                VCardPanel.Instance.BringToFront();
            }

            else
            {
                VCardPanel.Instance.BringToFront();
            }
        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            SeparatorOff();
            LocationSeparator.Visible = true;

            GlobalVariables.CurrentContentPanel = "Location";

            if (!ContentPanel.Controls.Contains(LocationPanel.Instance))
            {
                ContentPanel.Controls.Add(LocationPanel.Instance);
                LocationPanel.Instance.Dock = DockStyle.Fill;
                LocationPanel.Instance.BringToFront();
            }

            else
            {
                LocationPanel.Instance.BringToFront();
            }
        }

        private void btnCalendar_Click(object sender, EventArgs e)
        {
            SeparatorOff();
            CalendarSeparator.Visible = true;

            GlobalVariables.CurrentContentPanel = "Calendar";

            if (!ContentPanel.Controls.Contains(CalendarPanel.Instance))
            {
                ContentPanel.Controls.Add(CalendarPanel.Instance);
                CalendarPanel.Instance.Dock = DockStyle.Fill;
                CalendarPanel.Instance.BringToFront();
            }

            else
            {
                CalendarPanel.Instance.BringToFront();
            }
        }

        private void btnSMS_Click(object sender, EventArgs e)
        {
            SeparatorOff();
            SMSSeparator.Visible = true;

            GlobalVariables.CurrentContentPanel = "SMS";

            if (!ContentPanel.Controls.Contains(SMSPanel.Instance))
            {
                ContentPanel.Controls.Add(SMSPanel.Instance);
                SMSPanel.Instance.Dock = DockStyle.Fill;
                SMSPanel.Instance.BringToFront();
            }

            else
            {
                SMSPanel.Instance.BringToFront();
            }
        }

        private void btnWhatsApp_Click(object sender, EventArgs e)
        {
            SeparatorOff();
            WhatsAppSeparator.Visible = true;

            GlobalVariables.CurrentContentPanel = "WhatsApp";

            if (!ContentPanel.Controls.Contains(WhatsAppMessagePanel.Instance))
            {
                ContentPanel.Controls.Add(WhatsAppMessagePanel.Instance);
                WhatsAppMessagePanel.Instance.Dock = DockStyle.Fill;
                WhatsAppMessagePanel.Instance.BringToFront();
            }

            else
            {
                WhatsAppMessagePanel.Instance.BringToFront();
            }
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            SeparatorOff();
            PasswordSeparator.Visible = true;

            GlobalVariables.CurrentContentPanel = "Password";

            if (!ContentPanel.Controls.Contains(OneTimePasswordPanel.Instance))
            {
                ContentPanel.Controls.Add(OneTimePasswordPanel.Instance);
                OneTimePasswordPanel.Instance.Dock = DockStyle.Fill;
                OneTimePasswordPanel.Instance.BringToFront();
            }

            else
            {
                OneTimePasswordPanel.Instance.BringToFront();
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            ReadSeparator.Visible = false;
            GenerateSeparator.Visible = true;
            btnSetColor.Enabled = true;
            btnAddLogo.Enabled = true;
            btnClear.Enabled = true;

            GlobalVariables.CurrentFunctionPanel = "Generate";

            if (!QRCodePanel.Controls.Contains(GenerateQRCodePanel.Instance))
            {
                QRCodePanel.Controls.Add(GenerateQRCodePanel.Instance);
                GenerateQRCodePanel.Instance.Dock = DockStyle.Fill;
                GenerateQRCodePanel.Instance.BringToFront();
            }

            else
            {
                GenerateQRCodePanel.Instance.BringToFront();
            }

            TopPanelState.StateFlag = 0;
            TopPanelState.EnableButtons(buttons);
            HideDataPanel();
        }

        private void OpendDataPanel()
        {

            if (!ContentPanel.Controls.Contains(RetrievedDataPanel.Instance))
            {
                ContentPanel.Controls.Add(RetrievedDataPanel.Instance);
                RetrievedDataPanel.Instance.Dock = DockStyle.Fill;
                RetrievedDataPanel.Instance.BringToFront();
            }

            else
            {
                RetrievedDataPanel.Instance.BringToFront();
            }
        }

        private void HideDataPanel()
        {
            if (ContentPanel.Controls.Contains(RetrievedDataPanel.Instance))
            {
                ContentPanel.Controls.Remove(RetrievedDataPanel.Instance);
            }

        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            GenerateSeparator.Visible = false;
            ReadSeparator.Visible = true;
            btnSetColor.Enabled = false;
            btnAddLogo.Enabled = false;
            btnClear.Enabled = false;

            GlobalVariables.CurrentFunctionPanel = "Read";

            if (!QRCodePanel.Controls.Contains(ReadQRCodePanel.Instance))
            {
                QRCodePanel.Controls.Add(ReadQRCodePanel.Instance);
                ReadQRCodePanel.Instance.Dock = DockStyle.Fill;
                ReadQRCodePanel.Instance.BringToFront();
            }

            else
            {
                ReadQRCodePanel.Instance.BringToFront();
            }

            OpendDataPanel();
            TopPanelState.StateFlag = 1;
            TopPanelState.DisableButtons(buttons);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearData.Clear(GlobalVariables.CurrentContentPanel);
        }

        private void btnSetColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowDialog();

            GlobalVariables.QRCodeColor = colorDialog.Color;
        }

        private void btnAddLogo_Click(object sender, EventArgs e)
        {
            try
            {
                string filename = null;
                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (DialogResult.OK == openFileDialog.ShowDialog())
                    filename = openFileDialog.FileName;
                GlobalVariables.QRCodeIcon = new Bitmap(filename);
            }
            catch
            {

            }
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
