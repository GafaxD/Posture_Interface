using System;
using System.Drawing;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace Interfaz_Posturas.formularios
{
    public partial class CameraSetting : Form
    {
        string path = null;
        public static CameraSetting Current;
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

        // send the image test
        private void CaptureTest(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap pictureTest = (Bitmap)eventArgs.Frame.Clone();
            TestPictureBox.Image = pictureTest;
        }

        // load the aplication
        private void CameraSetting_Load(object sender, EventArgs e)
        {
            LoadDevices();
        }

        // Select the camera device
        private void DeviceButton_Click(object sender, EventArgs e)
        {
            TestCloseCamera();
            MainMenu.instance.CloseCamera();
            int i = DeviceBox.SelectedIndex;
            MainMenu.instance.cameraSelection = MyDevices[i].MonikerString;
            MainMenu.instance.record_path = path;
            this.Close();
        }

        // test the camera settings
        private void TestButton_Click(object sender, EventArgs e)
        {
            TestCloseCamera();
            int j = DeviceBox.SelectedIndex;
            string TestVideo = MyDevices[j].MonikerString;
            TestWebcam = new VideoCaptureDevice(TestVideo);
            TestWebcam.NewFrame += new NewFrameEventHandler(CaptureTest);
            TestWebcam.Start();
        }

        // Camera is closing
        private void CameraSetting_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (path == null)
            {
                if (MessageBox.Show("No ha accedido ninguna ruta de guardado, esto hara que no se guarden los datos de la prueba ¿Desea realmente abandonar la aplicación?",
                    "CIERRE APLICACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
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

        // Camera close
        private void CameraSetting_FormClosed(object sender, FormClosedEventArgs e)
        {
            TestCloseCamera();
            MainMenu.instance.CloseCamera();
        }

        // Record path for save file
        private void SearchFileButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                path = dialog.SelectedPath;
                RouteTextBox.Text = path;
            }
        }
    }
}
