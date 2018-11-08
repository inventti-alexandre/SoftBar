using Frei.ProjetoIntegrador.Academia.DB.Fornecedor;
using Frei.ProjetoIntegrador.Academia.DB.Usuario;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Frei.ProjetoIntegrador.LarDoceBar.Modulos.ControleDeFornecedor
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
            FornecedorBusiness business = new FornecedorBusiness();
            List<FornecedorDTO> fornecedores = business.Consultar();

            dgvFornecedor.AutoGenerateColumns = false;
            dgvFornecedor.DataSource = fornecedores;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmNovo frm = new frmNovo();
            Hide();
            frm.ShowDialog();
            Show();
            CarregarGrid();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                FornecedorBusiness business = new FornecedorBusiness();
                List<FornecedorDTO> fornecedores = new List<FornecedorDTO>();

                if (txtNome.Text != string.Empty)
                {
                    fornecedores = business.ConsultarPorNome_Situacao(txtNome.Text, rbnAtivo.Checked);
                }
                else if (txtFilial.Text != string.Empty)
                {
                    fornecedores = business.ConsultarPorFilial(Convert.ToInt32(txtFilial.Text));
                }
                else
                    fornecedores = business.ConsultarPorSituacao(rbnAtivo.Checked);

                dgvFornecedor.AutoGenerateColumns = false;
                dgvFornecedor.DataSource = fornecedores;
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

                if (permissoes.Fornecedor.Substring(0, 1) == "0")
                {
                    if (permissoes.Fornecedor.Substring(4, 1) == "0")
                        throw new ArgumentException("Você não tem autorização para fazer isto!");
                }

                FornecedorDTO data = dgvFornecedor.CurrentRow.DataBoundItem as FornecedorDTO;

                FornecedorBusiness business = new FornecedorBusiness();
                business.RemoverFornecedor(data.id_Fornecedor);

                MessageBox.Show("Fornecedor Removido com Sucesso!", "Black Fit LTDA", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioDTO user = UserSession.UsuarioLogado;
                UsuarioPermissoes chamar = new UsuarioPermissoes();
                UsuarioPermissoes permissoes = chamar.Permissoes(user.Cod_Perm);

                if (permissoes.Fornecedor.Substring(0, 1) == "0")
                {
                    if (permissoes.Fornecedor.Substring(3, 1) == "0")
                        throw new ArgumentException("Você não tem autorização para fazer isto!");
                }

                FornecedorDTO data = dgvFornecedor.CurrentRow.DataBoundItem as FornecedorDTO;

                frmAlterar frm = new frmAlterar();
                Hide();
                frm.CarregarCampos(data.id_Fornecedor);
                frm.ShowDialog();
                CarregarGrid();
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
