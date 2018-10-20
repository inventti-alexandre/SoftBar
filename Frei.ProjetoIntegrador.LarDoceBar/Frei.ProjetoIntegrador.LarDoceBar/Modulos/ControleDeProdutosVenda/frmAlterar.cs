using Frei.ProjetoIntegrador.Academia.DB.ProdutoVenda;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frei.ProjetoIntegrador.LarDoceBar.Modulos.ControleDeProdutosVenda
{
    public partial class frmAlterar : Form
    {
        public frmAlterar()
        {
            InitializeComponent();
        }

        public void CarregarCampos(int idProduto)
        {
            lblId.Text = idProduto.ToString();

            ProdutoVendaBusiness business = new ProdutoVendaBusiness();
            ProdutoVendaDTO produto = business.ConsultarPorId(idProduto);

            txtDescricao.Text = produto.ds_Produto;
            txtNome.Text = produto.nm_Produto;
            txtValor.Text = produto.vl_Venda.ToString();
            dtpValidade.Value = produto.dt_Validade;

            view_Produto prodView = business.ConsultarFilialPorId(produto.fk_ProdutoVenda_Filial);
            txtFilial.Text = prodView.nm_Nome;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ProdutoVendaDTO dto = new ProdutoVendaDTO();
                dto.id_produtoVenda = Convert.ToInt32(lblId.Text);
                dto.nm_Produto = txtNome.Text;
                dto.ds_Produto = txtDescricao.Text;
                dto.dt_Validade = dtpValidade.Value;
                //dto.vl_Venda = txtValor.Text == string.Empty ? throw new ArgumentException("Valor não pode ser nulo.") : Convert.ToDecimal(txtValor.Text);

                ProdutoVendaBusiness business = new ProdutoVendaBusiness();
                business.AlterarProduto(dto);

                MessageBox.Show("Produto alterado com sucesso", "Black Fit LTDA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Black Fit LTDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Black Fit LTDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
