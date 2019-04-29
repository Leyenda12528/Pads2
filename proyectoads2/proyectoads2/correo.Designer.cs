namespace proyectoads2
{
    partial class Correo
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
            this.TxtMjs = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnEntregarI = new Bunifu.Framework.UI.BunifuImageButton();
            this.BtnEntregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtAsunto = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnEntregarI)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtMjs
            // 
            this.TxtMjs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.TxtMjs.Location = new System.Drawing.Point(36, 98);
            this.TxtMjs.Multiline = true;
            this.TxtMjs.Name = "TxtMjs";
            this.TxtMjs.Size = new System.Drawing.Size(516, 230);
            this.TxtMjs.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BtnEntregarI);
            this.panel2.Controls.Add(this.BtnEntregar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 343);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(779, 41);
            this.panel2.TabIndex = 6;
            // 
            // BtnEntregarI
            // 
            this.BtnEntregarI.BackColor = System.Drawing.Color.Transparent;
            this.BtnEntregarI.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnEntregarI.ErrorImage = global::proyectoads2.Properties.Resources.icons8_cerrar_ventana_50;
            this.BtnEntregarI.Image = global::proyectoads2.Properties.Resources.icons8_nuevo_post_64;
            this.BtnEntregarI.ImageActive = null;
            this.BtnEntregarI.Location = new System.Drawing.Point(682, 0);
            this.BtnEntregarI.Name = "BtnEntregarI";
            this.BtnEntregarI.Size = new System.Drawing.Size(97, 41);
            this.BtnEntregarI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnEntregarI.TabIndex = 16;
            this.BtnEntregarI.TabStop = false;
            this.BtnEntregarI.Zoom = 10;
            this.BtnEntregarI.Click += new System.EventHandler(this.BtnEntregarI_Click);
            // 
            // BtnEntregar
            // 
            this.BtnEntregar.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnEntregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEntregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BtnEntregar.Location = new System.Drawing.Point(0, 0);
            this.BtnEntregar.Name = "BtnEntregar";
            this.BtnEntregar.Size = new System.Drawing.Size(676, 41);
            this.BtnEntregar.TabIndex = 5;
            this.BtnEntregar.Text = "Enviar Petición";
            this.BtnEntregar.UseVisualStyleBackColor = true;
            this.BtnEntregar.Click += new System.EventHandler(this.BtnEntregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(32, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mensaje a Enviar ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(32, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Asunto";
            // 
            // TxtAsunto
            // 
            this.TxtAsunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.TxtAsunto.Location = new System.Drawing.Point(36, 32);
            this.TxtAsunto.Name = "TxtAsunto";
            this.TxtAsunto.Size = new System.Drawing.Size(516, 24);
            this.TxtAsunto.TabIndex = 9;
            // 
            // Correo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 384);
            this.Controls.Add(this.TxtAsunto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TxtMjs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Correo";
            this.Text = "correo";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnEntregarI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtMjs;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton BtnEntregarI;
        private System.Windows.Forms.Button BtnEntregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtAsunto;
    }
}