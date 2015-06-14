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
    public partial class FrmFuncionarios : Form
    {
        DB.DBContext db = new DBContext();

        public FrmFuncionarios()
        {
            InitializeComponent();
        }

        private void FrmFuncionarios_Load(object sender, EventArgs e)
        {
            CarregaDados();

            DataGridViewButtonColumn col = new DataGridViewButtonColumn();
            col.UseColumnTextForButtonValue = true;
            col.Text = "Editar";
            col.Name = "Editar";
            col.HeaderText = "";
            gridFuncionarios.Columns.Add(col);

            DataGridViewButtonColumn colExcluir = new DataGridViewButtonColumn();
            colExcluir.UseColumnTextForButtonValue = true;
            colExcluir.Text = "Excluir";
            colExcluir.Name = "Excluir";
            colExcluir.HeaderText = "";
            gridFuncionarios.Columns.Add(colExcluir);
        }

        private void CarregaDados()
        {
            gridFuncionarios.DataSource = db.Usuarios.Select(x => new {Codigo = x.UsuarioId,x.Nome,x.Email,x.Nivel,x.DataInclusao,x.DataAlteracao}).ToList();
        }

        private void lblNovo_Click(object sender, EventArgs e)
        {
            var frm = new FrmFuncionariosNovo();

            FormBase.AbrirForm(frm);
        }

        private void gridPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            var acao = gridFuncionarios.Columns[e.ColumnIndex].Name;
            int idFuncionario = (int)gridFuncionarios.Rows[e.RowIndex].Cells["Codigo"].Value;

            switch (acao)
            {
                case "Editar":

                    var frm = new FrmFuncionariosNovo(idFuncionario);
                    // button clicked - do some logic
                    FormBase.AbrirForm(frm);

                    break;
                case "Excluir":

                    var confirmResult = MessageBox.Show("Tem certeza de que deseja excluir este registro?",
                                     "Atenção!",
                                     MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        var paciente = db.Pacientes.Single(x => x.PacienteId == idFuncionario);
                        db.Pacientes.Remove(paciente);
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
