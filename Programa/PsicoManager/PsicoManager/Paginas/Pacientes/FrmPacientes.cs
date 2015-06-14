using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PsicoManager.DB;

namespace PsicoManager
{
    public partial class FrmPacientes : Form
    {
        DB.DBContext db = new DBContext();

        public FrmPacientes()
        {
            InitializeComponent();
        }

        private void FrmPacientes_Load(object sender, EventArgs e)
        {
            CarregaPacientes();

            DataGridViewButtonColumn colAcompanharPaciente = new DataGridViewButtonColumn();
            colAcompanharPaciente.UseColumnTextForButtonValue = true;
            colAcompanharPaciente.Text = "Acompanhar Paciente";
            colAcompanharPaciente.Name = "Acompanhar Paciente";
            colAcompanharPaciente.HeaderText = "";
            gridPacientes.Columns.Add(colAcompanharPaciente);

            DataGridViewButtonColumn col = new DataGridViewButtonColumn();
            col.UseColumnTextForButtonValue = true;
            col.Text = "Editar";
            col.Name = "Editar";
            col.HeaderText = "";
            gridPacientes.Columns.Add(col);

            DataGridViewButtonColumn colExcluir = new DataGridViewButtonColumn();
            colExcluir.UseColumnTextForButtonValue = true;
            colExcluir.Text = "Excluir";
            colExcluir.Name = "Excluir";
            colExcluir.HeaderText = "";
            gridPacientes.Columns.Add(colExcluir);
        }

        private void CarregaPacientes()
        {
            gridPacientes.DataSource = db.Pacientes.Select(x => new { Codigo = x.PacienteId, Nome = x.Nome, Sexo = x.Sexo, DataNasc = x.DataNascimento, DataInclusao = x.DataInclusao, RG = x.RG, CPF = x.CPF }).ToList();

            
        }

        private void lblNovo_Click(object sender, EventArgs e)
        {
            FrmPacientesNovo frmPacientesNovo = new FrmPacientesNovo();

            FormBase.AbrirForm(frmPacientesNovo);
        }

        private void gridPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            var acao = gridPacientes.Columns[e.ColumnIndex].Name;
            int idPaciente = (int)gridPacientes.Rows[e.RowIndex].Cells["Codigo"].Value;

            switch (acao)
            {
                case "Acompanhar Paciente":

                    var frmAcompanhamento = new FrmPacientesAcompanhamento(idPaciente);
                    FormBase.AbrirForm(frmAcompanhamento);

                    break;
                case "Editar":

                    FrmPacientesNovo frm = new FrmPacientesNovo(idPaciente);
                    // button clicked - do some logic
                    FormBase.AbrirForm(frm);

                    break;
                case "Excluir":

                    var confirmResult = MessageBox.Show("Tem certeza de que deseja excluir este registro?",
                                     "Atenção!",
                                     MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        var paciente = db.Pacientes.Single(x => x.PacienteId == idPaciente);
                        db.Pacientes.Remove(paciente);
                        db.SaveChanges();

                        CarregaPacientes();
                    }

                    break;
                default:
                    break;
            }
            
        }
    }
}
