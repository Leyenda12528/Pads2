namespace proyectoads2
{
    partial class ingreso_pedido
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRegistrarI = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.alimentospanel = new System.Windows.Forms.Panel();
            this.carroz = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cfrijol = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.caceite = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.cleche = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.cbebida = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegistrarI)).BeginInit();
            this.alimentospanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Arroz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "vencimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Frijol";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "cantidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Aceite";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Leche";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 302);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 50);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnRegistrarI);
            this.panel2.Controls.Add(this.btnRegistrar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(542, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(140, 50);
            this.panel2.TabIndex = 1;
            // 
            // btnRegistrarI
            // 
            this.btnRegistrarI.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrarI.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRegistrarI.ErrorImage = global::proyectoads2.Properties.Resources.icons8_cerrar_ventana_50;
            this.btnRegistrarI.Image = global::proyectoads2.Properties.Resources.icons8_más_40;
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
            this.btnRegistrar.Location = new System.Drawing.Point(37, 0);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(103, 50);
            this.btnRegistrar.TabIndex = 1;
            this.btnRegistrar.Text = "Registrar Ingreso";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Bebida";
            // 
            // alimentospanel
            // 
            this.alimentospanel.Controls.Add(this.textBox10);
            this.alimentospanel.Controls.Add(this.cbebida);
            this.alimentospanel.Controls.Add(this.textBox8);
            this.alimentospanel.Controls.Add(this.cleche);
            this.alimentospanel.Controls.Add(this.textBox6);
            this.alimentospanel.Controls.Add(this.caceite);
            this.alimentospanel.Controls.Add(this.textBox4);
            this.alimentospanel.Controls.Add(this.cfrijol);
            this.alimentospanel.Controls.Add(this.textBox2);
            this.alimentospanel.Controls.Add(this.carroz);
            this.alimentospanel.Location = new System.Drawing.Point(64, 49);
            this.alimentospanel.Name = "alimentospanel";
            this.alimentospanel.Size = new System.Drawing.Size(279, 220);
            this.alimentospanel.TabIndex = 22;
            // 
            // carroz
            // 
            this.carroz.Location = new System.Drawing.Point(18, 20);
            this.carroz.Name = "carroz";
            this.carroz.Size = new System.Drawing.Size(100, 20);
            this.carroz.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(168, 20);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 23;
            // 
            // cfrijol
            // 
            this.cfrijol.Location = new System.Drawing.Point(18, 71);
            this.cfrijol.Name = "cfrijol";
            this.cfrijol.Size = new System.Drawing.Size(100, 20);
            this.cfrijol.TabIndex = 23;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(168, 71);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 24;
            // 
            // caceite
            // 
            this.caceite.Location = new System.Drawing.Point(18, 114);
            this.caceite.Name = "caceite";
            this.caceite.Size = new System.Drawing.Size(100, 20);
            this.caceite.TabIndex = 25;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(168, 110);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 26;
            // 
            // cleche
            // 
            this.cleche.Location = new System.Drawing.Point(18, 150);
            this.cleche.Name = "cleche";
            this.cleche.Size = new System.Drawing.Size(100, 20);
            this.cleche.TabIndex = 27;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(168, 150);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 28;
            // 
            // cbebida
            // 
            this.cbebida.Location = new System.Drawing.Point(18, 188);
            this.cbebida.Name = "cbebida";
            this.cbebida.Size = new System.Drawing.Size(100, 20);
            this.cbebida.TabIndex = 29;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(168, 188);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 20);
            this.textBox10.TabIndex = 30;
            // 
            // ingreso_pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 352);
            this.Controls.Add(this.alimentospanel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ingreso_pedido";
            this.Text = "ingreso_pedido";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRegistrarI)).EndInit();
            this.alimentospanel.ResumeLayout(false);
            this.alimentospanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRegistrar;
        private Bunifu.Framework.UI.BunifuImageButton btnRegistrarI;
        private System.Windows.Forms.Panel alimentospanel;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox cbebida;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox cleche;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox caceite;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox cfrijol;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox carroz;
    }
}