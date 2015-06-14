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
    public partial class FrmAjudaNovo : Form
    {
        DBContext db = new DBContext();
        int? idCadastro = null;

        public FrmAjudaNovo(int? idCadastro = null)
        {
            InitializeComponent();
            this.idCadastro = idCadastro;
        }

        private void FrmAjudaNovo_Load(object sender, EventArgs e)
        {
            carregaDados();
        }

        private void carregaDados()
        {
            if (!idCadastro.HasValue)
                return;
                
            var ajuda = db.Ajudas.Single(x => x.AjudaId == this.idCadastro.Value);

            txtPergunta.Text = ajuda.Pergunta;
            txtResposta.Text = ajuda.Resposta;
        }
        private void lblVoltar_Click(object sender, EventArgs e)
        {
            var frm = new FrmAjuda();

            FormBase.AbrirForm(frm);
        }

        private void lblSalvar_Click(object sender, EventArgs e)
        {
            DB.Ajuda ajuda;

            if (!idCadastro.HasValue)
                ajuda = new Ajuda();
            else
                ajuda = db.Ajudas.Single(x => x.AjudaId == this.idCadastro.Value);

            ajuda.Pergunta = txtPergunta.Text;
            ajuda.Resposta = txtResposta.Text;

            ajuda.DataInclusao = DateTime.Now;

            if (!idCadastro.HasValue)
                db.Ajudas.Add(ajuda);

            db.SaveChanges();

            var frm = new FrmAjuda();

            FormBase.AbrirForm(frm);
        }
    }
}
