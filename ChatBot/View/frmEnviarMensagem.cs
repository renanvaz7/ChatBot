using ChatBot.Controller;
using ChatBot.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telegram.Bot;
using Telegram.Bot.Args;

namespace ChatBot.View
{
    public partial class frmEnviarMensagem : Form
    {
        int id = 0;
        Cliente c = new Cliente();

        public frmEnviarMensagem()
        {
            InitializeComponent();
            Dados();
        }      

        private void Dados()
        {
            using (var context = new BotController())
            {
                var clientes = context.AllClientes();
                dgDados.DataSource = clientes;
            }
        }

        private void ibtnEnviar_Click(object sender, EventArgs e)
        {
            string destinatario = txtEmail.Text;
            string assunto = txtAssunto.Text;
            string corpo = "Olá " + txtNome.Text + ", " +  txtMensagem.Text;
            EnviaEmail(destinatario, assunto, corpo);
            MessageBox.Show("Email enviado com sucesso");
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            string texto = "Email";
            TxtEnter(txtEmail, texto);
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            string texto = "Email";
            TxtLeave(txtEmail, texto);
        }

        private void txtNome_Enter(object sender, EventArgs e)
        {
            string texto = "Nome";
            TxtEnter(txtNome, texto);
        }

        private void txtNome_Leave(object sender, EventArgs e)
        {
            string texto = "Nome";
            TxtLeave(txtNome, texto);
        }

        private void txtAssunto_Enter(object sender, EventArgs e)
        {
            string texto = "Assunto";
            TxtEnter(txtAssunto, texto);
        }

        private void ibtnEnviar_Leave(object sender, EventArgs e)
        {
            string texto = "Assunto";
            TxtLeave(txtAssunto, texto);
        }

        private void txtMensagem_Enter(object sender, EventArgs e)
        {
            string texto = "Mensagem";
            TxtEnter(txtMensagem, texto);
        }

        private void txtMensagem_Leave(object sender, EventArgs e)
        {
            string texto = "Mensagem";
            TxtLeave(txtMensagem, texto);
        }

        private void TxtEnter(TextBox txtTexto, string texto)
        {
            if (txtTexto.Text == texto)
            {
                txtTexto.Text = "";
            }
            else if (txtTexto.Text == "")
            {
                txtTexto.Text = texto;
            }
        }

        private void TxtLeave(TextBox txtTexto, string texto)
        {
            if (txtTexto.Text == "")
            {
                txtTexto.Text = texto;
            }
            else if (txtTexto.Text == texto)
            {
                txtTexto.Text = "";
            }
        }

        private void ClearDados()
        {
            txtMensagem.Text = "";
            txtNome.Text = "";
            txtEmail.Text = "";
        }

        private void SelecionarDados(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = Convert.ToInt32(dgDados.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtNome.Text = dgDados.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtEmail.Text = dgDados.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void EnviaEmail(string Destinatario, string Assunto, string Corpo)
        {
            SmtpClient client = new SmtpClient("smtp.live.com");  

            client.Port = 587;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            System.Net.NetworkCredential credentials =
                new System.Net.NetworkCredential("renan-silva-vaz@hotmail.com", "renanvaz2018");
            client.EnableSsl = true;
            client.Credentials = credentials;

            try
            {
                var mail = new MailMessage("renan-silva-vaz@hotmail.com", Destinatario);
                mail.Subject = Assunto;
                mail.Body = Corpo;
                client.Send(mail);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }        
    }
}
