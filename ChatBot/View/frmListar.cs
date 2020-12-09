using ChatBot.Controller;
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
    public partial class frmListar : Form
    {
        public frmListar()
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
    }
}
