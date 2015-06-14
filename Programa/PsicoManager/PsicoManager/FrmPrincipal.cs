using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PsicoManager
{
    public partial class FrmPrincipal : Form
    {
        FrmHome frmHome;
        FrmPacientes frmPacientes;

        public FrmPrincipal()
        {
            InitializeComponent();

            FormBase.frmPrincipal = this;

            lblNomeUsuario.Text = "Olá, " + FormBase.nomeUsuario + "!";

            if (FormBase.nivelUsuario == 2)
            {
                lblFuncionarios.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frmHome = new FrmHome();
            AbrirFormPrincipal(frmHome);
        }

        public void AbrirFormPrincipal(Form frm)
        {            
            foreach (Control control in pnlPrincipal.Controls)
                pnlPrincipal.Controls.Remove(control);

            frm.TopLevel = false;
            pnlPrincipal.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void lblHome_Click(object sender, EventArgs e)
        {
            frmHome = new FrmHome();
            AbrirFormPrincipal(frmHome);
        }

        private void lblPacientes_Click(object sender, EventArgs e)
        {
            frmPacientes = new FrmPacientes();
            AbrirFormPrincipal(frmPacientes);
        }

        private void lblFuncionarios_Click(object sender, EventArgs e)
        {
            var frm = new FrmFuncionarios();
            AbrirFormPrincipal(frm);
        }

        private void lblSair_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
        }

        private void lblAjuda_Click(object sender, EventArgs e)
        {
            var frm = new FrmAjuda();
            AbrirFormPrincipal(frm);
        }

        private void lblAgenda_Click(object sender, EventArgs e)
        {
            var frm = new FrmAgenda();
            AbrirFormPrincipal(frm);
        }

        private void lblPagamentos_Click(object sender, EventArgs e)
        {
            var frm = new FrmPagamentos();
            AbrirFormPrincipal(frm);
        }
    }
}
