namespace proyectoads2
{
    partial class Reportes
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.DGVRestantes = new System.Windows.Forms.DataGridView();
            this.DGVInventario = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.BtnExcel = new Bunifu.Framework.UI.BunifuTileButton();
            this.BtnPdf = new Bunifu.Framework.UI.BunifuTileButton();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVRestantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVInventario)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.BtnPdf);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.BtnExcel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(614, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 414);
            this.panel1.TabIndex = 9;
            // 
            // DGVRestantes
            // 
            this.DGVRestantes.AllowUserToAddRows = false;
            this.DGVRestantes.AllowUserToDeleteRows = false;
            this.DGVRestantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVRestantes.Location = new System.Drawing.Point(26, 35);
            this.DGVRestantes.Name = "DGVRestantes";
            this.DGVRestantes.ReadOnly = true;
            this.DGVRestantes.Size = new System.Drawing.Size(250, 155);
            this.DGVRestantes.TabIndex = 10;
            // 
            // DGVInventario
            // 
            this.DGVInventario.AllowUserToAddRows = false;
            this.DGVInventario.AllowUserToDeleteRows = false;
            this.DGVInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVInventario.Location = new System.Drawing.Point(26, 225);
            this.DGVInventario.Name = "DGVInventario";
            this.DGVInventario.ReadOnly = true;
            this.DGVInventario.Size = new System.Drawing.Size(562, 173);
            this.DGVInventario.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(26, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Alimentos restantes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei Light", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(26, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Alimentos restantes a Detalle";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.DGVRestantes);
            this.panel4.Controls.Add(this.DGVInventario);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(614, 414);
            this.panel4.TabIndex = 14;
            // 
            // BtnExcel
            // 
            this.BtnExcel.BackColor = System.Drawing.Color.LimeGreen;
            this.BtnExcel.color = System.Drawing.Color.LimeGreen;
            this.BtnExcel.colorActive = System.Drawing.Color.PaleGreen;
            this.BtnExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.BtnExcel.ForeColor = System.Drawing.Color.Black;
            this.BtnExcel.Image = global::proyectoads2.Properties.Resources.icons8_ms_excel_64;
            this.BtnExcel.ImagePosition = 20;
            this.BtnExcel.ImageZoom = 50;
            this.BtnExcel.LabelPosition = 41;
            this.BtnExcel.LabelText = "Excel";
            this.BtnExcel.Location = new System.Drawing.Point(27, 78);
            this.BtnExcel.Margin = new System.Windows.Forms.Padding(6);
            this.BtnExcel.Name = "BtnExcel";
            this.BtnExcel.Size = new System.Drawing.Size(144, 135);
            this.BtnExcel.TabIndex = 14;
            this.BtnExcel.Click += new System.EventHandler(this.BtnExcel_Click);
            // 
            // BtnPdf
            // 
            this.BtnPdf.BackColor = System.Drawing.Color.Tomato;
            this.BtnPdf.color = System.Drawing.Color.Tomato;
            this.BtnPdf.colorActive = System.Drawing.Color.Coral;
            this.BtnPdf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.BtnPdf.ForeColor = System.Drawing.Color.White;
            this.BtnPdf.Image = global::proyectoads2.Properties.Resources.icons8_pdf_64;
            this.BtnPdf.ImagePosition = 20;
            this.BtnPdf.ImageZoom = 50;
            this.BtnPdf.LabelPosition = 41;
            this.BtnPdf.LabelText = "PDF";
            this.BtnPdf.Location = new System.Drawing.Point(27, 237);
            this.BtnPdf.Margin = new System.Windows.Forms.Padding(6);
            this.BtnPdf.Name = "BtnPdf";
            this.BtnPdf.Size = new System.Drawing.Size(144, 135);
            this.BtnPdf.TabIndex = 15;
            this.BtnPdf.Click += new System.EventHandler(this.BtnPdf_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(53, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 22);
            this.label3.TabIndex = 16;
            this.label3.Text = "Exportar";
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 414);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reportes";
            this.Text = "Reportes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVRestantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVInventario)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DGVRestantes;
        private System.Windows.Forms.DataGridView DGVInventario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuTileButton BtnPdf;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuTileButton BtnExcel;
    }
}