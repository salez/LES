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
    public partial class FrmAgenda : Form
    {
        DB.DBContext db = new DBContext();

        public FrmAgenda()
        {
            InitializeComponent();
        }

        private void FrmPacientes_Load(object sender, EventArgs e)
        {
            CarregaDados();

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

        private void CarregaDados()
        {
            gridPacientes.DataSource = db.Agendas.ToList().Select(x => new { Codigo = x.AgendaId, Paciente = x.Paciente.Nome, Data = x.DataConsulta.ToString("dd/MM/yyyy"), Hora = x.DataConsulta.ToString("hh:mm"), Observacao = x.Observacao}).ToList();
        }

        private void lblNovo_Click(object sender, EventArgs e)
        {
            var frm = new FrmAgendaNovo();

            FormBase.AbrirForm(frm);
        }

        private void gridPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            var acao = gridPacientes.Columns[e.ColumnIndex].Name;
            int idAgenda = (int)gridPacientes.Rows[e.RowIndex].Cells["Codigo"].Value;

            switch (acao)
            {
                case "Editar":

                    var frm = new FrmAgendaNovo(idAgenda);
                    // button clicked - do some logic
                    FormBase.AbrirForm(frm);

                    break;
                case "Excluir":

                    var confirmResult = MessageBox.Show("Tem certeza de que deseja excluir este registro?",
                                     "Atenção!",
                                     MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        var agenda = db.Agendas.Single(x => x.AgendaId == idAgenda);
                        db.Agendas.Remove(agenda);
                        db.SaveChanges();

                        CarregaDados();
                    }

                    break;
                default:
                    break;
            }
            
        }
    }
}
