namespace Interfaz_Posturas.formularios
{
    partial class Serialform
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.portbox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.baudratebox = new System.Windows.Forms.ComboBox();
            this.saveconfig = new System.Windows.Forms.Button();
            this.deleteconfig = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.portbox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(100, 50);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Puerto";
            // 
            // portbox
            // 
            this.portbox.FormattingEnabled = true;
            this.portbox.Location = new System.Drawing.Point(6, 20);
            this.portbox.Name = "portbox";
            this.portbox.Size = new System.Drawing.Size(88, 21);
            this.portbox.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.baudratebox);
            this.groupBox2.Location = new System.Drawing.Point(118, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(111, 50);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Baudrate";
            // 
            // baudratebox
            // 
            this.baudratebox.FormattingEnabled = true;
            this.baudratebox.Items.AddRange(new object[] {
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.baudratebox.Location = new System.Drawing.Point(7, 19);
            this.baudratebox.Name = "baudratebox";
            this.baudratebox.Size = new System.Drawing.Size(98, 21);
            this.baudratebox.TabIndex = 0;
            // 
            // saveconfig
            // 
            this.saveconfig.Location = new System.Drawing.Point(125, 68);
            this.saveconfig.Name = "saveconfig";
            this.saveconfig.Size = new System.Drawing.Size(75, 23);
            this.saveconfig.TabIndex = 2;
            this.saveconfig.Text = "Guardar";
            this.saveconfig.UseVisualStyleBackColor = true;
            this.saveconfig.Click += new System.EventHandler(this.saveconfig_Click);
            // 
            // deleteconfig
            // 
            this.deleteconfig.Location = new System.Drawing.Point(31, 68);
            this.deleteconfig.Name = "deleteconfig";
            this.deleteconfig.Size = new System.Drawing.Size(75, 23);
            this.deleteconfig.TabIndex = 3;
            this.deleteconfig.Text = "Eliminar";
            this.deleteconfig.UseVisualStyleBackColor = true;
            // 
            // Serialform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 101);
            this.Controls.Add(this.deleteconfig);
            this.Controls.Add(this.saveconfig);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Serialform";
            this.Text = "Configuracion serial";
            this.Load += new System.EventHandler(this.Serialform_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox portbox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox baudratebox;
        private System.Windows.Forms.Button saveconfig;
        private System.Windows.Forms.Button deleteconfig;
    }
}