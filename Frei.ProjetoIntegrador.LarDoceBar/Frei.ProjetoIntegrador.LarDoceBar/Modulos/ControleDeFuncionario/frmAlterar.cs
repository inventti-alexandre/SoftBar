using Frei.ProjetoIntegrador.Academia.DB.Funcionario;
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

namespace Frei.ProjetoIntegrador.LarDoceBar.Modulos.ControleDeFuncionario
{
    public partial class frmAlterar : Form
    {
        public frmAlterar()
        {
            InitializeComponent();
        }

        public void CarregarCampos(int id)
        {
            FuncionarioBusiness business = new FuncionarioBusiness();
            view_Func_Usua_Filial dto = business.ConsultarPorId(id);

            lblId.Text = $"{dto.id_Funcionario.ToString()}";
            lblIdUser.Text = dto.fk_Func_Usuario.ToString();
            txtNome.Text = dto.nm_NomeFunc;
            txtCPF.Text = dto.ds_CPF;
            rbnF.Checked = dto.ds_Sexo == "F" ? true : false;
            dtpNasc.Value = dto.dt_Nasc;
            txtCEP.Text = dto.ds_CEPFunc;
            txtLogradouro.Text = dto.ds_Logradouro;
            txtBairro.Text = dto.ds_Bairro;
            txtUF.Text = dto.ds_UF;
            txtComplemento.Text = dto.ds_Complemento;
            txtNRes.Text = dto.num_Residencia;
            txtEmail.Text = dto.ds_Email;
            txtNCelular.Text = dto.num_Celular;
            txtNTelefone.Text = dto.num_Telefone;
            dtpAdmissao.Value = dto.dt_Admissao;
            dtpDemissao.Value = dto.dt_Demissao;
            txtNomeEmpresa.Text = dto.nm_Nome;
            txtNomeUsuario.Text = dto.nm_Usuario;
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                ValidarUsuario(txtNomeUsuario.Text, txtSenha.Text);

                Validacoes.CPF validar = new Validacoes.CPF();
                validar.ValidarCPF(txtCPF.Text);

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
                dto.fk_Func_Usuario = Convert.ToInt32(lblId.Text);

                FuncionarioBusiness business = new FuncionarioBusiness();
                business.AlterarFuncionario(dto);

                MessageBox.Show("Funcionário alterado com sucesso!", "Black Fit LTDA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Black Fit LTDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("'ds_CPF'"))
                    MessageBox.Show("Este CPF já foi cadastrado.", "Black Fit LTDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (ex.Message.Contains("`id_Usuario`"))
                    MessageBox.Show("Usuário não autenticado!", "Black Fit LTDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (ex.Message.Contains("'fk_Func_Usuario'"))
                    MessageBox.Show("Este usuário já está em uso.", "Black Fit LTDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Ocorreu um erro não identificado.", "Black Fit LTDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ValidarUsuario(string nome, string senha)
        {
            LoginBusiness business = new LoginBusiness();
            UsuarioDTO user = business.Autenticar(nome, senha);

            if (user.id_Usuario != Convert.ToInt32(lblIdUser.Text))
                throw new ArgumentException("Usuário não autenticado!");
        }

        private void block_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtUF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void txtNRes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }
    }
}
