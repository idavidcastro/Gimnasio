﻿
namespace _Presentación
{
    partial class Asistencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Asistencia));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelInformacion = new System.Windows.Forms.Panel();
            this.logohombre = new System.Windows.Forms.PictureBox();
            this.logomujer = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.lblnombre = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelInformacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logohombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logomujer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(252, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(557, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONTROL DE ACCESO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(337, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(531, 146);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(250, 20);
            this.txtid.TabIndex = 2;
            this.txtid.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(189, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(324, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "NRO.IDENTIFICACION";
            // 
            // panelInformacion
            // 
            this.panelInformacion.BackColor = System.Drawing.Color.DarkBlue;
            this.panelInformacion.Controls.Add(this.logohombre);
            this.panelInformacion.Controls.Add(this.logomujer);
            this.panelInformacion.Controls.Add(this.label6);
            this.panelInformacion.Controls.Add(this.lblfecha);
            this.panelInformacion.Controls.Add(this.lblnombre);
            this.panelInformacion.Controls.Add(this.label7);
            this.panelInformacion.Controls.Add(this.label8);
            this.panelInformacion.Location = new System.Drawing.Point(150, 222);
            this.panelInformacion.Name = "panelInformacion";
            this.panelInformacion.Size = new System.Drawing.Size(770, 354);
            this.panelInformacion.TabIndex = 4;
            this.panelInformacion.Visible = false;
            this.panelInformacion.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // logohombre
            // 
            this.logohombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.logohombre.Image = ((System.Drawing.Image)(resources.GetObject("logohombre.Image")));
            this.logohombre.Location = new System.Drawing.Point(31, 37);
            this.logohombre.Name = "logohombre";
            this.logohombre.Size = new System.Drawing.Size(229, 250);
            this.logohombre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logohombre.TabIndex = 7;
            this.logohombre.TabStop = false;
            // 
            // logomujer
            // 
            this.logomujer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.logomujer.Image = ((System.Drawing.Image)(resources.GetObject("logomujer.Image")));
            this.logomujer.Location = new System.Drawing.Point(31, 37);
            this.logomujer.Name = "logomujer";
            this.logomujer.Size = new System.Drawing.Size(229, 250);
            this.logomujer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logomujer.TabIndex = 8;
            this.logomujer.TabStop = false;
            this.logomujer.Visible = false;
            this.logomujer.Click += new System.EventHandler(this.logomujer_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(378, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(322, 57);
            this.label6.TabIndex = 12;
            this.label6.Text = "BIENVENIDO";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.ForeColor = System.Drawing.SystemColors.Control;
            this.lblfecha.Location = new System.Drawing.Point(378, 276);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(0, 24);
            this.lblfecha.TabIndex = 11;
            this.lblfecha.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.ForeColor = System.Drawing.SystemColors.Control;
            this.lblnombre.Location = new System.Drawing.Point(374, 189);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(0, 24);
            this.lblnombre.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(378, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 24);
            this.label7.TabIndex = 9;
            this.label7.Text = "TIEMPO :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(378, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 24);
            this.label8.TabIndex = 8;
            this.label8.Text = "NOMBRE :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(809, 140);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Asistencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1000, 632);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelInformacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Asistencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONTROL DE ACCESO";
            this.Load += new System.EventHandler(this.Asistencia_Load);
            this.panelInformacion.ResumeLayout(false);
            this.panelInformacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logohombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logomujer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelInformacion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox logohombre;
        private System.Windows.Forms.PictureBox logomujer;
    }
}