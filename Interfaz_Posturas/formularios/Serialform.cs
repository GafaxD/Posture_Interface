﻿using System;
using System.Windows.Forms;
using System.IO.Ports;

namespace Interfaz_Posturas.formularios
{
    public partial class Serialform : Form
    {
        public string puerto, baudios;

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
            Form1.instance.box_port = portbox.Text;
            Form1.instance.box_baud = baudratebox.Text;
            this.Close();
        }
    }
}
