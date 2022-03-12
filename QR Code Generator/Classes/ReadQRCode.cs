using AForge.Video.DirectShow;
using QR_Code_Generator.User_Controls;
using System;
using System.Drawing;
using System.Windows.Forms;
using ZXing;

namespace QR_Code_Generator.Classes
{
    public static class ReadQRCode
    {
        public static void Read(PictureBox CameraImage, Timer timer, Bunifu.UI.WinForms.BunifuButton.BunifuButton Stop,
                                Bunifu.UI.WinForms.BunifuButton.BunifuButton Read,
                                Bunifu.UI.WinForms.BunifuButton.BunifuButton Clear,
                                VideoCaptureDevice captureDevice)
        {
            try
            {
                if (CameraImage.Image == null)
                    return;
                Result result = new BarcodeReader().Decode((Bitmap)CameraImage.Image);
                if (result == null)
                    return;
                RetrievedDataPanel.Instance.QRCodeData.Text = result.ToString();
                timer.Stop();
                captureDevice.Stop();
                CameraImage.Image = (Image)null;
                CameraImage.BackColor = Color.White;
                CameraImage.Enabled = true;
                Read.Enabled = true;
                Stop.Enabled = false;
                Clear.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static void StoreQRCodeImage()
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Title = "Upload QR Code";
                openFileDialog.CheckPathExists = true;
                openFileDialog.DefaultExt = "jpg";
                openFileDialog.Filter = "Image |*.jpg";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    GlobalVariables.QRCodeImage = new Bitmap(openFileDialog.FileName);
                    GlobalVariables.QRCodeImagePath = openFileDialog.FileName;
                }
                else
                {
                    GlobalVariables.QRCodeImage = (Bitmap)null;
                    GlobalVariables.QRCodeImagePath = (string)null;
                    GlobalVariables.ReadTypeFlag = 0;
                }
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show(ex.Message);
            }
        }

        public static void ReadFromImage(Bitmap QRCodeImage)
        {
            if (QRCodeImage == null)
                return;
            Result result = new BarcodeReader().Decode(QRCodeImage);
            if (result == null)
                return;
            RetrievedDataPanel.Instance.QRCodeData.Text = result.ToString();
        }
    }
}
