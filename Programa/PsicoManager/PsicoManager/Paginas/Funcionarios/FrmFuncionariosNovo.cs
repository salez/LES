using PsicoManager.DB;
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
    public partial class FrmFuncionariosNovo : Form
    {
        DBContext db = new DBContext();
        int? idCadastro = null;

        public FrmFuncionariosNovo(int? idCadastro = null)
        {
            InitializeComponent();
            this.idCadastro = idCadastro;
        }

        private void FrmFuncionariosNovo_Load(object sender, EventArgs e)
        {
            cboNivelAcesso.DisplayMember = "Text";
            cboNivelAcesso.ValueMember = "Value";

            var items = new[] { 
                new { Text = "Administrador", Value = "1" }, 
                new { Text = "Funcionário", Value = "2" }
            };

            cboNivelAcesso.DataSource = items;
            cboNivelAcesso.SelectedIndex = 0;

            carregaDados();
        }

        private void carregaDados()
        {
            if (!idCadastro.HasValue)
                return;
                
            var usuario = db.Usuarios.Single(x => x.UsuarioId == this.idCadastro.Value);

            txtNome.Text = usuario.Nome;
            cbSexo.Text = usuario.Sexo;
            txtUF.Text = usuario.UF;
            txtCidade.Text = usuario.Cidade;
            txtBairro.Text = usuario.Bairro;
            txtRG.Text = usuario.RG;
            txtCpf.Text = usuario.CPF;
            txtEndereco.Text = usuario.Endereco;
            txtNumero.Text = usuario.Numero;
            txtComplemento.Text = usuario.Complemento;
            txtObservacao.Text = usuario.Observacao;
            txtTel1.Text = usuario.Telefone1;
            txtTel2.Text = usuario.Telefone2;
            txtEmail.Text = usuario.Email;
            cboNivelAcesso.SelectedValue = usuario.Nivel.ToString();
            txtOcupacao.Text = usuario.Ocupacao;
            dpDataNasc.Value = (usuario.DataNascimento < dpDataNasc.MinDate)?dpDataNasc.MinDate : usuario.DataNascimento;
        }
        private void lblVoltar_Click(object sender, EventArgs e)
        {
            var frm = new FrmFuncionarios();

            FormBase.AbrirForm(frm);
        }

        private void lblSalvar_Click(object sender, EventArgs e)
        {
            DB.Usuario usuario;

            if (!idCadastro.HasValue)
                usuario = new Usuario();
            else
                usuario = db.Usuarios.Single(x => x.UsuarioId == this.idCadastro.Value);

            usuario.Nome = txtNome.Text;
            usuario.Sexo = (cbSexo.Text == "M") ? "M" : "F";
            usuario.UF = txtUF.Text;
            usuario.Cidade = txtCidade.Text;
            usuario.Bairro = txtBairro.Text;
            usuario.RG = txtRG.Text;
            usuario.CPF = txtCpf.Text;
            usuario.Endereco = txtEndereco.Text;
            usuario.Numero = txtNumero.Text;
            usuario.Complemento = txtComplemento.Text;
            usuario.Observacao = txtObservacao.Text;
            usuario.DataNascimento = dpDataNasc.Value;
            usuario.Email = txtEmail.Text;

            if(txtSenha.Text != string.Empty)
                usuario.Senha = txtSenha.Text;

            usuario.Telefone1 = txtTel1.Text;
            usuario.Telefone2 = txtTel2.Text;
            usuario.Ocupacao = txtOcupacao.Text;
            usuario.Nivel = int.Parse(cboNivelAcesso.SelectedValue.ToString());

            usuario.DataInclusao = DateTime.Now;

            if (!idCadastro.HasValue)
                db.Usuarios.Add(usuario);

            db.SaveChanges();

            var frm = new FrmFuncionarios();

            FormBase.AbrirForm(frm);
        }

    }
}
