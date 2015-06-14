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
    public partial class FrmHome : Form
    {
        DB.DBContext db = new DB.DBContext();
        public FrmHome()
        {
            InitializeComponent();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {
            CarregaDados();
        }

        private void CarregaDados()
        {
            gridConsultas.DataSource = db.Agendas.Where(x => x.DataConsulta == DateTime.Today).OrderBy(x => x.DataConsulta).ToList().Select(x => new { Codigo = x.AgendaId, Paciente = x.Paciente.Nome, Data = x.DataConsulta.ToString("dd/MM/yyyy"), Hora = x.DataConsulta.ToString("hh:mm"), Observacao = x.Observacao, Presente = x.Compareceu }).ToList();
        }
    }
}
