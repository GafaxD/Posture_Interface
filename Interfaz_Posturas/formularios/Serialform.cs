using System;
using System.Windows.Forms;
using System.IO.Ports;

namespace Interfaz_Posturas.formularios
{
    public partial class Serialform : Form
    {
        public Serialform()
        {
            InitializeComponent();
        }

        private void Serialform_Load(object sender, EventArgs e)
        {
            // Buscar Opciones del puerto COM
            string[] ports = SerialPort.GetPortNames();
            portbox.Items.AddRange(ports);
            if (ports.Length > 0)
                portbox.Text = ports[0];
            baudratebox.Text = "9600";

        }

        private void saveconfig_Click(object sender, EventArgs e)
        {
            MainMenu.instance.box_port = portbox.Text;
            MainMenu.instance.box_baud = baudratebox.Text;
            this.Close();
        }

        private void Serialform_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (portbox.Text == "" || baudratebox.Text == "")
            {
                if (MessageBox.Show("No ha accedido ningun puerto o baudrate ¿Desea realmente abandonar la aplicación?",
                    "CIERRE APLICACIÓN", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
