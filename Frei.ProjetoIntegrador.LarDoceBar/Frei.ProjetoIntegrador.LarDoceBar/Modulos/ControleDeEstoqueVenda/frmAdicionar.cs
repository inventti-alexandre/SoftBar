using Frei.ProjetoIntegrador.Academia.DB.EstoqueVenda;
using Frei.ProjetoIntegrador.Academia.DB.ProdutoVenda;
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

namespace Frei.ProjetoIntegrador.LarDoceBar.Modulos.ControleDeEstoqueVenda
{
    public partial class frmAdicionar : Form
    {
        public frmAdicionar()
        {
            InitializeComponent();
            CarregarProdutos();
        }

        private void CarregarProdutos()
        {
            ProdutoVendaBusiness business = new ProdutoVendaBusiness();
            List<ProdutoVendaDTO> prod = business.Consultar();

            cboProduto.DisplayMember = nameof(ProdutoVendaDTO.nm_Produto);
            cboProduto.ValueMember = nameof(ProdutoVendaDTO.id_produtoVenda);
            cboProduto.DataSource = prod;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int id_User = ValidarUsuario(txtNomeUsuario.Text, txtSenha.Text);

            if (id_User == 0)
                throw new ArgumentException("Usuário não autenticado!");

            EstoqueVendaDTO dto = new EstoqueVendaDTO();
            dto.fk_Estoque_ProdutoVenda = Convert.ToInt32(cboProduto.SelectedValue);
            dto.num_Est_Max = Convert.ToInt32(txtEstMax.Text);
            dto.num_Est_Min = Convert.ToInt32(txtEstMin.Text);
            dto.qnt_Produto = Convert.ToInt32(txtQnt.Text);

            ProdutoVendaDTO Produto = cboProduto.SelectedItem as ProdutoVendaDTO;

            EstoqueVendaBusiness business = new EstoqueVendaBusiness();
            business.CriarEstoque(dto, Produto.nm_Produto);

            MessageBox.Show("Estoque atualizado com sucesso!", "Black Fit LTDA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private int ValidarUsuario(string nome, string senha)
        {
            LoginBusiness business = new LoginBusiness();
            UsuarioDTO user = business.Autenticar(nome, senha);

            return user.id_Usuario;
        }

        private void cboProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProdutoVendaBusiness business = new ProdutoVendaBusiness();
            ProdutoVendaDTO prod = business.ConsultarPorId(Convert.ToInt32(cboProduto.SelectedValue));

            txtVlCompra.Text = prod.vl_Venda.ToString();
            txtNomeUsuario.Text = UserSession.UsuarioLogado.nm_Usuario;
        }
    }
}
