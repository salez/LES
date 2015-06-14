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
    public partial class FrmPacientesNovo : Form
    {
        DBContext db = new DBContext();
        int? idCadastro = null;

        public FrmPacientesNovo(int? idCadastro = null)
        {
            InitializeComponent();
            this.idCadastro = idCadastro;
        }

        private void FrmPacientesNovo_Load(object sender, EventArgs e)
        {
            carregaDados();
        }

        private void carregaDados()
        {
            if (!idCadastro.HasValue)
                return;
                
            var paciente = db.Pacientes.Single(x => x.PacienteId == this.idCadastro.Value);

            txtNome.Text = paciente.Nome;
            cbSexo.Text = paciente.Sexo;
            txtUF.Text = paciente.UF;
            txtCidade.Text = paciente.Cidade;
            txtBairro.Text = paciente.Bairro;
            txtRG.Text = paciente.RG;
            txtCpf.Text = paciente.CPF;
            txtEndereco.Text = paciente.Endereco;
            txtNumero.Text = paciente.Numero;
            txtComplemento.Text = paciente.Complemento;
            txtObservacao.Text = paciente.Observacao;
            dpDataNasc.Value = (paciente.DataNascimento < dpDataNasc.MinDate)?dpDataNasc.MinDate : paciente.DataNascimento;
            txtTel1.Text = paciente.Telefone1;
            txtTel2.Text = paciente.Telefone2;
            txtOcupacao.Text = paciente.Ocupacao;
        }
        private void lblVoltar_Click(object sender, EventArgs e)
        {
            FrmPacientes frmPacientes = new FrmPacientes();

            FormBase.AbrirForm(frmPacientes);
        }

        private void lblSalvar_Click(object sender, EventArgs e)
        {
            DB.Paciente paciente;

            if (!idCadastro.HasValue)
                paciente = new Paciente();
            else
                paciente = db.Pacientes.Single(x => x.PacienteId == this.idCadastro.Value);

            paciente.Nome = txtNome.Text;
            paciente.Sexo = (cbSexo.Text == "M") ? "M" : "F";
            paciente.UF = txtUF.Text;
            paciente.Cidade = txtCidade.Text;
            paciente.Bairro = txtBairro.Text;
            paciente.RG = txtRG.Text;
            paciente.CPF = txtCpf.Text;
            paciente.Endereco = txtEndereco.Text;
            paciente.Numero = txtNumero.Text;
            paciente.Complemento = txtComplemento.Text;
            paciente.Observacao = txtObservacao.Text;
            paciente.DataNascimento = dpDataNasc.Value;
            paciente.Telefone1 = txtTel1.Text;
            paciente.Telefone2 = txtTel2.Text;
            paciente.Ocupacao = txtOcupacao.Text;

            paciente.DataInclusao = DateTime.Now;

            if (!idCadastro.HasValue)
                db.Pacientes.Add(paciente);

            db.SaveChanges();

            FrmPacientes frmPacientes = new FrmPacientes();

            FormBase.AbrirForm(frmPacientes);
        }
    }
}
