
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
            this.label1 = new System.Windows.Forms.Label();
            this.IDENTIFICACION = new System.Windows.Forms.Label();
            this.txtidConsulta = new System.Windows.Forms.TextBox();
            this.pictureBox7777 = new System.Windows.Forms.PictureBox();
            this.dataConsulta = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7777)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(436, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONSULTAR";
            // 
            // IDENTIFICACION
            // 
            this.IDENTIFICACION.AutoSize = true;
            this.IDENTIFICACION.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDENTIFICACION.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.IDENTIFICACION.Location = new System.Drawing.Point(204, 223);
            this.IDENTIFICACION.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IDENTIFICACION.Name = "IDENTIFICACION";
            this.IDENTIFICACION.Size = new System.Drawing.Size(237, 31);
            this.IDENTIFICACION.TabIndex = 1;
            this.IDENTIFICACION.Text = "IDENTIFICACION";
            // 
            // txtidConsulta
            // 
            this.txtidConsulta.Location = new System.Drawing.Point(464, 223);
            this.txtidConsulta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtidConsulta.Name = "txtidConsulta";
            this.txtidConsulta.Size = new System.Drawing.Size(424, 22);
            this.txtidConsulta.TabIndex = 2;
            this.txtidConsulta.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox7777
            // 
            this.pictureBox7777.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7777.Image")));
            this.pictureBox7777.Location = new System.Drawing.Point(922, 202);
            this.pictureBox7777.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox7777.Name = "pictureBox7777";
            this.pictureBox7777.Size = new System.Drawing.Size(55, 52);
            this.pictureBox7777.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7777.TabIndex = 6;
            this.pictureBox7777.TabStop = false;
            this.pictureBox7777.Click += new System.EventHandler(this.pictureBox7777_Click);
            // 
            // dataConsulta
            // 
            this.dataConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataConsulta.Location = new System.Drawing.Point(114, 317);
            this.dataConsulta.Name = "dataConsulta";
            this.dataConsulta.RowHeadersWidth = 51;
            this.dataConsulta.RowTemplate.Height = 24;
            this.dataConsulta.Size = new System.Drawing.Size(1122, 195);
            this.dataConsulta.TabIndex = 7;
            // 
            // Consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1388, 688);
            this.Controls.Add(this.dataConsulta);
            this.Controls.Add(this.pictureBox7777);
            this.Controls.Add(this.txtidConsulta);
            this.Controls.Add(this.IDENTIFICACION);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.DataGridView dataConsulta;
    }
}