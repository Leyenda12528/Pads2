namespace proyectoads2
{
    partial class ingresaralumno
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnIngresarI = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBajaI = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnBaja = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnIngresarI)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBajaI)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox1.Location = new System.Drawing.Point(12, 59);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id Alumno";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox2.Location = new System.Drawing.Point(12, 128);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(166, 26);
            this.textBox2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre Alumno";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(235, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(303, 164);
            this.dataGridView1.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 235);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 43);
            this.panel1.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnIngresarI);
            this.panel3.Controls.Add(this.btnIngresar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(282, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(131, 43);
            this.panel3.TabIndex = 8;
            // 
            // btnIngresarI
            // 
            this.btnIngresarI.BackColor = System.Drawing.Color.Transparent;
            this.btnIngresarI.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnIngresarI.ErrorImage = global::proyectoads2.Properties.Resources.icons8_cerrar_ventana_50;
            this.btnIngresarI.Image = global::proyectoads2.Properties.Resources.icons8_más_40;
            this.btnIngresarI.ImageActive = null;
            this.btnIngresarI.Location = new System.Drawing.Point(0, 0);
            this.btnIngresarI.Name = "btnIngresarI";
            this.btnIngresarI.Size = new System.Drawing.Size(37, 43);
            this.btnIngresarI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnIngresarI.TabIndex = 14;
            this.btnIngresarI.TabStop = false;
            this.btnIngresarI.Zoom = 10;
            this.btnIngresarI.Click += new System.EventHandler(this.btnIngresarI_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnIngresar.Location = new System.Drawing.Point(38, 0);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(93, 43);
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnBajaI);
            this.panel2.Controls.Add(this.btnBaja);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(413, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(137, 43);
            this.panel2.TabIndex = 7;
            // 
            // btnBajaI
            // 
            this.btnBajaI.BackColor = System.Drawing.Color.Transparent;
            this.btnBajaI.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBajaI.ErrorImage = global::proyectoads2.Properties.Resources.icons8_cerrar_ventana_50;
            this.btnBajaI.Image = global::proyectoads2.Properties.Resources.icons8_cancelar_40;
            this.btnBajaI.ImageActive = null;
            this.btnBajaI.Location = new System.Drawing.Point(0, 0);
            this.btnBajaI.Name = "btnBajaI";
            this.btnBajaI.Size = new System.Drawing.Size(37, 43);
            this.btnBajaI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnBajaI.TabIndex = 15;
            this.btnBajaI.TabStop = false;
            this.btnBajaI.Zoom = 10;
            this.btnBajaI.Click += new System.EventHandler(this.btnBajaI_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnBaja.Location = new System.Drawing.Point(39, 0);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(98, 43);
            this.btnBaja.TabIndex = 7;
            this.btnBaja.Text = "Dar de baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // ingresaralumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 278);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ingresaralumno";
            this.Text = "ingresaralumno";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnIngresarI)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnBajaI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnBaja;
        private Bunifu.Framework.UI.BunifuImageButton btnIngresarI;
        private Bunifu.Framework.UI.BunifuImageButton btnBajaI;
    }
}