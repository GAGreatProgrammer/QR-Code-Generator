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
    public partial class VCardPanel : UserControl
    {
        private static VCardPanel _instance;

        public static VCardPanel Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new VCardPanel();
                return _instance;
            }
        }

        public VCardPanel()
        {
            InitializeComponent();
        }

        public BunifuTextBox FirstName
        {
            get { return txtFirstName; }
            set { txtFirstName = value; }
        }

        public BunifuTextBox LastName
        {
            get { return txtLastName; }
            set { txtLastName = value; }
        }

        public BunifuTextBox Organization
        {
            get { return txtOrganization; }
            set { txtOrganization = value; }
        }

        public BunifuTextBox OrganizationTitle
        {
            get { return txtOrgTitle; }
            set { txtOrgTitle = value; }
        }

        public BunifuTextBox PhoneWork
        {
            get { return txtPhoneWork; }
            set { txtPhoneWork = value; }
        }

        public BunifuTextBox PhonePrivate
        {
            get { return txtPhonePrivate; }
            set { txtPhonePrivate = value; }
        }

        public BunifuTextBox Email
        {
            get { return txtEmail; }
            set { txtEmail = value; }
        }

        public BunifuTextBox Website
        {
            get { return txtWebsite; }
            set { txtWebsite = value; }
        }

        public BunifuTextBox Country
        {
            get { return txtCountry; }
            set { txtCountry = value; }
        }

        public BunifuTextBox Street
        {
            get { return txtStreet; }
            set { txtStreet = value; }
        }

        public BunifuTextBox City
        {
            get { return txtCity; }
            set { txtCity = value; }
        }

        public BunifuTextBox Zipcode
        {
            get { return txtZipcode; }
            set { txtZipcode = value; }
        }
    }
}
