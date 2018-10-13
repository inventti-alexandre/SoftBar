using Frei.ProjetoIntegrador.Academia.DB.ProdutoCompra;
using Frei.ProjetoIntegrador.LarDoceBar.DB.Fornecedor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frei.ProjetoIntegrador.LarDoceBar.Modulos.ControleDeProdutos
{
    public partial class frmAlterar : Form
    {
        public frmAlterar()
        {
            InitializeComponent();
        }

        public void CarregarCampos(string idProduto)
        {
            lblId.Text = idProduto;

            FornecedorBusiness forn = new FornecedorBusiness();
            List<FornecedorDTO> fornecedores = forn.Consultar();

            cboFornecedor.ValueMember = nameof(FornecedorDTO.id_Fornecedor);
            cboFornecedor.DisplayMember = nameof(FornecedorDTO.nm_Fornecedor);
            cboFornecedor.DataSource = fornecedores;

            CarregarFornecedor();

            ProdutoCompraBusiness business = new ProdutoCompraBusiness();
            view_produtoCompra_Forn_Filial produto = business.ConsultarPorId(Convert.ToInt32(idProduto));

            txtDesc.Text = produto.ds_Produto;
            txtFilial.Text = produto.nm_Nome;
            txtNome.Text = produto.nm_Produto;
            txtValor.Text = produto.vl_Compra.ToString();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ProdutoCompraDTO dto = new ProdutoCompraDTO();
                dto.id_Produto = Convert.ToInt32(lblId.Text);
                dto.nm_Produto = txtNome.Text;
                dto.vl_Compra = Convert.ToDecimal(txtValor.Text);
                dto.dt_Validade = dtpValidade.Value;
                dto.ds_Produto = txtDesc.Text;
                dto.fk_ProdutoCompra_Fornecedor = Convert.ToInt32(cboFornecedor.SelectedValue);

                ProdutoCompraDatabase business = new ProdutoCompraDatabase();
                business.AlterarProduto(dto);

                MessageBox.Show("Alterações salvas com sucesso!", "Black Fit LTDA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Black Fit LTDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Black Fit LTDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboFornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarFornecedor();
        }

        private void CarregarFornecedor()
        {
            FornecedorBusiness forn = new FornecedorBusiness();
            FornecedorDTO fornecedor = forn.ConsultarPorId(Convert.ToInt32(cboFornecedor.SelectedValue));

            txtTelefone.Text = fornecedor.num_Telefone;
            txtEmail.Text = fornecedor.ds_Email;
        }
    }
}
