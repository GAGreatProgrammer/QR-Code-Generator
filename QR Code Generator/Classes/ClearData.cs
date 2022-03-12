using QR_Code_Generator.User_Controls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace QR_Code_Generator.Classes
{
    public static class ClearData
    {
        public static void Clear(string Panel)
        {
            try
            {
                switch (Panel)
                {
                    case "Calendar":
                        CalendarPanel.Instance.Subject.Clear();
                        CalendarPanel.Instance.Location.Clear();
                        CalendarPanel.Instance.StartDate.Value = DateTime.Now;
                        CalendarPanel.Instance.EndDate.Value = DateTime.Now;
                        CalendarPanel.Instance.AllDayEvent.SelectedIndex = 0;
                        CalendarPanel.Instance.Description.Clear();
                        break;
                    case "Email":
                        EmailPanel.Instance.Message.Clear();
                        break;
                    case "Location":
                        LocationPanel.Instance.Latitude.Clear();
                        LocationPanel.Instance.Longitude.Clear();
                        break;
                    case "Password":
                        OneTimePasswordPanel.Instance.Type.SelectedIndex = 0;
                        OneTimePasswordPanel.Instance.AuthAlgorithm.SelectedIndex = 0;
                        OneTimePasswordPanel.Instance.Secret.Clear();
                        OneTimePasswordPanel.Instance.Issuer.Clear();
                        OneTimePasswordPanel.Instance.Label.Clear();
                        OneTimePasswordPanel.Instance.Digits.Text = "6";
                        OneTimePasswordPanel.Instance.Counter.Clear();
                        OneTimePasswordPanel.Instance.Period.Clear();
                        break;
                    case "QRCodeDataOpen":
                        RetrievedDataPanel.Instance.QRCodeData.Clear();
                        break;
                    case "SMS":
                        SMSPanel.Instance.Message.Clear();
                        break;
                    case "Text":
                        TextPanel.Instance.TextData.Clear();
                        break;
                    case "VCard":
                        VCardPanel.Instance.FirstName.Clear();
                        VCardPanel.Instance.LastName.Clear();
                        VCardPanel.Instance.Organization.Clear();
                        VCardPanel.Instance.OrganizationTitle.Clear();
                        VCardPanel.Instance.PhoneWork.Clear();
                        VCardPanel.Instance.PhonePrivate.Clear();
                        VCardPanel.Instance.Email.Clear();
                        VCardPanel.Instance.Website.Clear();
                        VCardPanel.Instance.Country.Clear();
                        VCardPanel.Instance.Street.Clear();
                        VCardPanel.Instance.City.Clear();
                        VCardPanel.Instance.Zipcode.Clear();
                        break;
                    case "WhatsApp":
                        WhatsAppMessagePanel.Instance.Message.Clear();
                        break;
                }
                GlobalVariables.QRCodeColor = Color.Black;
                GlobalVariables.QRCodeIcon = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
