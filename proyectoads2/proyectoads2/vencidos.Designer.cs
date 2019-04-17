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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBorrarI = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBorrarI)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tabla de Alimentos Vencidos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(436, 213);
            this.dataGridView1.TabIndex = 1;
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
            this.panel1.Location = new System.Drawing.Point(304, 12);
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
            // vencidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 310);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "vencidos";
            this.Text = "vencidos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnBorrarI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton btnBorrarI;
    }
}