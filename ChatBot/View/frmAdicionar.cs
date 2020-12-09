using ChatBot.Controller;
using ChatBot.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatBot.View
{
    public partial class frmAdicionar : Form
    {
        int id = 0;
        Cliente c = new Cliente();
        public frmAdicionar()
        {
            InitializeComponent();
        }

        private void ibtnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text != "Nome" && txtEmail.Text != "Email" && txtCPF.Text != "CPF" && txtTelefone.Text != "Telefone")
            {
                if (txtNome.Text != "" && txtEmail.Text != "" && txtCPF.Text != "" && txtTelefone.Text != "")
                {
                    c.IdCliente = id;
                    c.Nome = txtNome.Text;
                    c.Email = txtEmail.Text;
                    c.CPF = txtCPF.Text;
                    c.Telefone = "+5527" + txtTelefone.Text;

                    using (var context = new BotController())
                    {
                        context.Adicionar(c);
                        MessageBox.Show("Clientes cadastrados com sucesso");
                        ClearDados();
                    }
                }
                else
                {
                    MessageBox.Show("Por favor insira algum dado");
                }
            }
            else
            {
                MessageBox.Show("Por favor insira os seus dados");
            }
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

        private void txtCPF_Enter(object sender, EventArgs e)
        {
            string texto = "CPF";
            TxtEnter(txtCPF, texto);
        }

        private void txtCPF_Leave(object sender, EventArgs e)
        {
            string texto = "CPF";
            TxtLeave(txtCPF, texto);
        }

        private void txtTelefone_Enter(object sender, EventArgs e)
        {
            string texto = "Telefone";
            TxtEnter(txtTelefone, texto);
        }

        private void txtTelefone_Leave(object sender, EventArgs e)
        {
            string texto = "Telefone";
            TxtLeave(txtTelefone, texto);
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
            id = 0;
            txtNome.Text = "";
            txtEmail.Text = "";
            txtCPF.Text = "";
            txtTelefone.Text = "";
        }
    }
}
