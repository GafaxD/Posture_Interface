namespace Interfaz_Posturas.formularios
{
    partial class CameraSetting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DeviceBox = new System.Windows.Forms.ComboBox();
            this.DeviceLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SaveRoute = new System.Windows.Forms.Label();
            this.DeviceButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TestPictureBox = new System.Windows.Forms.PictureBox();
            this.TestButton = new System.Windows.Forms.Button();
            this.RouteTextBox = new System.Windows.Forms.TextBox();
            this.SearchFileButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TestPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DeviceBox
            // 
            this.DeviceBox.FormattingEnabled = true;
            this.DeviceBox.Location = new System.Drawing.Point(82, 19);
            this.DeviceBox.Name = "DeviceBox";
            this.DeviceBox.Size = new System.Drawing.Size(281, 21);
            this.DeviceBox.TabIndex = 0;
            // 
            // DeviceLabel
            // 
            this.DeviceLabel.AutoSize = true;
            this.DeviceLabel.Location = new System.Drawing.Point(18, 22);
            this.DeviceLabel.Name = "DeviceLabel";
            this.DeviceLabel.Size = new System.Drawing.Size(58, 13);
            this.DeviceLabel.TabIndex = 1;
            this.DeviceLabel.Text = "Dispositivo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SearchFileButton);
            this.groupBox1.Controls.Add(this.RouteTextBox);
            this.groupBox1.Controls.Add(this.DeviceBox);
            this.groupBox1.Controls.Add(this.SaveRoute);
            this.groupBox1.Controls.Add(this.DeviceLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 80);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuracion";
            // 
            // SaveRoute
            // 
            this.SaveRoute.AutoSize = true;
            this.SaveRoute.Location = new System.Drawing.Point(29, 50);
            this.SaveRoute.Name = "SaveRoute";
            this.SaveRoute.Size = new System.Drawing.Size(30, 13);
            this.SaveRoute.TabIndex = 1;
            this.SaveRoute.Text = "Ruta";
            // 
            // DeviceButton
            // 
            this.DeviceButton.Location = new System.Drawing.Point(199, 307);
            this.DeviceButton.Name = "DeviceButton";
            this.DeviceButton.Size = new System.Drawing.Size(75, 23);
            this.DeviceButton.TabIndex = 3;
            this.DeviceButton.Text = "Aceptar";
            this.DeviceButton.UseVisualStyleBackColor = true;
            this.DeviceButton.Click += new System.EventHandler(this.DeviceButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TestPictureBox);
            this.groupBox2.Controls.Add(this.TestButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(452, 203);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Camara";
            // 
            // TestPictureBox
            // 
            this.TestPictureBox.Location = new System.Drawing.Point(6, 19);
            this.TestPictureBox.Name = "TestPictureBox";
            this.TestPictureBox.Size = new System.Drawing.Size(440, 148);
            this.TestPictureBox.TabIndex = 0;
            this.TestPictureBox.TabStop = false;
            // 
            // TestButton
            // 
            this.TestButton.Location = new System.Drawing.Point(360, 174);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(75, 23);
            this.TestButton.TabIndex = 3;
            this.TestButton.Text = "Probar";
            this.TestButton.UseVisualStyleBackColor = true;
            this.TestButton.Click += new System.EventHandler(this.TestButton_Click);
            // 
            // RouteTextBox
            // 
            this.RouteTextBox.Location = new System.Drawing.Point(82, 47);
            this.RouteTextBox.Name = "RouteTextBox";
            this.RouteTextBox.Size = new System.Drawing.Size(281, 20);
            this.RouteTextBox.TabIndex = 2;
            // 
            // SearchFileButton
            // 
            this.SearchFileButton.Location = new System.Drawing.Point(369, 45);
            this.SearchFileButton.Name = "SearchFileButton";
            this.SearchFileButton.Size = new System.Drawing.Size(54, 23);
            this.SearchFileButton.TabIndex = 3;
            this.SearchFileButton.Text = "Buscar";
            this.SearchFileButton.UseVisualStyleBackColor = true;
            this.SearchFileButton.Click += new System.EventHandler(this.SearchFileButton_Click);
            // 
            // CameraSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 342);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.DeviceButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "CameraSetting";
            this.Text = "Configuracion de camara";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CameraSetting_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CameraSetting_FormClosed);
            this.Load += new System.EventHandler(this.CameraSetting_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TestPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox DeviceBox;
        private System.Windows.Forms.Label DeviceLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label SaveRoute;
        private System.Windows.Forms.Button DeviceButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox TestPictureBox;
        private System.Windows.Forms.Button TestButton;
        private System.Windows.Forms.Button SearchFileButton;
        private System.Windows.Forms.TextBox RouteTextBox;
    }
}