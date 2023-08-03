namespace _Presentación
{
    partial class Historial
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Historial));
            this.label1 = new System.Windows.Forms.Label();
            this.dataHistorial = new System.Windows.Forms.DataGridView();
            this.logohombre = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataHistorial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logohombre)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 47.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(137, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "HISTORIAL";
            // 
            // dataHistorial
            // 
            this.dataHistorial.AllowUserToAddRows = false;
            this.dataHistorial.AllowUserToDeleteRows = false;
            this.dataHistorial.AllowUserToOrderColumns = true;
            this.dataHistorial.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.dataHistorial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataHistorial.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataHistorial.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataHistorial.EnableHeadersVisualStyles = false;
            this.dataHistorial.GridColor = System.Drawing.Color.SteelBlue;
            this.dataHistorial.Location = new System.Drawing.Point(33, 150);
            this.dataHistorial.Margin = new System.Windows.Forms.Padding(2);
            this.dataHistorial.Name = "dataHistorial";
            this.dataHistorial.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LawnGreen;
            this.dataHistorial.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataHistorial.Size = new System.Drawing.Size(587, 197);
            this.dataHistorial.TabIndex = 7;
            this.dataHistorial.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataHistorial_CellContentClick);
            // 
            // logohombre
            // 
            this.logohombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.logohombre.Image = ((System.Drawing.Image)(resources.GetObject("logohombre.Image")));
            this.logohombre.Location = new System.Drawing.Point(650, 44);
            this.logohombre.Name = "logohombre";
            this.logohombre.Size = new System.Drawing.Size(229, 303);
            this.logohombre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logohombre.TabIndex = 8;
            this.logohombre.TabStop = false;
            // 
            // Historial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(906, 410);
            this.Controls.Add(this.logohombre);
            this.Controls.Add(this.dataHistorial);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Highlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Historial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial";
            this.Load += new System.EventHandler(this.Historial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataHistorial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logohombre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox logohombre;
        public System.Windows.Forms.DataGridView dataHistorial;
    }
}