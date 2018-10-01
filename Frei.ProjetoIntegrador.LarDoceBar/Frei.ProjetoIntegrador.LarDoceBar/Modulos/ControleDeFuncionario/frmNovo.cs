using Frei.ProjetoIntegrador.LarDoceBar.DB.Funcionario;
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

namespace Frei.ProjetoIntegrador.LarDoceBar.Modulos.ControleDeFuncionario
{
    public partial class frmNovo : Form
    {
        public frmNovo()
        {
            InitializeComponent();
        }

        private void txtCEPEmpresa_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnSearchCEP_Click(object sender, EventArgs e)
        {
            try
            {
                CorreioModel correio = new CorreioModel();
                CorreioResponse response = correio.Endereco(txtCEP.Text);

                txtLogradouro.Text = response.Logradouro;
                txtComplemento.Text = response.Complemento;
                txtBairro.Text = response.Bairro;
                txtUF.Text = response.UF;
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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                int id_User = ValidarUsuario(txtNomeUsuario.Text, txtSenha.Text);

                FuncionarioDTO dto = new FuncionarioDTO();
                dto.nm_NomeFunc = txtNome.Text;
                dto.ds_CPF = txtCPF.Text;
                dto.ds_Sexo = rbnM.Checked == true ? "M" : "F";
                dto.dt_Nasc = dtpNasc.Value;
                dto.ds_CEPFunc = txtCEP.Text;
                dto.ds_Logradouro = txtLogradouro.Text;
                dto.ds_Bairro = txtBairro.Text;
                dto.ds_UF = txtUF.Text;
                dto.ds_Complemento = txtComplemento.Text;
                dto.num_Residencia = txtNRes.Text;
                dto.ds_Email = txtEmail.Text;
                dto.num_Celular = txtNCelular.Text;
                dto.num_Telefone = txtNTelefone.Text;
                dto.dt_Admissao = dtpAdmissao.Value;
                dto.fk_Func_Filial = Program.id_Filial;
                dto.fk_Func_Usuario = id_User;

                FuncionarioBusiness business = new FuncionarioBusiness();
                business.CadastrarFuncionario(dto);

                MessageBox.Show("Funcionário cadastrado com sucesso!", "Black Fit LTDA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
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

        private int ValidarUsuario(string nome, string senha)
        {
            LoginBusiness business = new LoginBusiness();
            UsuarioDTO user = business.Autenticar(nome, senha);

            return user.id_Usuario;
        }

        private void frmNovo_Load(object sender, EventArgs e)
        {

        }
    }
}
