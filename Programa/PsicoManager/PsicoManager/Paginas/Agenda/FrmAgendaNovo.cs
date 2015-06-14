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
    public partial class FrmAgendaNovo : Form
    {
        DBContext db = new DBContext();
        int? idCadastro = null;

        public FrmAgendaNovo(int? idCadastro = null)
        {
            InitializeComponent();
            this.idCadastro = idCadastro;
        }

        private void FrmAgendaNovo_Load(object sender, EventArgs e)
        {
            cboPaciente.DataSource = db.Pacientes.Select(x => new { Paciente = x.Nome +  " - cód." + x.PacienteId + " - RG." + x.RG + " " + x.Sexo, Id = x.PacienteId }).ToList();
            cboPaciente.ValueMember = "Id";
            cboPaciente.DisplayMember = "Paciente";

            carregaDados();
        }

        private void carregaDados()
        {
            if (!idCadastro.HasValue)
                return;
                
            var agenda = db.Agendas.Single(x => x.AgendaId == this.idCadastro.Value);

            txtObservacao.Text = agenda.Observacao;
            cboPaciente.SelectedValue = agenda.PacienteId;
            dpData.Value = agenda.DataConsulta;
            dpHora.Value = agenda.DataConsulta;
        }
        private void lblVoltar_Click(object sender, EventArgs e)
        {
            var frm = new FrmAgenda();

            FormBase.AbrirForm(frm);
        }

        private void lblSalvar_Click(object sender, EventArgs e)
        {
            DB.Agenda agenda;

            if (!idCadastro.HasValue)
                agenda = new Agenda();
            else
                agenda = db.Agendas.Single(x => x.AgendaId == this.idCadastro.Value);

            agenda.DataConsulta = new DateTime(dpData.Value.Year, dpData.Value.Month, dpData.Value.Day, dpHora.Value.Hour, dpHora.Value.Minute, 0);
            agenda.PacienteId = (int)cboPaciente.SelectedValue;
            agenda.Observacao = txtObservacao.Text;

            if (!idCadastro.HasValue)
                db.Agendas.Add(agenda);

            db.SaveChanges();

            var frm = new FrmAgenda();

            FormBase.AbrirForm(frm);
        }

        private void lblNovoPaciente_Click(object sender, EventArgs e)
        {
            var frm = new FrmPacientesNovo();
            FormBase.AbrirForm(frm);
        }
    }
}
