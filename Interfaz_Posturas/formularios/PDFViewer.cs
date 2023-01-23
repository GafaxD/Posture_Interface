using System;
using System.Windows.Forms;

namespace Interfaz_Posturas.formularios
{
    public partial class PDFViewer : Form
    {
        public PDFViewer()
        {
            InitializeComponent();
        }

        private void PDFViewer_Load(object sender, EventArgs e)
        {
            try 
            {
                axAcroPDF1.LoadFile("Manual de Ejercicios.pdf");
            } catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el PDF, instale Adobe PDF Reader o inserte el archivo PDF en el path del programa", "Error: " + ex.GetType(), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
