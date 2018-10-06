using Frei.ProjetoIntegrador.Academia.DB.Usuario;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            try
            {
                LoginBusiness business = new LoginBusiness();
                UsuarioDTO user = business.Autenticar(txtNome.Text, txtSenha.Text);

                if (user.nm_Usuario != null)
                {
                    UserSession.UsuarioLogado = user;

                    frmPrincipal frm = new frmPrincipal();
                    Hide();
                    frm.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("Credenciais inválidas.", "Black Fit LTDA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Black Fit LTDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro não identificado.", "Black Fit LTDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
