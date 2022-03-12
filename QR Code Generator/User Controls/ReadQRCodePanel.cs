using AForge.Video;
using AForge.Video.DirectShow;
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
using ZXing;

namespace QR_Code_Generator.User_Controls
{
    public partial class ReadQRCodePanel : UserControl
    {
        private static ReadQRCodePanel _instance;

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;

        public static ReadQRCodePanel Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ReadQRCodePanel();
                return _instance;
            }
        }

        public ReadQRCodePanel()
        {
            InitializeComponent();
        }

        private void ReadQRCodePanel_Load(object sender, EventArgs e)
        {
            try
            {
                filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                foreach (FilterInfo filterInfo in filterInfoCollection)
                    cboCamera.Items.Add(filterInfo.Name);
                cboCamera.SelectedIndex = 0;
            }
            catch
            {

            }

            btnStop.Enabled = false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            ReadQRCode.Read(CameraImage, timer, btnStop, btnRead, btnClear, captureDevice);
        }

        private void ReadFromImage()
        {
            try
            {
                if(GlobalVariables.QRCodeImage != null)
                {
                    ReadQRCode.ReadFromImage(GlobalVariables.QRCodeImage);
                    GlobalVariables.QRCodeImage = null;
                    GlobalVariables.ReadTypeFlag = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void ReadFromCamera()
        {
            try
            {
                if (CameraImage.Image == null)
                {
                    captureDevice = new VideoCaptureDevice(filterInfoCollection[cboCamera.SelectedIndex].MonikerString);
                    captureDevice.NewFrame += FinalFrame_NewFrame;
                    captureDevice.Start();
                    timer.Start();

                    btnRead.Enabled = false;
                    btnStop.Enabled = true;
                    btnClear.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                this.filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                if (this.filterInfoCollection.Count >= 1 && GlobalVariables.ReadTypeFlag == 0)
                {
                    this.ReadFromCamera();
                }
                else
                {
                    if ((this.filterInfoCollection.Count != 0 || GlobalVariables.ReadTypeFlag != 1) && (this.filterInfoCollection.Count < 1 || GlobalVariables.ReadTypeFlag != 1))
                        return;
                    this.ReadFromImage();
                }
            }
            catch
            {

            }
        }

        public void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            CameraImage.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            try
            {
                filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                if (filterInfoCollection.Count >= 1)
                {
                    foreach (FilterInfo filterInfo in filterInfoCollection)
                        cboCamera.Items.Add(filterInfo.Name);
                    cboCamera.SelectedIndex = 0;
                }
                else if (filterInfoCollection.Count == 0)
                {
                    cboCamera.Items.Clear();
                    cboCamera.Text = "";
                }
            }
            catch
            {
            }
            try
            {
                List<object> objectList = new List<object>();
                foreach (object obj in cboCamera.Items)
                {
                    if (!objectList.Contains(obj))
                        objectList.Add(obj);
                }
                cboCamera.Items.Clear();
                cboCamera.Items.AddRange(objectList.ToArray());
                cboCamera.SelectedIndex = 0;
            }
            catch
            {
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                if (captureDevice.IsRunning)
                {
                    captureDevice.Stop();
                    CameraImage.Image = null;
                    CameraImage.BackColor = Color.White;
                    CameraImage.Enabled = true;
                }
                else
                {
                    int num = this.captureDevice.IsRunning ? 1 : 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            btnRead.Enabled = true;
            
            btnStop.Enabled = false;
            
            btnClear.Enabled = true;
        }

        private void btnUploadQRCodeImage_Click(object sender, EventArgs e)
        {
            GlobalVariables.ReadTypeFlag = 1;
            if (GlobalVariables.ReadTypeFlag == 1)
            {
                ReadQRCode.StoreQRCodeImage();
            }
            else
            {
                if (GlobalVariables.QRCodeImage != null)
                    return;
                GlobalVariables.ReadTypeFlag = 0;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            GlobalVariables.QRCodeImage = null;
            GlobalVariables.ReadTypeFlag = 0;
            RetrievedDataPanel.Instance.QRCodeData.Clear();
        }
    }
}
