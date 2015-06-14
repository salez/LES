using PsicoManager.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PsicoManager
{
    public partial class FrmPagamentosNovo : Form
    {
        DBContext db = new DBContext();
        int? idCadastro = null;
        int? idAgenda = null;

        public FrmPagamentosNovo(int? idCadastro = null, int? idAgenda = null)
        {
            InitializeComponent();
            this.idCadastro = idCadastro;
            this.idAgenda = idAgenda;
        }

        private void FrmPagamentosNovo_Load(object sender, EventArgs e)
        {
            cboPacientes.DataSource = db.Pacientes.Select(x => new { Id = x.PacienteId, Nome = x.Nome }).ToList();
            cboPacientes.DisplayMember = "Nome";
            cboPacientes.ValueMember = "Id";

            carregaDados();
        }

        private void carregaDados()
        {
            if (!idCadastro.HasValue)
                return;
                
            var pagamento = db.Pagamentos.Single(x => x.PagamentoId == this.idCadastro.Value);

            
            txtValor.Text = pagamento.Valor.ToString();
            txtObservacao.Text = pagamento.Observacao;
            cboPacientes.SelectedValue = pagamento.PacienteId;
            chkPago.Checked = pagamento.Pago;
            dpDataLimitePagamento.Value = (pagamento.DataLimitePagamento < dpDataLimitePagamento.MinDate) ? dpDataLimitePagamento.MinDate : pagamento.DataLimitePagamento;
            dpDataPagamento.Value = (pagamento.DataPagamento < dpDataPagamento.MinDate) ? dpDataPagamento.MinDate : pagamento.DataPagamento;

            
        }
        private void lblVoltar_Click(object sender, EventArgs e)
        {
            FrmPacientes frmPacientes = new FrmPacientes();

            FormBase.AbrirForm(frmPacientes);
        }

        private void lblSalvar_Click(object sender, EventArgs e)
        {
            DB.Pagamento pgto;

            if (!idCadastro.HasValue)
                pgto = new Pagamento();
            else
                pgto = db.Pagamentos.Single(x => x.PagamentoId == this.idCadastro.Value);

            pgto.Pago = chkPago.Checked;
            pgto.Valor = decimal.Parse(txtValor.Text);
            pgto.PacienteId = (int)cboPacientes.SelectedValue;
            pgto.DataPagamento = dpDataPagamento.Value;
            pgto.DataLimitePagamento = dpDataLimitePagamento.Value;

            if (idAgenda != null)
                pgto.AgendaId = idAgenda.Value;

            if (!idCadastro.HasValue)
                db.Pagamentos.Add(pgto);

            db.SaveChanges();

            var frm = new FrmPagamentos();

            FormBase.AbrirForm(frm);
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            txtValor.Text = string.Format(System.Globalization.CultureInfo.GetCultureInfo("pt-BR"), "{0:#,##0.00}", double.Parse(Regex.Replace(txtValor.Text.Replace(".",","), "[^.0-9,]", "")));
        }
    }
}
