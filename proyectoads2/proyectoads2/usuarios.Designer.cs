namespace proyectoads2
{
    partial class Usuarios
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
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtContra2 = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtCorreo2 = new System.Windows.Forms.TextBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.btnAceptarI = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnl = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptarI)).BeginInit();
            this.pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(33, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario";
            // 
            // txtUser
            // 
            this.txtUser.Enabled = false;
            this.txtUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtUser.Location = new System.Drawing.Point(171, 50);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(250, 26);
            this.txtUser.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(33, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // txtContra
            // 
            this.txtContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtContra.Location = new System.Drawing.Point(171, 106);
            this.txtContra.Name = "txtContra";
            this.txtContra.PasswordChar = '*';
            this.txtContra.Size = new System.Drawing.Size(129, 26);
            this.txtContra.TabIndex = 5;
            this.txtContra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtContra.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(21, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Correo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(15, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Contraseña correo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(15, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Correo destino";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 373);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 54);
            this.panel1.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnAceptarI);
            this.panel3.Controls.Add(this.btnAceptar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(350, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(138, 54);
            this.panel3.TabIndex = 9;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAceptar.Location = new System.Drawing.Point(37, 0);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(101, 54);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // txtContra2
            // 
            this.txtContra2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtContra2.Location = new System.Drawing.Point(159, 80);
            this.txtContra2.Name = "txtContra2";
            this.txtContra2.PasswordChar = '*';
            this.txtContra2.Size = new System.Drawing.Size(129, 26);
            this.txtContra2.TabIndex = 15;
            this.txtContra2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtContra2.UseSystemPasswordChar = true;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCorreo.Location = new System.Drawing.Point(159, 25);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(250, 26);
            this.txtCorreo.TabIndex = 16;
            // 
            // txtCorreo2
            // 
            this.txtCorreo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCorreo2.Location = new System.Drawing.Point(159, 128);
            this.txtCorreo2.Name = "txtCorreo2";
            this.txtCorreo2.Size = new System.Drawing.Size(250, 26);
            this.txtCorreo2.TabIndex = 17;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCargo.Location = new System.Drawing.Point(167, 9);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(52, 20);
            this.lblCargo.TabIndex = 18;
            this.lblCargo.Text = "Cargo";
            // 
            // btnAceptarI
            // 
            this.btnAceptarI.BackColor = System.Drawing.Color.Transparent;
            this.btnAceptarI.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAceptarI.ErrorImage = global::proyectoads2.Properties.Resources.icons8_cerrar_ventana_50;
            this.btnAceptarI.Image = global::proyectoads2.Properties.Resources.icons8_más_40;
            this.btnAceptarI.ImageActive = null;
            this.btnAceptarI.Location = new System.Drawing.Point(0, 0);
            this.btnAceptarI.Name = "btnAceptarI";
            this.btnAceptarI.Size = new System.Drawing.Size(37, 54);
            this.btnAceptarI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAceptarI.TabIndex = 14;
            this.btnAceptarI.TabStop = false;
            this.btnAceptarI.Zoom = 10;
            this.btnAceptarI.Click += new System.EventHandler(this.BtnAceptarI_Click);
            // 
            // pnl
            // 
            this.pnl.Controls.Add(this.label5);
            this.pnl.Controls.Add(this.label6);
            this.pnl.Controls.Add(this.txtCorreo2);
            this.pnl.Controls.Add(this.label7);
            this.pnl.Controls.Add(this.txtCorreo);
            this.pnl.Controls.Add(this.txtContra2);
            this.pnl.Location = new System.Drawing.Point(12, 138);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(432, 204);
            this.pnl.TabIndex = 19;
            // 
            // usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 427);
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "usuarios";
            this.Text = "usuarios";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptarI)).EndInit();
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtContra2;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtCorreo2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAceptar;
        private Bunifu.Framework.UI.BunifuImageButton btnAceptarI;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Panel pnl;
    }
}