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
    public partial class FrmPacientesAcompanhamento : Form
    {
        DBContext db = new DBContext();
        int? idCadastro = null;

        public FrmPacientesAcompanhamento(int? idCadastro = null)
        {
            InitializeComponent();
            this.idCadastro = idCadastro;
        }

        private void FrmPacientesAcompanhamento_Load(object sender, EventArgs e)
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
            txtTel1.Text = paciente.Telefone1;
            txtTel2.Text = paciente.Telefone2;
            txtAnotacoes.Text = paciente.Anotacoes;
            dpDataNasc.Value = (paciente.DataNascimento < dpDataNasc.MinDate)?dpDataNasc.MinDate : paciente.DataNascimento;

            gridProximasConsultas.DataSource = paciente.Agenda.Select(x => new { x.DataConsulta, x.DataInclusao, x.Observacao }).ToList();
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
                return;

            paciente = db.Pacientes.Single(x => x.PacienteId == this.idCadastro.Value);

            paciente.Anotacoes = txtAnotacoes.Text;

            db.SaveChanges();

            FrmPacientes frmPacientes = new FrmPacientes();

            FormBase.AbrirForm(frmPacientes);
        }
    }
}
