using proyectoads2.Base;
using proyectoads2.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace proyectoads2
{
    public partial class Correo : Form
    {
        private Help1 h = new Help1();
        private Usuari usuario;

        public Correo()
        {
            InitializeComponent();
        }

        public Correo(Usuari usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }
        private void BtnEntregarI_Click(object sender, EventArgs e)
        {
            BtnEntregar_Click(null, null);
        }

        private void BtnEntregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtAsunto.Text.Trim().Length > 0 && TxtMjs.Text.Trim().Length > 0)
                {
                    MailMessage mjs = new MailMessage();
                    mjs.To.Add(usuario.Correo_destino);
                    mjs.Subject = TxtAsunto.Text;
                    mjs.SubjectEncoding = System.Text.Encoding.UTF8;
                    mjs.Bcc.Add(usuario.Correo);

                    mjs.Body = TxtMjs.Text;
                    mjs.BodyEncoding = System.Text.Encoding.UTF8;

                    mjs.From = new MailAddress(usuario.Correo);
                    SmtpClient cliente = new SmtpClient();
                    cliente.Credentials = new NetworkCredential(usuario.Correo, usuario.Contracorreo);
                    cliente.Port = 587;
                    cliente.EnableSsl = true;
                    cliente.Host = "smtp.gmail.com";
                    cliente.Send(mjs);
                    MessageBox.Show("Correo enviado Correctamente!!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TxtAsunto.Clear();
                    TxtMjs.Clear(); 
                }
                else
                    MessageBox.Show("Campos Vacios, no se puede enviar el correo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
                throw;
            }
        }

        
    }
}
