using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PsicoManager
{
    public static class FormBase
    {
        public static FrmPrincipal frmPrincipal;

        public static int nivelUsuario;

        public static string nomeUsuario;

        public static void AbrirForm(Form frm)
        {
            frmPrincipal.AbrirFormPrincipal(frm);
        }
    }
}
