namespace proyectoads2
{
    partial class vencidos
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
            this.label1 = new System.Windows.Forms.Label();
            this.DGVencidos = new System.Windows.Forms.DataGridView();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBorrarI = new Bunifu.Framework.UI.BunifuImageButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.DGVencidos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBorrarI)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(40, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tabla de Alimentos Vencidos";
            // 
            // DGVencidos
            // 
            this.DGVencidos.AllowUserToAddRows = false;
            this.DGVencidos.AllowUserToDeleteRows = false;
            this.DGVencidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVencidos.Location = new System.Drawing.Point(44, 96);
            this.DGVencidos.Name = "DGVencidos";
            this.DGVencidos.ReadOnly = true;
            this.DGVencidos.Size = new System.Drawing.Size(436, 213);
            this.DGVencidos.TabIndex = 1;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBorrar.Location = new System.Drawing.Point(37, 0);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(125, 51);
            this.btnBorrar.TabIndex = 3;
            this.btnBorrar.Text = "Borrar registro de Vencidos";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBorrarI);
            this.panel1.Controls.Add(this.btnBorrar);
            this.panel1.Location = new System.Drawing.Point(280, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 51);
            this.panel1.TabIndex = 4;
            // 
            // btnBorrarI
            // 
            this.btnBorrarI.BackColor = System.Drawing.Color.Transparent;
            this.btnBorrarI.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBorrarI.ErrorImage = global::proyectoads2.Properties.Resources.icons8_cerrar_ventana_50;
            this.btnBorrarI.Image = global::proyectoads2.Properties.Resources.icons8_borrar_40;
            this.btnBorrarI.ImageActive = null;
            this.btnBorrarI.Location = new System.Drawing.Point(0, 0);
            this.btnBorrarI.Name = "btnBorrarI";
            this.btnBorrarI.Size = new System.Drawing.Size(37, 51);
            this.btnBorrarI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBorrarI.TabIndex = 12;
            this.btnBorrarI.TabStop = false;
            this.btnBorrarI.Zoom = 10;
            this.btnBorrarI.Click += new System.EventHandler(this.btnBorrarI_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(116, 330);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DGVencidos);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(116, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(552, 330);
            this.panel2.TabIndex = 6;
            // 
            // vencidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 330);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "vencidos";
            this.Text = "vencidos";
            ((System.ComponentModel.ISupportInitialize)(this.DGVencidos)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnBorrarI)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGVencidos;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton btnBorrarI;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
    }
}