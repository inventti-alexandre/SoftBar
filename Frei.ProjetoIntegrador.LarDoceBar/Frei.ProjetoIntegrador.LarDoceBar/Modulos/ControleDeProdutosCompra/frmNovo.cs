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
    public partial class frmNovo : Form
    {
        public frmNovo()
        {
            InitializeComponent();
            CarregarFornecedores();
        }

        private void CarregarFornecedores()
        {
            FornecedorBusiness business = new FornecedorBusiness();
            List<FornecedorDTO> fornecedores = business.Consultar();

            cboFornecedor.ValueMember = nameof(FornecedorDTO.id_Fornecedor);
            cboFornecedor.DisplayMember = nameof(FornecedorDTO.nm_Fornecedor);
            cboFornecedor.DataSource = fornecedores;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                ProdutoCompraDTO dto = new ProdutoCompraDTO();
                dto.nm_Produto = txtNome.Text;
                dto.vl_Compra = Convert.ToDecimal(txtValor.Text);
                dto.dt_Validade = dtpValidade.Value;
                dto.fk_produtoCompra_Filial = Program.id_Filial;
                dto.ds_Produto = txtDesc.Text;
                dto.fk_ProdutoCompra_Fornecedor = Convert.ToInt32(cboFornecedor.SelectedValue);

                ProdutoCompraDatabase business = new ProdutoCompraDatabase();
                business.CadatrarProduto(dto);

                MessageBox.Show("Produto cadastrado com sucesso!", "Black Fit LTDA", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
