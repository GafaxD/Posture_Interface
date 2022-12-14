using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Drawing.Imaging;
using AForge.Video;
using AForge.Video.DirectShow;

/// <sumary>
/// The GUI realalizes the visualization of the
/// positional posture measures give by the mcu
/// por el repositorio de GitHub
/// 
/// Code made by:
///     Victor Ramirez Tapia
///     Github: @GafaxD
/// </summary>

namespace Interfaz_Posturas
{
    public partial class MainMenu : Form
    {
        public static MainMenu instance;

        // Inicio de camara
        public string record_path;
        private VideoCaptureDevice MyWebCam;
        public string cameraSelection;
        Bitmap picture;

        // Para la imagen
        // Sentenciamos para la imagen
        Graphics posturepanel;
        Pen lapiz_rojo = new Pen(Color.Red);
        Pen lapiz_negro = new Pen(Color.Black);

        string dataIN;
        public string box_port, box_baud;

        // Variable para lectura de todos los datos
        private string[] cadena_ser = {"0","0","0"};

        /// <summary>
        /// Estas variables sirven para reconocer los sensores, ademas de
        /// detectar si se pasa determinado tiempo en una posicion son variables locales del namespace
        /// </summary>
        private uint s_r = 0, s_l = 0, s_f = 0, tiempo = 0, count_r = 0, count_l = 0, count_f = 0, count_files = 0;
        private int tiempo_lim = 30; // Aqui se modifica el tiempo limite en segundos
        private bool active = false;

        public MainMenu()
        {
            // instance hace referencia al puntero de la propia clase MainForm esto permite su manipulacion de metodos por fuera de esta
            InitializeComponent();
            instance = this;
        }

        private void configuracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formularios.Serialform serialform = new formularios.Serialform();
            serialform.Show();
        }

        private void MenuToolCameraSelect_Click(object sender, EventArgs e)
        {
            formularios.CameraSetting cameraSetting = new formularios.CameraSetting();
            cameraSetting.Show();
        }

        public void CloseCamera()
        {
            if (MyWebCam!=null && MyWebCam.IsRunning)
            {
                MyWebCam.SignalToStop();
                MyWebCam = null;
            }
        }

        public void CaptureImg(object sender, NewFrameEventArgs eventArgs)
        {
            picture = (Bitmap)eventArgs.Frame.Clone();
        }

        // Metodo utilizado cuando cerramos la aplicacion
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseCamera();

            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
            if (timer1.Enabled)
            {
                timer1.Enabled = false;
            }
        }

        // Metodo utilizado cuando abrimos la aplicacion
        private void Form1_Load(object sender, EventArgs e)
        {
            // Se escribe en el txt
            //fileWriter.BaseStream.Seek(0, SeekOrigin.End);
            //fileWriter.WriteLine("Bitacora de movimientos");
            //fileWriter.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),DateTime.Now.ToLongDateString());
            //fileWriter.WriteLine("===================================== \n");
            //fileWriter.Flush();

            semaforo.BackColor = System.Drawing.Color.LightGreen;
        }

        private void btn_serial_start_Click(object sender, EventArgs e)
        {
            /// <summary>
            /// El boton start iniciara el puerto seria y ademas detectara si este no pudo encontrar ninguno
            /// </summary>
            try 
            {
                MyWebCam = new VideoCaptureDevice(cameraSelection);
                MyWebCam.NewFrame += new NewFrameEventHandler(CaptureImg);
                MyWebCam.Start();

                // Abriendo serial
                serialPort1.PortName = box_port;
                serialPort1.BaudRate = Convert.ToInt32(box_baud);
                serialPort1.Open();

                // Abriendo timer
                timer1.Enabled = true;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message,"ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                CloseCamera();
                serialPort1.Close();
                active = false;
                tiempo = 0;
                timer1.Enabled = false;
            }
        }

        private void btn_serial_close_Click(object sender, EventArgs e)
        {
            CloseCamera();
            
            // Cerrar el puerto serie
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                active = false;
                tiempo = 0;
            }
            if (timer1.Enabled)
            {
                timer1.Enabled = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /// <summary>
            /// El timer se ejecutara cada segundo y capturara los datos en el txt
            /// cuando pase cierto limite de tiempo asignado por la variable en el if
            /// este activara la nota de que se a pasado cierto tiempo fuera de un rango de movimiento
            /// </summary>
            //fileWriter.WriteLine(DateTime.Now.ToLongTimeString());
            //fileWriter.WriteLine(
            //    "Distancia a la izquierda: {0} Distancia a la derecha: {1} Distancia de enfrente: {2}"
            //    ,cadena_ser[0],cadena_ser[2],cadena_ser[1]);
            //fileWriter.Flush();

            // Incrementos para reconocer posiciones en el tiempo
            if(s_l < 10)
            {
                count_l++;
            }
            if(s_r < 10)
            {
                count_r++;
            }
            if(s_f < 10)
            {
                count_f++;
            }

            // Se crean graficos
            posturepanel = pictureBox1.CreateGraphics();
            posturepanel.Clear(Color.White);

            // Dimensiones del cuadro 270 * 80

            for (int i = 0; i <= 270; i += 5)
            {
                posturepanel.DrawLine(lapiz_negro, i, 43, i, 37);
            }
            posturepanel.DrawLine(lapiz_negro, 0, 40, 270, 40); // Eje X
            posturepanel.DrawLine(lapiz_negro, 135, 0, 135, 80); // Eje Y
            if (s_r <= 135)
            {
                posturepanel.DrawLine(lapiz_rojo, 135 + s_r, 0, 135 + s_r, 80);
            }
            else
            {
                posturepanel.DrawLine(lapiz_rojo, 270, 0, 270, 80);
            }
            if (s_l <= 135)
            {
                posturepanel.DrawLine(lapiz_rojo, 135 - s_l, 0, 135 - s_l, 80);
            }
            else
            {
                posturepanel.DrawLine(lapiz_rojo, 0, 0, 0, 80);
            }

            // Incrementamos tiempo
            tiempo++;

            // Condiciones para posiciones
            if (tiempo == tiempo_lim)
            {
                if(count_f > tiempo_lim * 0.8 || count_r > tiempo_lim * 0.8 || count_l > tiempo_lim * 0.8)
                {
                    if (count_f > count_l && count_f > count_r)
                    {
                        picture.Save(@"\" + record_path + "Imagen " + count_files++.ToString() + ".jpg", ImageFormat.Jpeg);
                        semaforo.BackColor = System.Drawing.Color.Red;
                        MessageBox.Show("Carga frontal", "Alerta de postura", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (count_r > count_f && count_r > count_l)
                    {
                        picture.Save(@"\" + record_path + "Imagen " + count_files++.ToString() + ".jpg", ImageFormat.Jpeg);
                        semaforo.BackColor = System.Drawing.Color.Red;
                        MessageBox.Show("Carga derecha", "Alerta de postura", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (count_l > count_f && count_l > count_r)
                    {
                        picture.Save(@"\" + record_path + "Imagen " + count_files++.ToString() + ".jpg", ImageFormat.Jpeg);
                        semaforo.BackColor = System.Drawing.Color.Red;
                        MessageBox.Show("Carga izquierda", "Alerta de postura", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    semaforo.BackColor = System.Drawing.Color.LightGreen;
                }
                count_f = 0;
                count_l = 0;
                count_r = 0;
                tiempo = 0;
            }
            if (tiempo == 2)
            {
                active = true;
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // Recibimos datos del serial
            dataIN = serialPort1.ReadTo("F");
            this.Invoke(new EventHandler(ShowData));
        }

        private void ShowData(object sender, EventArgs e)
        {
            if (active || tiempo == 2)
            {
                // Leemos informacion
                cadena_ser = dataIN.Split('A');
                Ind_Izq.Text = cadena_ser[0] + " cm";
                Indc_Frente.Text = cadena_ser[1] + " cm";
                Ind_Der.Text = cadena_ser[2] + " cm";
                s_l = Convert.ToUInt32(cadena_ser[0]);
                s_f = Convert.ToUInt32(cadena_ser[1]);
                s_r = Convert.ToUInt32(cadena_ser[2]);
            }
        }
    }
}
