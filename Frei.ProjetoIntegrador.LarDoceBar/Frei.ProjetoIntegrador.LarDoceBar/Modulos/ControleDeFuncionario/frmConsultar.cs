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
    public partial class frmConsultar : Form
    {
        public frmConsultar()
        {
            InitializeComponent();
            CarregarGrid();
        }

        private void CarregarGrid()
        {
            FuncionarioBusiness business = new FuncionarioBusiness();
            List<view_Func_Usua_Filial> funcionarios = business.Consultar();

            dgvFuncionario.AutoGenerateColumns = false;
            dgvFuncionario.DataSource = funcionarios;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                FuncionarioBusiness business = new FuncionarioBusiness();
                List<view_Func_Usua_Filial> funcionarios = new List<view_Func_Usua_Filial>();

                if (txtCPF.Text == string.Empty)
                {
                    if (txtNome.Text != string.Empty)
                    {
                        if (txtFilial.Text != string.Empty)
                        {
                            funcionarios = business.ConsultarPorNome_Filial(Convert.ToInt32(txtFilial.Text), txtNome.Text);
                        }
                        else
                            funcionarios = business.ConsultarPorNome(txtNome.Text);
                    }
                    else if (txtFilial.Text != string.Empty && txtNome.Text == string.Empty)
                    {
                        funcionarios = business.ConsultarPorFilial(Convert.ToInt32(txtFilial.Text));
                    }
                    else
                        funcionarios = business.Consultar();
                }
                else
                    funcionarios = business.ConsultarPorCPF(txtCPF.Text);

                dgvFuncionario.AutoGenerateColumns = false;
                dgvFuncionario.DataSource = funcionarios;
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

        private void btnNovo_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioDTO user = UserSession.UsuarioLogado;

                UsuarioPermissoes chamar = new UsuarioPermissoes();
                UsuarioPermissoes permissoes = chamar.Permissoes(user.Cod_Perm);

                if (permissoes.Funcionario.Substring(0, 1) == "0")
                {
                    if (permissoes.Funcionario.Substring(1, 1) == "0")
                        throw new ArgumentException("Você não tem autorização para fazer isto!");
                }

                frmNovo frm = new frmNovo();
                Hide();
                frm.ShowDialog();
                Show();
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

        private void btnRemover_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioDTO user = UserSession.UsuarioLogado;

                UsuarioPermissoes chamar = new UsuarioPermissoes();
                UsuarioPermissoes permissoes = chamar.Permissoes(user.Cod_Perm);

                if (permissoes.Funcionario.Substring(0, 1) == "0")
                {
                    if (permissoes.Funcionario.Substring(4, 1) == "0")
                        throw new ArgumentException("Você não tem autorização para fazer isto!");
                }

                view_Func_Usua_Filial data = dgvFuncionario.CurrentRow.DataBoundItem as view_Func_Usua_Filial;

                FuncionarioBusiness business = new FuncionarioBusiness();
                business.RemoverFuncionario(data.id_Funcionario);

                MessageBox.Show("Funcionário Removido com Sucesso!", "Black Fit LTDA", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                UsuarioDTO user = UserSession.UsuarioLogado;
                UsuarioPermissoes chamar = new UsuarioPermissoes();
                UsuarioPermissoes permissoes = chamar.Permissoes(user.Cod_Perm);

                if (permissoes.Funcionario.Substring(0, 1) == "0")
                {
                    if (permissoes.Funcionario.Substring(3, 1) == "0")
                        throw new ArgumentException("Você não tem autorização para fazer isto!");
                }

                view_Func_Usua_Filial data = dgvFuncionario.CurrentRow.DataBoundItem as view_Func_Usua_Filial;

                frmAlterar frm = new frmAlterar();
                Hide();
                frm.CarregarCampos(data.id_Funcionario);
                frm.ShowDialog();
                Show();
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

