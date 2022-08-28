using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace Interfaz_Posturas.formularios
{
    public partial class CameraSetting : Form
    {
        public static CameraSetting Current;

        public string path = @"C:\Users\Victor\Documents\Victor\Proyectos\C#\Interfaz_Posturas\Records\";
        //public string path = Directory.GetCurrentDirectory();
        public FilterInfoCollection MyDevices;
        private VideoCaptureDevice TestWebcam;
        public bool isDevice;

        public CameraSetting()
        {
            InitializeComponent();
            Current = this;
        }

        public void LoadDevices()
        {
            MyDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (MyDevices.Count > 0)
            {
                isDevice = true;
                for (int i = 0; i < MyDevices.Count; i++)
                    DeviceBox.Items.Add(MyDevices[i].Name.ToString());
                DeviceBox.Text = MyDevices[0].Name.ToString();
            }
            else
                isDevice = false;
        }

        private void TestCloseCamera()
        {
            if (TestWebcam != null && TestWebcam.IsRunning)
            {
                TestWebcam.SignalToStop();
                TestWebcam = null;
            }
        }

        private void CaptureTest(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap pictureTest = (Bitmap)eventArgs.Frame.Clone();
            TestPictureBox.Image = pictureTest;
        }

        private void CameraSetting_Load(object sender, EventArgs e)
        {
            LoadDevices();
        }

        private void DeviceButton_Click(object sender, EventArgs e)
        {
            TestCloseCamera();
            MainMenu.instance.CloseCamera();
            int i = DeviceBox.SelectedIndex;
            MainMenu.instance.cameraSelection = MyDevices[i].MonikerString;
            MainMenu.instance.record_path = path;
            this.Close();
        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            TestCloseCamera();
            int j = DeviceBox.SelectedIndex;
            string TestVideo = MyDevices[j].MonikerString;
            TestWebcam = new VideoCaptureDevice(TestVideo);
            TestWebcam.NewFrame += new NewFrameEventHandler(CaptureTest);
            TestWebcam.Start();
        }

        private void CameraSetting_FormClosing(object sender, FormClosingEventArgs e)
        {
            TestCloseCamera();
            MainMenu.instance.CloseCamera();
            try
            {
                int i = DeviceBox.SelectedIndex;
                MainMenu.instance.cameraSelection = MyDevices[i].MonikerString;
                MainMenu.instance.record_path = path;
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CameraSetting_FormClosed(object sender, FormClosedEventArgs e)
        {
            TestCloseCamera();
            MainMenu.instance.CloseCamera();
        }
    }
}
