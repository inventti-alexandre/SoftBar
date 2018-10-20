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
                ProdutoVendaDTO dto = new ProdutoVendaDTO();
                dto.nm_Produto = txtNome.Text;
                dto.ds_Produto = txtDescricao.Text;
                dto.dt_Validade = dtpValidade.Value;
                //dto.vl_Venda = txtValor.Text == string.Empty ? throw new ArgumentException("Valor não pode ser nulo.") : Convert.ToDecimal(txtValor.Text);
                dto.fk_ProdutoVenda_Filial = Program.id_Filial;

                ProdutoVendaBusiness business = new ProdutoVendaBusiness();
                business.CadastrarProduto(dto);

                MessageBox.Show("Produto cadastrado com sucesso", "Black Fit LTDA", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
