using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QR_Code_Generator.Classes
{
    public static class DownloadImage
    {
        public static void SaveQRCode(PictureBox QRCode)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();

                saveFileDialog.InitialDirectory = @"C:\";
                saveFileDialog.Title = "Save QR Code";
                saveFileDialog.CheckPathExists = true;
                saveFileDialog.DefaultExt = "jpg";
                saveFileDialog.Filter = "Image |*.jpg";
                saveFileDialog.FilterIndex = 2;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    QRCode.Image.Save(saveFileDialog.FileName, ImageFormat.Jpeg);
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
