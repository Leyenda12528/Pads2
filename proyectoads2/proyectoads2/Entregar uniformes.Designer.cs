﻿namespace proyectoads2
{
    partial class Entregar_uniformes
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
            this.dtguniformes = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEntregarI = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnEntregar = new System.Windows.Forms.Button();
            this.estudiante = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtguniformes)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEntregarI)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(30, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Estudiante";
            // 
            // dtguniformes
            // 
            this.dtguniformes.AllowUserToAddRows = false;
            this.dtguniformes.AllowUserToDeleteRows = false;
            this.dtguniformes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtguniformes.Location = new System.Drawing.Point(192, 12);
            this.dtguniformes.Name = "dtguniformes";
            this.dtguniformes.ReadOnly = true;
            this.dtguniformes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtguniformes.Size = new System.Drawing.Size(376, 173);
            this.dtguniformes.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 255);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 41);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnEntregarI);
            this.panel2.Controls.Add(this.btnEntregar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(439, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(141, 41);
            this.panel2.TabIndex = 5;
            // 
            // btnEntregarI
            // 
            this.btnEntregarI.BackColor = System.Drawing.Color.Transparent;
            this.btnEntregarI.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEntregarI.ErrorImage = global::proyectoads2.Properties.Resources.icons8_cerrar_ventana_50;
            this.btnEntregarI.Image = global::proyectoads2.Properties.Resources.icons8_dar_50;
            this.btnEntregarI.ImageActive = null;
            this.btnEntregarI.Location = new System.Drawing.Point(0, 0);
            this.btnEntregarI.Name = "btnEntregarI";
            this.btnEntregarI.Size = new System.Drawing.Size(37, 41);
            this.btnEntregarI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEntregarI.TabIndex = 16;
            this.btnEntregarI.TabStop = false;
            this.btnEntregarI.Zoom = 10;
            this.btnEntregarI.Click += new System.EventHandler(this.btnEntregarI_Click);
            // 
            // btnEntregar
            // 
            this.btnEntregar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEntregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnEntregar.Location = new System.Drawing.Point(37, 0);
            this.btnEntregar.Name = "btnEntregar";
            this.btnEntregar.Size = new System.Drawing.Size(104, 41);
            this.btnEntregar.TabIndex = 5;
            this.btnEntregar.Text = "Entregar";
            this.btnEntregar.UseVisualStyleBackColor = true;
            this.btnEntregar.Click += new System.EventHandler(this.btnEntregar_Click);
            // 
            // estudiante
            // 
            this.estudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.estudiante.FormattingEnabled = true;
            this.estudiante.Location = new System.Drawing.Point(34, 105);
            this.estudiante.Name = "estudiante";
            this.estudiante.Size = new System.Drawing.Size(121, 28);
            this.estudiante.TabIndex = 9;
            // 
            // Entregar_uniformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 296);
            this.Controls.Add(this.estudiante);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtguniformes);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Entregar_uniformes";
            this.Text = "Entregar_uniformes";
            ((System.ComponentModel.ISupportInitialize)(this.dtguniformes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnEntregarI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtguniformes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox estudiante;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEntregar;
        private Bunifu.Framework.UI.BunifuImageButton btnEntregarI;
    }
}