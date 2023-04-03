
namespace _Presentación
{
    partial class Consultar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consultar));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.IDENTIFICACION = new System.Windows.Forms.Label();
            this.txtidConsulta = new System.Windows.Forms.TextBox();
            this.pictureBox7777 = new System.Windows.Forms.PictureBox();
            this.dataConsulta = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7777)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(327, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONSULTAR";
            // 
            // IDENTIFICACION
            // 
            this.IDENTIFICACION.AutoSize = true;
            this.IDENTIFICACION.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDENTIFICACION.ForeColor = System.Drawing.SystemColors.Control;
            this.IDENTIFICACION.Location = new System.Drawing.Point(153, 181);
            this.IDENTIFICACION.Name = "IDENTIFICACION";
            this.IDENTIFICACION.Size = new System.Drawing.Size(177, 25);
            this.IDENTIFICACION.TabIndex = 1;
            this.IDENTIFICACION.Text = "IDENTIFICACION";
            // 
            // txtidConsulta
            // 
            this.txtidConsulta.Location = new System.Drawing.Point(348, 181);
            this.txtidConsulta.Name = "txtidConsulta";
            this.txtidConsulta.Size = new System.Drawing.Size(319, 20);
            this.txtidConsulta.TabIndex = 2;
            this.txtidConsulta.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox7777
            // 
            this.pictureBox7777.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7777.Image")));
            this.pictureBox7777.Location = new System.Drawing.Point(692, 164);
            this.pictureBox7777.Name = "pictureBox7777";
            this.pictureBox7777.Size = new System.Drawing.Size(41, 42);
            this.pictureBox7777.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7777.TabIndex = 6;
            this.pictureBox7777.TabStop = false;
            this.pictureBox7777.Click += new System.EventHandler(this.pictureBox7777_Click);
            // 
            // dataConsulta
            // 
            this.dataConsulta.AllowUserToAddRows = false;
            this.dataConsulta.AllowUserToDeleteRows = false;
            this.dataConsulta.AllowUserToOrderColumns = true;
            this.dataConsulta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dataConsulta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataConsulta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataConsulta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataConsulta.EnableHeadersVisualStyles = false;
            this.dataConsulta.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataConsulta.Location = new System.Drawing.Point(26, 258);
            this.dataConsulta.Margin = new System.Windows.Forms.Padding(2);
            this.dataConsulta.Name = "dataConsulta";
            this.dataConsulta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataConsulta.RowHeadersWidth = 51;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            this.dataConsulta.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataConsulta.RowTemplate.Height = 24;
            this.dataConsulta.Size = new System.Drawing.Size(986, 158);
            this.dataConsulta.TabIndex = 7;
            this.dataConsulta.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Historial);
            this.dataConsulta.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dataConsulta_MouseMove);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(776, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 43);
            this.button1.TabIndex = 8;
            this.button1.Text = "VER HISTORIAL";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Snow;
            this.button2.Location = new System.Drawing.Point(906, 438);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 42);
            this.button2.TabIndex = 9;
            this.button2.Text = "ELIMINAR";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Lime;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(648, 438);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 43);
            this.button3.TabIndex = 10;
            this.button3.Text = "NUEVO PAGO";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // Consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1040, 559);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataConsulta);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox7777);
            this.Controls.Add(this.txtidConsulta);
            this.Controls.Add(this.IDENTIFICACION);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Consultar";
            this.Text = "Consultar";
            this.Load += new System.EventHandler(this.Consultar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7777)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label IDENTIFICACION;
        private System.Windows.Forms.TextBox txtidConsulta;
        private System.Windows.Forms.PictureBox pictureBox7777;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.DataGridView dataConsulta;
        private System.Windows.Forms.Button button3;
    }
}