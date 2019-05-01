namespace proyectoads2
{
    partial class Ingresar_uniforme
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
            this.mostrarunif = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEntregarI = new Bunifu.Framework.UI.BunifuImageButton();
            this.agregar = new System.Windows.Forms.Button();
            this.estudiante = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarunif)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEntregarI)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Estudiante";
            // 
            // mostrarunif
            // 
            this.mostrarunif.AllowUserToAddRows = false;
            this.mostrarunif.AllowUserToDeleteRows = false;
            this.mostrarunif.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mostrarunif.Location = new System.Drawing.Point(179, 27);
            this.mostrarunif.Name = "mostrarunif";
            this.mostrarunif.ReadOnly = true;
            this.mostrarunif.Size = new System.Drawing.Size(304, 190);
            this.mostrarunif.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 260);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 44);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnEntregarI);
            this.panel2.Controls.Add(this.agregar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(357, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(156, 44);
            this.panel2.TabIndex = 6;
            // 
            // btnEntregarI
            // 
            this.btnEntregarI.BackColor = System.Drawing.Color.Transparent;
            this.btnEntregarI.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEntregarI.ErrorImage = global::proyectoads2.Properties.Resources.icons8_cerrar_ventana_50;
            this.btnEntregarI.Image = global::proyectoads2.Properties.Resources.icons8_más_40;
            this.btnEntregarI.ImageActive = null;
            this.btnEntregarI.Location = new System.Drawing.Point(0, 0);
            this.btnEntregarI.Name = "btnEntregarI";
            this.btnEntregarI.Size = new System.Drawing.Size(37, 44);
            this.btnEntregarI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEntregarI.TabIndex = 17;
            this.btnEntregarI.TabStop = false;
            this.btnEntregarI.Zoom = 10;
            // 
            // agregar
            // 
            this.agregar.Dock = System.Windows.Forms.DockStyle.Right;
            this.agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.agregar.Location = new System.Drawing.Point(38, 0);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(118, 44);
            this.agregar.TabIndex = 6;
            this.agregar.Text = "Agregar Paquete";
            this.agregar.UseVisualStyleBackColor = true;
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // estudiante
            // 
            this.estudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.estudiante.FormattingEnabled = true;
            this.estudiante.Location = new System.Drawing.Point(12, 69);
            this.estudiante.Name = "estudiante";
            this.estudiante.Size = new System.Drawing.Size(121, 28);
            this.estudiante.TabIndex = 11;
            // 
            // Ingresar_uniforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 304);
            this.Controls.Add(this.estudiante);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mostrarunif);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ingresar_uniforme";
            this.Text = "Ingresar_uniforme";
            ((System.ComponentModel.ISupportInitialize)(this.mostrarunif)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnEntregarI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView mostrarunif;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox estudiante;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button agregar;
        private Bunifu.Framework.UI.BunifuImageButton btnEntregarI;
    }
}