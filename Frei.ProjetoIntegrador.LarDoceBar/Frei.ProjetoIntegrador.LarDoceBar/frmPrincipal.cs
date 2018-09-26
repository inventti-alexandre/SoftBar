using Frei.ProjetoIntegrador.LarDoceBar.DB.Usuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frei.ProjetoIntegrador.LarDoceBar
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            Permissoes();
        }

        private void Permissoes()
        {
            UsuarioDTO user = UserSession.UsuarioLogado;
            lblBV.Text = $"Bem vindo, {user.nm_Usuario}";

            if (user.Cod_Perm.Substring(0, 1) == "0")
            {
                if (user.Cod_Perm.Substring(1, 1) == "0")
                {
                    pessoalToolStripMenuItem.Enabled = false;
                }
                if (user.Cod_Perm.Substring(2, 1) == "0")
                {
                    serviçosToolStripMenuItem.Enabled = false;
                }
                if (user.Cod_Perm.Substring(3, 1) == "0")
                {
                    produtosToolStripMenuItem.Enabled = false;
                }
                if (user.Cod_Perm.Substring(4, 1) == "0")
                {
                    finançasToolStripMenuItem.Enabled = false;
                }
            }
        }
    }
}
