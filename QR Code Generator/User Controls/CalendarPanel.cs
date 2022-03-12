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

namespace QR_Code_Generator.User_Controls
{
    public partial class CalendarPanel : UserControl
    {
        private static CalendarPanel _instance;

        public static CalendarPanel Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CalendarPanel();
                return _instance;
            }
        }

        public CalendarPanel()
        {
            InitializeComponent();
            cboAllDayEvent.SelectedIndex = 0;
        }

        public BunifuTextBox Subject
        {
            get { return txtSubject; }
            set { txtSubject = value; }
        }

        public BunifuTextBox Location
        {
            get { return txtLocation; }
            set { txtLocation = value; }
        }

        public BunifuDatePicker StartDate
        {
            get { return dtpStartDate; }
            set { dtpStartDate = value; }
        }

        public BunifuDatePicker EndDate
        {
            get { return dtpEndDate; }
            set { dtpEndDate = value; }
        }

        public BunifuDropdown AllDayEvent
        {
            get { return cboAllDayEvent; }
            set { cboAllDayEvent = value; }
        }

        public BunifuTextBox Description
        {
            get { return txtDescription; }
            set { txtDescription = value; }
        }

        private void cboAllDayEvent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboAllDayEvent.Text == "YES")
                GlobalVariables.AllDayEvent = true;
            else if (cboAllDayEvent.Text == "NO")
                GlobalVariables.AllDayEvent = false;
        }
    }
}
