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
    public partial class frmExcluir : Form
    {
        int id = 0;
        Cliente c = new Cliente();
        public frmExcluir()
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

        private void ibtnExcluir_Click(object sender, EventArgs e)
        {
            if (txtCPF.Text != "" && txtEmail.Text != "" && txtNome.Text != "" && txtTelefone.Text != "")
            {
                using (var context = new BotController())
                {
                    context.Buscar(id);
                    c.IdCliente = id;
                    c.Nome = txtNome.Text;
                    c.CPF = txtCPF.Text;
                    c.Email = txtEmail.Text;
                    c.Telefone = txtTelefone.Text;
                    context.Remover(c);
                    ClearDados();
                    Dados();
                    MessageBox.Show("Cliente excluído com sucesso");
                }
            }
            else
            {
                MessageBox.Show("Por favor selecione um cliente");
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
            txtCPF.Text = "";
            txtEmail.Text = "";
            txtNome.Text = "";
            txtTelefone.Text = "";
        }

        private void SelecionarDados(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = Convert.ToInt32(dgDados.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtNome.Text = dgDados.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtEmail.Text = dgDados.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCPF.Text = dgDados.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtTelefone.Text = dgDados.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
    }
}
