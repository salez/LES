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
    public partial class FrmLogin : Form
    {
        DB.DBContext db = new DB.DBContext();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void lblHome_Click(object sender, EventArgs e)
        {

        }

        private void lblEntrar_Click(object sender, EventArgs e)
        {
            var email = txtEmail.Text;
            var senha = txtSenha.Text;


            var usuario = db.Usuarios.FirstOrDefault(u => u.Email == email && u.Senha == senha);

            if (usuario == null)
            {
                MessageBox.Show("Usuário Inválido");
                
                return;
            }

            FormBase.nivelUsuario = usuario.Nivel;
            FormBase.nomeUsuario = usuario.Nome;

            FrmPrincipal frmPrincipal = new FrmPrincipal();

            frmPrincipal.Show();
            this.Hide();
        }
    }
}
