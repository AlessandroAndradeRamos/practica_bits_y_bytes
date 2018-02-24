namespace Práctica_Bits_y_Bytes
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProcess = new System.Windows.Forms.Button();
            this.lblTwo = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.btnDateFixer = new System.Windows.Forms.Button();
            this.lblDateShow = new System.Windows.Forms.Label();
            this.lblShowFixedDate = new System.Windows.Forms.Label();
            this.istRosaDeLosVientos = new System.Windows.Forms.ImageList(this.components);
            this.ptbRosaDeLosVientos = new System.Windows.Forms.PictureBox();
            this.ptbNivel = new System.Windows.Forms.PictureBox();
            this.ptbSensorUno = new System.Windows.Forms.PictureBox();
            this.ptbSensorDos = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.istSensores = new System.Windows.Forms.ImageList(this.components);
            this.istNivel = new System.Windows.Forms.ImageList(this.components);
            this.istSensoresCheck = new System.Windows.Forms.ImageList(this.components);
            this.lblMostrarFecha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbRosaDeLosVientos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNivel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSensorUno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSensorDos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEntrada
            // 
            this.txtEntrada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEntrada.Location = new System.Drawing.Point(1, 33);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(164, 20);
            this.txtEntrada.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Entrada";
            // 
            // btnProcess
            // 
            this.btnProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcess.Location = new System.Drawing.Point(171, 29);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(91, 28);
            this.btnProcess.TabIndex = 2;
            this.btnProcess.Text = "Procesar";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // lblTwo
            // 
            this.lblTwo.AutoSize = true;
            this.lblTwo.Location = new System.Drawing.Point(54, 132);
            this.lblTwo.Name = "lblTwo";
            this.lblTwo.Size = new System.Drawing.Size(59, 21);
            this.lblTwo.TabIndex = 4;
            this.lblTwo.Text = "Fecha";
            // 
            // txtDate
            // 
            this.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDate.Location = new System.Drawing.Point(1, 156);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(164, 20);
            this.txtDate.TabIndex = 3;
            // 
            // btnDateFixer
            // 
            this.btnDateFixer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDateFixer.Location = new System.Drawing.Point(171, 152);
            this.btnDateFixer.Name = "btnDateFixer";
            this.btnDateFixer.Size = new System.Drawing.Size(91, 28);
            this.btnDateFixer.TabIndex = 5;
            this.btnDateFixer.Text = "Ajustar";
            this.btnDateFixer.UseVisualStyleBackColor = true;
            this.btnDateFixer.Click += new System.EventHandler(this.btnDateFixer_Click);
            // 
            // lblDateShow
            // 
            this.lblDateShow.AutoSize = true;
            this.lblDateShow.Location = new System.Drawing.Point(12, 84);
            this.lblDateShow.Name = "lblDateShow";
            this.lblDateShow.Size = new System.Drawing.Size(123, 21);
            this.lblDateShow.TabIndex = 6;
            this.lblDateShow.Text = "FechaLectura:";
            // 
            // lblShowFixedDate
            // 
            this.lblShowFixedDate.AutoSize = true;
            this.lblShowFixedDate.Location = new System.Drawing.Point(12, 206);
            this.lblShowFixedDate.Name = "lblShowFixedDate";
            this.lblShowFixedDate.Size = new System.Drawing.Size(15, 21);
            this.lblShowFixedDate.TabIndex = 7;
            this.lblShowFixedDate.Text = "-";
            // 
            // istRosaDeLosVientos
            // 
            this.istRosaDeLosVientos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("istRosaDeLosVientos.ImageStream")));
            this.istRosaDeLosVientos.TransparentColor = System.Drawing.Color.Transparent;
            this.istRosaDeLosVientos.Images.SetKeyName(0, "5.jpg");
            this.istRosaDeLosVientos.Images.SetKeyName(1, "6.jpg");
            this.istRosaDeLosVientos.Images.SetKeyName(2, "13.jpg");
            this.istRosaDeLosVientos.Images.SetKeyName(3, "7.jpg");
            this.istRosaDeLosVientos.Images.SetKeyName(4, "11.jpg");
            this.istRosaDeLosVientos.Images.SetKeyName(5, "10.jpg");
            this.istRosaDeLosVientos.Images.SetKeyName(6, "8.jpg");
            this.istRosaDeLosVientos.Images.SetKeyName(7, "12.jpg");
            // 
            // ptbRosaDeLosVientos
            // 
            this.ptbRosaDeLosVientos.Location = new System.Drawing.Point(314, 29);
            this.ptbRosaDeLosVientos.Name = "ptbRosaDeLosVientos";
            this.ptbRosaDeLosVientos.Size = new System.Drawing.Size(103, 94);
            this.ptbRosaDeLosVientos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbRosaDeLosVientos.TabIndex = 8;
            this.ptbRosaDeLosVientos.TabStop = false;
            // 
            // ptbNivel
            // 
            this.ptbNivel.Location = new System.Drawing.Point(432, 29);
            this.ptbNivel.Name = "ptbNivel";
            this.ptbNivel.Size = new System.Drawing.Size(103, 94);
            this.ptbNivel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbNivel.TabIndex = 9;
            this.ptbNivel.TabStop = false;
            // 
            // ptbSensorUno
            // 
            this.ptbSensorUno.Location = new System.Drawing.Point(314, 152);
            this.ptbSensorUno.Name = "ptbSensorUno";
            this.ptbSensorUno.Size = new System.Drawing.Size(103, 94);
            this.ptbSensorUno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbSensorUno.TabIndex = 10;
            this.ptbSensorUno.TabStop = false;
            // 
            // ptbSensorDos
            // 
            this.ptbSensorDos.Location = new System.Drawing.Point(432, 152);
            this.ptbSensorDos.Name = "ptbSensorDos";
            this.ptbSensorDos.Size = new System.Drawing.Size(103, 94);
            this.ptbSensorDos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbSensorDos.TabIndex = 11;
            this.ptbSensorDos.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "Dirección";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(459, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nivel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(388, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "Sensores";
            // 
            // istSensores
            // 
            this.istSensores.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("istSensores.ImageStream")));
            this.istSensores.TransparentColor = System.Drawing.Color.Transparent;
            this.istSensores.Images.SetKeyName(0, "14.jpg");
            this.istSensores.Images.SetKeyName(1, "15.jpg");
            // 
            // istNivel
            // 
            this.istNivel.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("istNivel.ImageStream")));
            this.istNivel.TransparentColor = System.Drawing.Color.Transparent;
            this.istNivel.Images.SetKeyName(0, "3.jpg");
            this.istNivel.Images.SetKeyName(1, "1.jpg");
            this.istNivel.Images.SetKeyName(2, "2.jpg");
            this.istNivel.Images.SetKeyName(3, "4.jpg");
            // 
            // istSensoresCheck
            // 
            this.istSensoresCheck.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("istSensoresCheck.ImageStream")));
            this.istSensoresCheck.TransparentColor = System.Drawing.Color.Transparent;
            this.istSensoresCheck.Images.SetKeyName(0, "16.jpg");
            this.istSensoresCheck.Images.SetKeyName(1, "17.jpg");
            // 
            // lblMostrarFecha
            // 
            this.lblMostrarFecha.AutoSize = true;
            this.lblMostrarFecha.Location = new System.Drawing.Point(139, 84);
            this.lblMostrarFecha.Name = "lblMostrarFecha";
            this.lblMostrarFecha.Size = new System.Drawing.Size(15, 21);
            this.lblMostrarFecha.TabIndex = 15;
            this.lblMostrarFecha.Text = "-";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 293);
            this.Controls.Add(this.lblMostrarFecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ptbSensorDos);
            this.Controls.Add(this.ptbSensorUno);
            this.Controls.Add(this.ptbNivel);
            this.Controls.Add(this.ptbRosaDeLosVientos);
            this.Controls.Add(this.lblShowFixedDate);
            this.Controls.Add(this.lblDateShow);
            this.Controls.Add(this.btnDateFixer);
            this.Controls.Add(this.lblTwo);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEntrada);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmMain";
            this.Text = "Bits y Bytes";
            ((System.ComponentModel.ISupportInitialize)(this.ptbRosaDeLosVientos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNivel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSensorUno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSensorDos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Label lblTwo;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Button btnDateFixer;
        private System.Windows.Forms.Label lblDateShow;
        private System.Windows.Forms.Label lblShowFixedDate;
        private System.Windows.Forms.ImageList istRosaDeLosVientos;
        private System.Windows.Forms.PictureBox ptbRosaDeLosVientos;
        private System.Windows.Forms.PictureBox ptbNivel;
        private System.Windows.Forms.PictureBox ptbSensorUno;
        private System.Windows.Forms.PictureBox ptbSensorDos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ImageList istSensores;
        private System.Windows.Forms.ImageList istNivel;
        private System.Windows.Forms.ImageList istSensoresCheck;
        private System.Windows.Forms.Label lblMostrarFecha;
    }
}

