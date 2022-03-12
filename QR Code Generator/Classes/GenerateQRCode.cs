using QR_Code_Generator.User_Controls;
using QRCoder;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QRCoder.PayloadGenerator;
using static QRCoder.PayloadGenerator.WiFi;

namespace QR_Code_Generator.Classes
{
    public class GenerateQRCode
    {

        public static Bitmap QRCodeImage = null;

        public static int PixelsPerModule = GlobalVariables.PixelsPerModule;

        public static Color QRCodeColor = Color.Black;

        public static Bitmap Icon = null;

        public static void Preview(PictureBox QRCode)
        {
            try
            {
                var QRCodeData = "";


                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(QRCodeData, QRCodeGenerator.ECCLevel.H);
                QRCode qrCode = new QRCode(qrCodeData);

                QRCode.Image = qrCode.GetGraphic(pixelsPerModule: PixelsPerModule, darkColor: GlobalVariables.QRCodeColor, 
                    lightColor: Color.White, icon: null, iconSizePercent: 15, iconBorderWidth: 50, iconBackgroundColor: 
                    Color.White, drawQuietZones: false);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        

        public static void Text(string Text)
        {
            try
            {
                var QRCodeData = Text;


                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(QRCodeData, QRCodeGenerator.ECCLevel.H);
                QRCode qrCode = new QRCode(qrCodeData);

                QRCodeImage = qrCode.GetGraphic(pixelsPerModule: PixelsPerModule, darkColor: QRCodeColor, lightColor: Color.White, 
                    icon: Icon, iconSizePercent: 10, iconBorderWidth: 50, iconBackgroundColor: Color.White, drawQuietZones: false);
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }


        public static void Email(string To, string Subject, string Message)
        {
            try
            {
                Mail mail = new Mail(To, Subject, Message);
                string EmailPayload = mail.ToString();


                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(EmailPayload, QRCodeGenerator.ECCLevel.H);
                QRCode qrCode = new QRCode(qrCodeData);

                QRCodeImage = qrCode.GetGraphic(pixelsPerModule: PixelsPerModule, darkColor: QRCodeColor, lightColor: Color.White, 
                    icon: Icon, iconSizePercent: 15, iconBorderWidth: 50, iconBackgroundColor: Color.White, drawQuietZones: false);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        public static void VCard(string FirstName, string LastName, string Organization, string OrganizationTitle, string PhoneW, 
            string PhoneP, string Email, string Website, string Country, string Street, string City, string Zipcode)
        {
            try
            {
                ContactData contactData = new ContactData(ContactData.ContactOutputType.VCard3, firstname: FirstName, lastname: LastName,
                org: Organization, orgTitle: OrganizationTitle, workPhone: PhoneW, phone: PhoneP, email: Email, website: Website,
                country: Country, street: Street, city: City, zipCode: Zipcode);
                string VCardPayload = contactData.ToString();


                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(VCardPayload, QRCodeGenerator.ECCLevel.H);
                QRCode qrCode = new QRCode(qrCodeData);

                QRCodeImage = qrCode.GetGraphic(pixelsPerModule: PixelsPerModule, darkColor: QRCodeColor, lightColor: Color.White, 
                    icon: Icon, iconSizePercent: 15, iconBorderWidth: 50, iconBackgroundColor: Color.White, drawQuietZones: false);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }       
        }


        public static void Location(string Latitude, string Longitude)
        {
            try
            {
                Geolocation geolocation = new Geolocation(Latitude, Longitude);
                string GeolocationPayload = geolocation.ToString();


                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(GeolocationPayload, QRCodeGenerator.ECCLevel.H);
                QRCode qrCode = new QRCode(qrCodeData);

                QRCodeImage = qrCode.GetGraphic(pixelsPerModule: PixelsPerModule, darkColor: QRCodeColor, lightColor: Color.White, 
                    icon: Icon, iconSizePercent: 15, iconBorderWidth: 50, iconBackgroundColor: Color.White, drawQuietZones: false);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }


        public static void Calendar(string Subject, string Description, string Location, DateTime Start, DateTime End, bool AllDayEvent)
        {
            try
            {
                CalendarEvent calendarEvent = new CalendarEvent(subject: Subject, description: Description, location: Location, start: Start, end: End, allDayEvent: AllDayEvent);
                string CalendarPayload = calendarEvent.ToString();


                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(CalendarPayload, QRCodeGenerator.ECCLevel.H);
                QRCode qrCode = new QRCode(qrCodeData);

                QRCodeImage = qrCode.GetGraphic(pixelsPerModule: PixelsPerModule, darkColor: QRCodeColor, lightColor: Color.White, 
                    icon: Icon, iconSizePercent: 15, iconBorderWidth: 50, iconBackgroundColor: Color.White, drawQuietZones: false);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public static void SMS(string Number, string Subject)
        {
            try
            {
                SMS sms = new SMS(number: Number, subject: Subject);
                string SMSPayload = sms.ToString();


                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(SMSPayload, QRCodeGenerator.ECCLevel.H);
                QRCode qrCode = new QRCode(qrCodeData);

                QRCodeImage = qrCode.GetGraphic(pixelsPerModule: PixelsPerModule, darkColor: QRCodeColor, lightColor: Color.White, 
                    icon: Icon, iconSizePercent: 15, iconBorderWidth: 50, iconBackgroundColor: Color.White, drawQuietZones: false);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public static void WhatsAppMessage(string Number, string Message)
        {
            try
            {
                WhatsAppMessage whatsappmessage = new WhatsAppMessage(number: Number, message: Message);
                string WhatsAppMessagePayload = whatsappmessage.ToString();


                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(WhatsAppMessagePayload, QRCodeGenerator.ECCLevel.H);
                QRCode qrCode = new QRCode(qrCodeData);

                QRCodeImage = qrCode.GetGraphic(pixelsPerModule: PixelsPerModule, darkColor: QRCodeColor, lightColor: Color.White, 
                    icon: Icon, iconSizePercent: 15, iconBorderWidth: 50, iconBackgroundColor: Color.White, drawQuietZones: false);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public static void OneTimePassword(PayloadGenerator.OneTimePassword.OneTimePasswordAuthType _oneTimePassword,
            PayloadGenerator.OneTimePassword.OneTimePasswordAuthAlgorithm _oneTimePasswordAuthAlgorithm,
            string _secret, string _issuer, string _label, int _digits, int _counter, int _period)
        {
            try
            {
                OneTimePassword generator = new OneTimePassword()
                {
                    Type = _oneTimePassword,
                    AuthAlgorithm = _oneTimePasswordAuthAlgorithm,
                    Secret = _secret,
                    Issuer = _issuer,
                    Label = _label,
                    Digits = _digits,
                    Counter = _counter,
                    Period = _period
                };
                string OneTimePasswordPayload = generator.ToString();


                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(OneTimePasswordPayload, QRCodeGenerator.ECCLevel.H);
                QRCode qrCode = new QRCode(qrCodeData);

                QRCodeImage = qrCode.GetGraphic(pixelsPerModule: PixelsPerModule, darkColor: QRCodeColor, lightColor: Color.White, 
                    icon: Icon, iconSizePercent: 15, iconBorderWidth: 50, iconBackgroundColor: Color.White, drawQuietZones: false);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public static void Generate(PictureBox QRCode)
        {
            try
            {
                string CurrentContentPanel = GlobalVariables.CurrentContentPanel;
                PixelsPerModule = GlobalVariables.PixelsPerModule;
                QRCodeColor = GlobalVariables.QRCodeColor;
                Icon = GlobalVariables.QRCodeIcon;

                switch (CurrentContentPanel)
                {
                    case "Text":
                        Text(TextPanel.Instance.TextData.Text);
                        QRCode.Image = QRCodeImage;
                        break;


                    case "Email":
                        Email(EmailPanel.Instance.To.Text, EmailPanel.Instance.Subject.Text, EmailPanel.Instance.Message.Text);
                        QRCode.Image = QRCodeImage;
                        break;


                    case "VCard":
                        VCard(VCardPanel.Instance.FirstName.Text, VCardPanel.Instance.LastName.Text,
                            VCardPanel.Instance.Organization.Text, VCardPanel.Instance.OrganizationTitle.Text,
                            VCardPanel.Instance.PhoneWork.Text, VCardPanel.Instance.PhonePrivate.Text, VCardPanel.Instance.Email.Text,
                            VCardPanel.Instance.Website.Text, VCardPanel.Instance.Country.Text, VCardPanel.Instance.Street.Text,
                            VCardPanel.Instance.City.Text, VCardPanel.Instance.Zipcode.Text);
                        QRCode.Image = QRCodeImage;
                        break;


                    case "Location":
                        Location(LocationPanel.Instance.Latitude.Text, LocationPanel.Instance.Longitude.Text);
                        QRCode.Image = QRCodeImage;
                        break;


                    case "Calendar":
                        Calendar(CalendarPanel.Instance.Subject.Text, CalendarPanel.Instance.Description.Text,
                            CalendarPanel.Instance.Location.Text, CalendarPanel.Instance.StartDate.Value,
                            CalendarPanel.Instance.EndDate.Value, GlobalVariables.AllDayEvent);
                        QRCode.Image = QRCodeImage;
                        break;


                    case "SMS":
                        SMS(SMSPanel.Instance.Phone.Text, SMSPanel.Instance.Message.Text);
                        QRCode.Image = QRCodeImage;
                        break;


                    case "WhatsApp":
                        WhatsAppMessage(WhatsAppMessagePanel.Instance.Phone.Text, WhatsAppMessagePanel.Instance.Message.Text);
                        QRCode.Image = QRCodeImage;
                        break;

                    case "Password":
                        OneTimePassword(OneTimePasswordPanel.Instance.oneTimePasswordAuthType,
                                                       OneTimePasswordPanel.Instance.oneTimePasswordAuthAlgorithm,

                            OneTimePasswordPanel.Instance.Secret.Text, OneTimePasswordPanel.Instance.Issuer.Text,
                            OneTimePasswordPanel.Instance.Label.Text, int.Parse(OneTimePasswordPanel.Instance.Digits.Text),
                            int.Parse(OneTimePasswordPanel.Instance.Counter.Text), int.Parse(OneTimePasswordPanel.Instance.Period.Text));
                        QRCode.Image = QRCodeImage;
                        break;
                }
            }

            catch
            {
                
            }
        }
    }
}
