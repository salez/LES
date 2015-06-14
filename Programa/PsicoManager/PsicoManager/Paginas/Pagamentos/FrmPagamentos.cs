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
    public partial class FrmPagamentos : Form
    {
        DB.DBContext db = new DBContext();

        public FrmPagamentos()
        {
            InitializeComponent();
        }

        private void FrmPacientes_Load(object sender, EventArgs e)
        {
            if (FormBase.nivelUsuario == 2)
                lblTotal.Visible = false;

            dpDataInicial.Value = DateTime.Now.Date.AddDays(-30);

            CarregaDados();

            DataGridViewButtonColumn colNotaFiscal = new DataGridViewButtonColumn();
            colNotaFiscal.UseColumnTextForButtonValue = true;
            colNotaFiscal.Text = "Recibo";
            colNotaFiscal.Name = "Recibo";
            colNotaFiscal.HeaderText = "";
            gridPagamentos.Columns.Add(colNotaFiscal);

            DataGridViewButtonColumn colRecibo = new DataGridViewButtonColumn();
            colRecibo.UseColumnTextForButtonValue = true;
            colRecibo.Text = "NF";
            colRecibo.Name = "NF";
            colRecibo.HeaderText = "";
            gridPagamentos.Columns.Add(colRecibo);

            DataGridViewButtonColumn col = new DataGridViewButtonColumn();
            col.UseColumnTextForButtonValue = true;
            col.Text = "Editar";
            col.Name = "Editar";
            col.HeaderText = "";
            gridPagamentos.Columns.Add(col);

            DataGridViewButtonColumn colExcluir = new DataGridViewButtonColumn();
            colExcluir.UseColumnTextForButtonValue = true;
            colExcluir.Text = "Excluir";
            colExcluir.Name = "Excluir";
            colExcluir.HeaderText = "";
            gridPagamentos.Columns.Add(colExcluir);

        }

        private void CarregaDados()
        {
            var pagamentos = db.Pagamentos.Where(x => x.DataPagamento >= dpDataInicial.Value && x.DataPagamento <= dpDataFinal.Value);

            gridPagamentos.DataSource = pagamentos.Select(x => new { Codigo = x.PagamentoId, Paciente = x.Paciente.Nome, Valor = x.Valor, Pago = x.Pago, DataPagamento = x.DataPagamento }).ToList()
                .Select(x => new { Codigo = x.Codigo, Paciente = x.Paciente, Valor = x.Valor, Pago = x.Pago, DataPagamento = (x.Pago) ? x.DataPagamento.ToString() : "-" }).ToList();

            if (pagamentos.Count() > 0)
                lblTotal.Text = "Total Recebido: R$" + formataValor(pagamentos.Sum(x => x.Valor));
        }

        private void lblNovo_Click(object sender, EventArgs e)
        {
            var frm = new FrmPagamentosNovo();

            FormBase.AbrirForm(frm);
        }

        private void gridPacientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            var acao = gridPagamentos.Columns[e.ColumnIndex].Name;
            int idPgto = (int)gridPagamentos.Rows[e.RowIndex].Cells["Codigo"].Value;

            switch (acao)
            {
                case "Editar":

                    var frm = new FrmPagamentosNovo(idPgto);
                    // button clicked - do some logic
                    FormBase.AbrirForm(frm);

                    break;
                case "Excluir":

                    var confirmResult = MessageBox.Show("Tem certeza de que deseja excluir este registro?",
                                     "Atenção!",
                                     MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        var pgto = db.Pagamentos.Single(x => x.PagamentoId == idPgto);
                        db.Pagamentos.Remove(pgto);
                        db.SaveChanges();

                        CarregaDados();
                    }

                    break;
                default:
                    break;
            }
            
        }

        private void lblFiltrar_Click(object sender, EventArgs e)
        {
            CarregaDados();
        }

        private string formataValor(decimal valor)
        {
            return string.Format(System.Globalization.CultureInfo.GetCultureInfo("pt-BR"), "{0:#,##0.00}", valor);
        }
    }
}
