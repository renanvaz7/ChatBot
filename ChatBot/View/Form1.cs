using ChatBot.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatBot
{    /*static TelegramBotClient = new TelegramBotClient("1414629095:AAGeXuYyVJLknzAzC0YBtn4ssMLNBiWPS7w");*/
    //int api_id = 1414629095;
    //string api_hash = "AAGeXuYyVJLknzAzC0YBtn4ssMLNBiWPS7w";
    //string hash;

    public partial class frmPrincipal : Form
    {
        private Form currentChildForm;
        
        private void ArrastarFormulario(object sender, MouseEventArgs e)
        {
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwn, int wMsg, int wParam, int lParam);

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void ibtnMensagem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmEnviarMensagem());
        }

        private void ibtnAdicionar_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmAdicionar());
        }

        private void ibtnEditar_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmEditar());
        }

        private void ibtnListar_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmListar());
        }

        private void ibtnExcluir_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmExcluir());
        }

        private void ibtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            pnlConteudo.Controls.Add(childForm);
            pnlConteudo.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }        
    }
}
