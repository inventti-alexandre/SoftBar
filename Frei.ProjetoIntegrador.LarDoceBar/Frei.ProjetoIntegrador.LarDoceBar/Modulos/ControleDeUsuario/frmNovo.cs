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

namespace Frei.ProjetoIntegrador.LarDoceBar.Modulos.ControleDeUsuario
{
    public partial class frmNovo : Form
    {
        public frmNovo()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioDTO user = new UsuarioDTO();
                user.nm_Usuario = txtUsuario.Text;
                user.ds_Senha = txtSenha.Text;
                user.ds_Situacao = true;
                user.Cod_Perm = Code();

                UsuarioBusiness business = new UsuarioBusiness();
                business.CadastrarUsuario(user);

                MessageBox.Show("Usuário cadastrado com sucesso!", "Black Fit LTDA", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private string Code()
        {
            //Admin
            string clasA1 = chkA1.Checked == true ? "A" : "0";
            string clasA2 = chkA2.Checked == true ? "A" : "0";
            string clasA3 = chkA3.Checked == true ? "A" : "0";
            string clasA4 = chkA4.Checked == true ? "A" : "0";
            string clasA5 = chkA5.Checked == true ? "A" : "0";
            string clasA6 = chkA6.Checked == true ? "A" : "0";
            string clasA7 = chkA7.Checked == true ? "A" : "0";
            string clasA8 = chkA8.Checked == true ? "A" : "0";
            string clasA9 = chkA9.Checked == true ? "A" : "0";
            string clasA10 = chkA10.Checked == true ? "A" : "0";
            string clasA11 = chkA11.Checked == true ? "A" : "0";

            //Cadastrar
            string clasC1 = chkCad1.Checked == true ? "B" : "0";
            string clasC2 = chkCad2.Checked == true ? "B" : "0";
            string clasC3 = chkCad3.Checked == true ? "B" : "0";
            string clasC4 = chkCad4.Checked == true ? "B" : "0";
            string clasC5 = chkCad5.Checked == true ? "B" : "0";
            string clasC6 = chkCad6.Checked == true ? "B" : "0";
            string clasC7 = chkCad7.Checked == true ? "B" : "0";
            string clasC8 = chkCad8.Checked == true ? "B" : "0";
            string clasC9 = chkCad9.Checked == true ? "B" : "0";
            string clasC10 = chkCad10.Checked == true ? "B" : "0";
            string clasC11 = chkCad11.Checked == true ? "B" : "0";

            //Consultar
            string clasCo1 = chkCon1.Checked == true ? "C" : "0";
            string clasCo2 = chkCon2.Checked == true ? "C" : "0";
            string clasCo3 = chkCon3.Checked == true ? "C" : "0";
            string clasCo4 = chkCon4.Checked == true ? "C" : "0";
            string clasCo5 = chkCon5.Checked == true ? "C" : "0";
            string clasCo6 = chkCon6.Checked == true ? "C" : "0";
            string clasCo7 = chkCon7.Checked == true ? "C" : "0";
            string clasCo8 = chkCon8.Checked == true ? "C" : "0";
            string clasCo9 = chkCon9.Checked == true ? "C" : "0";
            string clasCo10 = chkCon10.Checked == true ? "C" : "0";
            string clasCo11 = chkCon11.Checked == true ? "C" : "0";

            //Alterar
            string clasAlt1 = chkAlt1.Checked == true ? "D" : "0";
            string clasAlt2 = chkAlt2.Checked == true ? "D" : "0";
            string clasAlt3 = chkAlt3.Checked == true ? "D" : "0";
            string clasAlt4 = chkAlt4.Checked == true ? "D" : "0";
            string clasAlt5 = chkAlt5.Checked == true ? "D" : "0";
            string clasAlt6 = chkAlt6.Checked == true ? "D" : "0";
            string clasAlt7 = chkAlt7.Checked == true ? "D" : "0";
            string clasAlt8 = chkAlt8.Checked == true ? "D" : "0";
            string clasAlt9 = chkAlt9.Checked == true ? "D" : "0";
            string clasAlt10 = chkAlt10.Checked == true ? "D" : "0";
            string clasAlt11 = chkAlt11.Checked == true ? "D" : "0";

            //Remover
            string clasR1 = chkRem1.Checked == true ? "E" : "0";
            string clasR2 = chkRem2.Checked == true ? "E" : "0";
            string clasR3 = chkRem3.Checked == true ? "E" : "0";
            string clasR4 = chkRem4.Checked == true ? "E" : "0";
            string clasR5 = chkRem5.Checked == true ? "E" : "0";
            string clasR6 = chkRem6.Checked == true ? "E" : "0";
            string clasR7 = chkRem7.Checked == true ? "E" : "0";
            string clasR8 = chkRem8.Checked == true ? "E" : "0";
            string clasR9 = chkRem9.Checked == true ? "E" : "0";
            string clasR10 = chkRem10.Checked == true ? "E" : "0";
            string clasR11 = chkRem11.Checked == true ? "E" : "0";

            string mod1 = $"{clasA1}{clasC1}{clasCo1}{clasAlt1}{clasR1}";
            string mod2 = $"{clasA2}{clasC2}{clasCo2}{clasAlt2}{clasR2}";
            string mod3 = $"{clasA3}{clasC3}{clasCo3}{clasAlt3}{clasR3}";
            string mod4 = $"{clasA4}{clasC4}{clasCo4}{clasAlt4}{clasR4}";
            string mod5 = $"{clasA5}{clasC5}{clasCo5}{clasAlt5}{clasR5}";
            string mod6 = $"{clasA6}{clasC6}{clasCo6}{clasAlt6}{clasR6}";
            string mod7 = $"{clasA7}{clasC7}{clasCo7}{clasAlt7}{clasR7}";
            string mod8 = $"{clasA8}{clasC8}{clasCo8}{clasAlt8}{clasR8}";
            string mod9 = $"{clasA9}{clasC9}{clasCo9}{clasAlt9}{clasR9}";
            string mod10 = $"{clasA10}{clasC10}{clasCo10}{clasAlt10}{clasR10}";
            string mod11 = $"{clasA11}{clasC11}{clasCo11}{clasAlt11}{clasR11}";

            string cod = $"{mod1}.{mod2}.{mod3}.{mod4}.{mod5}.{mod6}.{mod7}.{mod8}.{mod9}.{mod10}.{mod11}";

            return cod;
        }
    }
}
