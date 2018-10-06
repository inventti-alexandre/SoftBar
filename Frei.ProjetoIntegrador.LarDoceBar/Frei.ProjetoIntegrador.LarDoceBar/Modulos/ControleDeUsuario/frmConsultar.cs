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
    public partial class frmConsultar : Form
    {
        public frmConsultar()
        {
            InitializeComponent();
            CarregarGrid();
        }

        public void CarregarGrid()
        {
            UsuarioBusiness business = new UsuarioBusiness();
            List<view_Usuario_Filial> usuarios = business.Consultar();

            dgvUsuario.AutoGenerateColumns = false;
            dgvUsuario.DataSource = usuarios;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioBusiness business = new UsuarioBusiness();
                List<view_Usuario_Filial> usuario = new List<view_Usuario_Filial>();

                if (txtNome.Text != string.Empty)
                {
                    if (txtFilial.Text != string.Empty)
                    {
                        usuario = business.ConsultarPorNome_Filial(txtNome.Text, Convert.ToInt32(txtFilial.Text));
                    }
                    else
                        usuario = business.ConsultarPorNome(txtNome.Text);
                }
                else
                    usuario = business.Consultar();

                dgvUsuario.AutoGenerateColumns = false;
                dgvUsuario.DataSource = usuario;
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

                if (permissoes.Usuario.Substring(0, 1) == "0")
                {
                    if (permissoes.Usuario.Substring(4, 1) == "0")
                        throw new ArgumentException("Você não tem autorização para fazer isto!");
                }

                view_Usuario_Filial data = dgvUsuario.CurrentRow.DataBoundItem as view_Usuario_Filial;

                if (data.id_Usuario == 1)
                    throw new ArgumentException("Esse usuário não pode ser excluído!");

                UsuarioBusiness business = new UsuarioBusiness();
                business.RemoverUsuario(data.id_Usuario);
                CarregarGrid();

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

                if (permissoes.Usuario.Substring(0, 1) == "0")
                {
                    if (permissoes.Usuario.Substring(3, 1) == "0")
                        throw new ArgumentException("Você não tem autorização para fazer isto!");
                }

                view_Usuario_Filial data = dgvUsuario.CurrentRow.DataBoundItem as view_Usuario_Filial;

                frmAlterar frm = new frmAlterar();
                Hide();
                frm.CarregarCampos(data.id_Usuario.ToString());
                frm.ShowDialog();
                Show();
                CarregarGrid();
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

                if (permissoes.Usuario.Substring(0, 1) == "0")
                {
                    if (permissoes.Usuario.Substring(1, 1) == "0")
                        throw new ArgumentException("Você não tem autorização para fazer isto!");
                }

                frmNovo frm = new frmNovo();
                Hide();
                frm.ShowDialog();
                Show();
                CarregarGrid();
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
