﻿namespace proyectoads2
{
    partial class Inventario
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
            this.tabDatos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRegistrarI = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnRegistrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabDatos)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegistrarI)).BeginInit();
            this.SuspendLayout();
            // 
            // tabDatos
            // 
            this.tabDatos.AllowUserToAddRows = false;
            this.tabDatos.AllowUserToDeleteRows = false;
            this.tabDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabDatos.Location = new System.Drawing.Point(16, 67);
            this.tabDatos.Name = "tabDatos";
            this.tabDatos.ReadOnly = true;
            this.tabDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabDatos.Size = new System.Drawing.Size(583, 241);
            this.tabDatos.TabIndex = 0;
            this.tabDatos.SelectionChanged += new System.EventHandler(this.tabDatos_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "VISTA INVENTARIOS AL MOMENTO";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 340);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(664, 50);
            this.panel1.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnRegistrarI);
            this.panel2.Controls.Add(this.btnRegistrar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(517, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(147, 50);
            this.panel2.TabIndex = 1;
            // 
            // btnRegistrarI
            // 
            this.btnRegistrarI.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrarI.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRegistrarI.ErrorImage = global::proyectoads2.Properties.Resources.icons8_cerrar_ventana_50;
            this.btnRegistrarI.Image = global::proyectoads2.Properties.Resources.icons8_borrar_40;
            this.btnRegistrarI.ImageActive = null;
            this.btnRegistrarI.Location = new System.Drawing.Point(0, 0);
            this.btnRegistrarI.Name = "btnRegistrarI";
            this.btnRegistrarI.Size = new System.Drawing.Size(37, 50);
            this.btnRegistrarI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRegistrarI.TabIndex = 12;
            this.btnRegistrarI.TabStop = false;
            this.btnRegistrarI.Zoom = 10;
            this.btnRegistrarI.Click += new System.EventHandler(this.btnRegistrarI_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(35, 0);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(112, 50);
            this.btnRegistrar.TabIndex = 1;
            this.btnRegistrar.Text = "Pasar a vencidos";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 390);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inventario";
            this.Text = "inventario";
            ((System.ComponentModel.ISupportInitialize)(this.tabDatos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRegistrarI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tabDatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton btnRegistrarI;
        private System.Windows.Forms.Button btnRegistrar;
    }
}