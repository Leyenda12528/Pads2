namespace proyectoads2
{
    partial class Opcuser
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
            this.PnlContenedor = new System.Windows.Forms.Panel();
            this.btnSecre = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnPerfil = new Bunifu.Framework.UI.BunifuTileButton();
            this.PnlContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlContenedor
            // 
            this.PnlContenedor.Controls.Add(this.btnSecre);
            this.PnlContenedor.Controls.Add(this.btnPerfil);
            this.PnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlContenedor.Location = new System.Drawing.Point(0, 0);
            this.PnlContenedor.Name = "PnlContenedor";
            this.PnlContenedor.Size = new System.Drawing.Size(611, 338);
            this.PnlContenedor.TabIndex = 0;
            // 
            // btnSecre
            // 
            this.btnSecre.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnSecre.color = System.Drawing.Color.DarkSalmon;
            this.btnSecre.colorActive = System.Drawing.Color.OrangeRed;
            this.btnSecre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSecre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnSecre.ForeColor = System.Drawing.Color.White;
            this.btnSecre.Image = global::proyectoads2.Properties.Resources.icons8_asistente_64;
            this.btnSecre.ImagePosition = 20;
            this.btnSecre.ImageZoom = 50;
            this.btnSecre.LabelPosition = 41;
            this.btnSecre.LabelText = "Secretaria";
            this.btnSecre.Location = new System.Drawing.Point(354, 95);
            this.btnSecre.Margin = new System.Windows.Forms.Padding(6);
            this.btnSecre.Name = "btnSecre";
            this.btnSecre.Size = new System.Drawing.Size(128, 129);
            this.btnSecre.TabIndex = 2;
            this.btnSecre.Click += new System.EventHandler(this.BtnSecre_Click);
            // 
            // btnPerfil
            // 
            this.btnPerfil.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnPerfil.color = System.Drawing.Color.LightSeaGreen;
            this.btnPerfil.colorActive = System.Drawing.Color.Teal;
            this.btnPerfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnPerfil.ForeColor = System.Drawing.Color.White;
            this.btnPerfil.Image = global::proyectoads2.Properties.Resources.icons8_editar_propiedad_64;
            this.btnPerfil.ImagePosition = 20;
            this.btnPerfil.ImageZoom = 50;
            this.btnPerfil.LabelPosition = 41;
            this.btnPerfil.LabelText = "Mi perfil";
            this.btnPerfil.Location = new System.Drawing.Point(129, 95);
            this.btnPerfil.Margin = new System.Windows.Forms.Padding(6);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(128, 129);
            this.btnPerfil.TabIndex = 1;
            this.btnPerfil.Click += new System.EventHandler(this.BtnPerfil_Click);
            // 
            // Opcuser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 338);
            this.Controls.Add(this.PnlContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Opcuser";
            this.Text = "Opcuser";
            this.PnlContenedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlContenedor;
        private Bunifu.Framework.UI.BunifuTileButton btnSecre;
        private Bunifu.Framework.UI.BunifuTileButton btnPerfil;
    }
}