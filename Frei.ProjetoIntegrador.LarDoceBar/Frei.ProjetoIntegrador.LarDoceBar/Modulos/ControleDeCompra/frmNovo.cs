using Frei.ProjetoIntegrador.Academia.DB.PedidoCompra;
using Frei.ProjetoIntegrador.Academia.DB.PedidoItemCompra;
using Frei.ProjetoIntegrador.Academia.DB.ProdutoCompra;
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

namespace Frei.ProjetoIntegrador.LarDoceBar.Modulos.ControleDeCompra
{
    public partial class frmNovo : Form
    {
        public frmNovo()
        {
            InitializeComponent();
            CarregarProdutos();
            CarregarCampos();
            CarregarGrid();
        }

        BindingList<PedidoItemCompraDTO> produtosCarrinho = new BindingList<PedidoItemCompraDTO>();

        private void CarregarGrid()
        {
            dgvItens.AutoGenerateColumns = false;
            dgvItens.DataSource = produtosCarrinho;
        }

        private void CarregarCampos()
        {
            UsuarioDTO user = UserSession.UsuarioLogado;
            txtUsuario.Text = user.nm_Usuario;
        }

        private int ValidarUsuario(string nome, string senha)
        {
            LoginBusiness business = new LoginBusiness();
            UsuarioDTO user = business.Autenticar(nome, senha);

            return user.id_Usuario;
        }

        private void CarregarProdutos()
        {
            ProdutoCompraBusiness business = new ProdutoCompraBusiness();
            List<view_produtoCompra_Forn_Filial> produtos = business.Consultar();

            cboProdutos.ValueMember = nameof(view_produtoCompra_Forn_Filial.id_Produto);
            cboProdutos.DisplayMember = nameof(view_produtoCompra_Forn_Filial.nm_Produto);
            cboProdutos.DataSource = produtos;
        }

        private void cboProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProdutoCompraBusiness business = new ProdutoCompraBusiness();
            view_produtoCompra_Forn_Filial produto = business.ConsultarPorId(Convert.ToInt32(cboProdutos.SelectedValue));
            txtFornecedor.Text = produto.nm_Fornecedor;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            view_produtoCompra_Forn_Filial dto = cboProdutos.SelectedItem as view_produtoCompra_Forn_Filial;
            PedidoItemCompraDTO item = new PedidoItemCompraDTO();

            item.qnt_Produto = Convert.ToInt32(txtQuantidade.Text);
            item.fk_PedidoItemCompra_Produto = dto.id_Produto;
            item.nm_Produto = dto.nm_Produto;

            produtosCarrinho.Add(item);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int id_User = ValidarUsuario(txtUsuario.Text, txtConfSenha.Text);

            if (id_User == 0)
                throw new ArgumentException("Usuário não autenticado!");

            PedidoCompraDTO pedido = new PedidoCompraDTO();
            pedido.dt_Pedido = DateTime.Now;
            pedido.fk_PedidoCompra_Filial = Program.id_Filial;
            pedido.fk_PedidoCompra_Usuario = id_User;

            PedidoItemCompraBusiness business = new PedidoItemCompraBusiness();
            business.RegistrarProduto(pedido, produtosCarrinho);

            MessageBox.Show("Compra efetuada com sucesso!", "Black Fit LTDA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            produtosCarrinho.RemoveAt(0);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            while (produtosCarrinho.Count > 0)
                produtosCarrinho.RemoveAt(0);
        }
    }
}
