namespace Interfaz_Posturas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Lab_Frente = new System.Windows.Forms.Label();
            this.Indc_Frente = new System.Windows.Forms.Label();
            this.Ind_Der = new System.Windows.Forms.Label();
            this.Ind_Izq = new System.Windows.Forms.Label();
            this.Lab_Izq = new System.Windows.Forms.Label();
            this.Lab_Der = new System.Windows.Forms.Label();
            this.btn_serial_start = new System.Windows.Forms.Button();
            this.btn_serial_close = new System.Windows.Forms.Button();
            this.group_distances = new System.Windows.Forms.GroupBox();
            this.group_port_ser = new System.Windows.Forms.GroupBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.posture_group = new System.Windows.Forms.GroupBox();
            this.semaforo = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.icono_ing = new System.Windows.Forms.PictureBox();
            this.scale = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.puertoCOMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elegirConfiguracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.group_distances.SuspendLayout();
            this.group_port_ser.SuspendLayout();
            this.posture_group.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.semaforo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icono_ing)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lab_Frente
            // 
            this.Lab_Frente.AutoSize = true;
            this.Lab_Frente.Location = new System.Drawing.Point(71, 15);
            this.Lab_Frente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lab_Frente.Name = "Lab_Frente";
            this.Lab_Frente.Size = new System.Drawing.Size(108, 13);
            this.Lab_Frente.TabIndex = 0;
            this.Lab_Frente.Text = "Distancia de enfrente";
            // 
            // Indc_Frente
            // 
            this.Indc_Frente.AutoSize = true;
            this.Indc_Frente.Location = new System.Drawing.Point(115, 36);
            this.Indc_Frente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Indc_Frente.Name = "Indc_Frente";
            this.Indc_Frente.Size = new System.Drawing.Size(22, 13);
            this.Indc_Frente.TabIndex = 1;
            this.Indc_Frente.Text = "0.0";
            // 
            // Ind_Der
            // 
            this.Ind_Der.AutoSize = true;
            this.Ind_Der.Location = new System.Drawing.Point(187, 96);
            this.Ind_Der.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Ind_Der.Name = "Ind_Der";
            this.Ind_Der.Size = new System.Drawing.Size(22, 13);
            this.Ind_Der.TabIndex = 1;
            this.Ind_Der.Text = "0.0";
            // 
            // Ind_Izq
            // 
            this.Ind_Izq.AutoSize = true;
            this.Ind_Izq.Location = new System.Drawing.Point(41, 96);
            this.Ind_Izq.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Ind_Izq.Name = "Ind_Izq";
            this.Ind_Izq.Size = new System.Drawing.Size(22, 13);
            this.Ind_Izq.TabIndex = 1;
            this.Ind_Izq.Text = "0.0";
            // 
            // Lab_Izq
            // 
            this.Lab_Izq.AutoSize = true;
            this.Lab_Izq.Location = new System.Drawing.Point(4, 74);
            this.Lab_Izq.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lab_Izq.Name = "Lab_Izq";
            this.Lab_Izq.Size = new System.Drawing.Size(97, 13);
            this.Lab_Izq.TabIndex = 0;
            this.Lab_Izq.Text = "Distancia Izquierda";
            // 
            // Lab_Der
            // 
            this.Lab_Der.AutoSize = true;
            this.Lab_Der.Location = new System.Drawing.Point(160, 74);
            this.Lab_Der.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lab_Der.Name = "Lab_Der";
            this.Lab_Der.Size = new System.Drawing.Size(95, 13);
            this.Lab_Der.TabIndex = 0;
            this.Lab_Der.Text = "Distancia Derecha";
            // 
            // btn_serial_start
            // 
            this.btn_serial_start.Location = new System.Drawing.Point(13, 22);
            this.btn_serial_start.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_serial_start.Name = "btn_serial_start";
            this.btn_serial_start.Size = new System.Drawing.Size(75, 19);
            this.btn_serial_start.TabIndex = 2;
            this.btn_serial_start.Text = "Comenzar";
            this.btn_serial_start.UseVisualStyleBackColor = true;
            this.btn_serial_start.Click += new System.EventHandler(this.btn_serial_start_Click);
            // 
            // btn_serial_close
            // 
            this.btn_serial_close.Location = new System.Drawing.Point(92, 22);
            this.btn_serial_close.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_serial_close.Name = "btn_serial_close";
            this.btn_serial_close.Size = new System.Drawing.Size(71, 19);
            this.btn_serial_close.TabIndex = 3;
            this.btn_serial_close.Text = "Finalizar";
            this.btn_serial_close.UseVisualStyleBackColor = true;
            this.btn_serial_close.Click += new System.EventHandler(this.btn_serial_close_Click);
            // 
            // group_distances
            // 
            this.group_distances.Controls.Add(this.Lab_Izq);
            this.group_distances.Controls.Add(this.Ind_Izq);
            this.group_distances.Controls.Add(this.Lab_Frente);
            this.group_distances.Controls.Add(this.Ind_Der);
            this.group_distances.Controls.Add(this.Indc_Frente);
            this.group_distances.Controls.Add(this.Lab_Der);
            this.group_distances.Location = new System.Drawing.Point(82, 119);
            this.group_distances.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.group_distances.Name = "group_distances";
            this.group_distances.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.group_distances.Size = new System.Drawing.Size(254, 123);
            this.group_distances.TabIndex = 4;
            this.group_distances.TabStop = false;
            this.group_distances.Text = "Distancias";
            // 
            // group_port_ser
            // 
            this.group_port_ser.Controls.Add(this.btn_serial_start);
            this.group_port_ser.Controls.Add(this.btn_serial_close);
            this.group_port_ser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.group_port_ser.Location = new System.Drawing.Point(114, 246);
            this.group_port_ser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.group_port_ser.Name = "group_port_ser";
            this.group_port_ser.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.group_port_ser.Size = new System.Drawing.Size(177, 51);
            this.group_port_ser.TabIndex = 7;
            this.group_port_ser.TabStop = false;
            this.group_port_ser.Text = "Panel de control";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // posture_group
            // 
            this.posture_group.Controls.Add(this.semaforo);
            this.posture_group.Location = new System.Drawing.Point(340, 329);
            this.posture_group.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.posture_group.Name = "posture_group";
            this.posture_group.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.posture_group.Size = new System.Drawing.Size(57, 56);
            this.posture_group.TabIndex = 8;
            this.posture_group.TabStop = false;
            this.posture_group.Text = "Postura";
            // 
            // semaforo
            // 
            this.semaforo.Location = new System.Drawing.Point(12, 22);
            this.semaforo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.semaforo.Name = "semaforo";
            this.semaforo.Size = new System.Drawing.Size(34, 26);
            this.semaforo.TabIndex = 1;
            this.semaforo.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.Location = new System.Drawing.Point(65, 314);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 81);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // icono_ing
            // 
            this.icono_ing.Image = ((System.Drawing.Image)(resources.GetObject("icono_ing.Image")));
            this.icono_ing.Location = new System.Drawing.Point(21, 40);
            this.icono_ing.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.icono_ing.Name = "icono_ing";
            this.icono_ing.Size = new System.Drawing.Size(375, 75);
            this.icono_ing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.icono_ing.TabIndex = 10;
            this.icono_ing.TabStop = false;
            // 
            // scale
            // 
            this.scale.AutoSize = true;
            this.scale.Location = new System.Drawing.Point(271, 299);
            this.scale.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.scale.Name = "scale";
            this.scale.Size = new System.Drawing.Size(65, 13);
            this.scale.TabIndex = 11;
            this.scale.Text = "Escala 5 cm";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.puertoCOMToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(433, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarToolStripMenuItem,
            this.guardarComoToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            // 
            // guardarComoToolStripMenuItem
            // 
            this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.guardarComoToolStripMenuItem.Text = "Guardar como...";
            // 
            // puertoCOMToolStripMenuItem
            // 
            this.puertoCOMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuracionToolStripMenuItem,
            this.elegirConfiguracionToolStripMenuItem});
            this.puertoCOMToolStripMenuItem.Name = "puertoCOMToolStripMenuItem";
            this.puertoCOMToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.puertoCOMToolStripMenuItem.Text = "Puerto COM";
            // 
            // configuracionToolStripMenuItem
            // 
            this.configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
            this.configuracionToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.configuracionToolStripMenuItem.Text = "Nueva configuracion";
            this.configuracionToolStripMenuItem.Click += new System.EventHandler(this.configuracionToolStripMenuItem_Click);
            // 
            // elegirConfiguracionToolStripMenuItem
            // 
            this.elegirConfiguracionToolStripMenuItem.Name = "elegirConfiguracionToolStripMenuItem";
            this.elegirConfiguracionToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.elegirConfiguracionToolStripMenuItem.Text = "Elegir configuracion";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 406);
            this.Controls.Add(this.scale);
            this.Controls.Add(this.icono_ing);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.posture_group);
            this.Controls.Add(this.group_port_ser);
            this.Controls.Add(this.group_distances);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Medidor de posturas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.group_distances.ResumeLayout(false);
            this.group_distances.PerformLayout();
            this.group_port_ser.ResumeLayout(false);
            this.posture_group.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.semaforo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icono_ing)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lab_Frente;
        private System.Windows.Forms.Label Indc_Frente;
        private System.Windows.Forms.Label Ind_Der;
        private System.Windows.Forms.Label Ind_Izq;
        private System.Windows.Forms.Label Lab_Izq;
        private System.Windows.Forms.Label Lab_Der;
        private System.Windows.Forms.Button btn_serial_start;
        private System.Windows.Forms.Button btn_serial_close;
        private System.Windows.Forms.GroupBox group_distances;
        private System.Windows.Forms.GroupBox group_port_ser;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox posture_group;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox icono_ing;
        private System.Windows.Forms.PictureBox semaforo;
        private System.Windows.Forms.Label scale;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem puertoCOMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elegirConfiguracionToolStripMenuItem;
    }
}

