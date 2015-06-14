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
    public partial class FrmAjuda : Form
    {
        DB.DBContext db = new DBContext();

        public FrmAjuda()
        {
            InitializeComponent();
        }

        private void FrmAjuda_Load(object sender, EventArgs e)
        {
            CarregaDados();

        }

        private void AddPergunta(string pergunta, string resposta)
        {
            var x = 0;
            var y = 0;

            if (pnlPerguntas.Controls.Count > 0)
            {
                y = pnlPerguntas.Controls[pnlPerguntas.Controls.Count - 1].Location.Y + 60;
            }

            Label lblPergunta = new Label();
            lblPergunta.Text = pergunta;
            lblPergunta.Width = 900;
            lblPergunta.AutoSize = false;
            lblPergunta.Font = new System.Drawing.Font(FontFamily.GenericSansSerif, 13, FontStyle.Bold);
            lblPergunta.Location = new Point(x, y);
            pnlPerguntas.Controls.Add(lblPergunta);

            y = pnlPerguntas.Controls[pnlPerguntas.Controls.Count - 1].Location.Y + 30;

            Label lblResposta = new Label();
            lblResposta.Text = resposta;
            lblResposta.Width = 900;
            lblResposta.Height = 60;
            lblResposta.AutoSize = false;
            lblResposta.Font = new System.Drawing.Font(FontFamily.GenericSansSerif, 10, FontStyle.Regular);
            lblResposta.Location = new Point(x, y);
            pnlPerguntas.Controls.Add(lblPergunta);
            pnlPerguntas.Controls.Add(lblResposta);
        }

        private void CarregaDados()
        {
            foreach (var ajuda in db.Ajudas)
            {
                AddPergunta(ajuda.Pergunta, ajuda.Resposta);
            }
        }

        private void lblNovo_Click(object sender, EventArgs e)
        {
            var frm = new FrmAjudaNovo();

            FormBase.AbrirForm(frm);
        }
    }
}
