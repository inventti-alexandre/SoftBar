using Frei.ProjetoIntegrador.Academia.DB.PedidoCompra;
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
    public partial class frmConsultar : Form
    {
        public frmConsultar()
        {
            InitializeComponent();
            CarregarGrid();
        }

        private void CarregarGrid()
        {
            PedidoCompraBusiness business = new PedidoCompraBusiness();
            List<view_PedidoCompra> pedidos = business.Consultar();

            dgvPedidos.AutoGenerateColumns = false;
            dgvPedidos.DataSource = pedidos;
        }

        private void frmConsultar_Load(object sender, EventArgs e)
        {

        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este controle estará ativo na proxima atualização!", "Black Fit LTDA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmNovo frm = new frmNovo();
            Hide();
            frm.ShowDialog();
            CarregarGrid();
            Show();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este controle estará ativo na proxima atualização!", "Black Fit LTDA", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //try
            //{
            //    UsuarioDTO user = UserSession.UsuarioLogado;

            //    UsuarioPermissoes chamar = new UsuarioPermissoes();
            //    UsuarioPermissoes permissoes = chamar.Permissoes(user.Cod_Perm);

            //    if (permissoes.Compra.Substring(0, 1) == "0")
            //    {
            //        if (permissoes.Produto.Substring(4, 1) == "0")
            //            throw new ArgumentException("Você não tem autorização para fazer isto!");
            //    }

            //    view_PedidoCompra data = dgvPedidos.CurrentRow.DataBoundItem as view_PedidoCompra;

            //    PedidoCompraBusiness business = new PedidoCompraBusiness();
            //    business.ApagarCompra(data.id_Pedido_Compra);
            //    CarregarGrid();

            //    MessageBox.Show("Produto Removido com Sucesso!", "Black Fit LTDA", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //}
            //catch (ArgumentException ex)
            //{
            //    MessageBox.Show(ex.Message, "Black Fit LTDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Ocorreu um erro não identificado.", "Black Fit LTDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}
