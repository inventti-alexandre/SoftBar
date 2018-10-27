using Frei.ProjetoIntegrador.Academia.DB.Estoque;
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

namespace Frei.ProjetoIntegrador.LarDoceBar.Modulos.ControleDeEstoque
{
    public partial class frmAlterar : Form
    {
        public frmAlterar()
        {
            InitializeComponent();
        }

        public void CarregarCampos(string idProduto)
        {

            ProdutoCompraBusiness business = new ProdutoCompraBusiness();
            view_produtoCompra_Forn_Filial produtos = business.ConsultarPorId(Convert.ToInt32(idProduto));

            EstoqueBusiness esBusiness = new EstoqueBusiness();
            List<view_Estoque> estoque = esBusiness.ConsultarViewPorNome(produtos.nm_Produto);
            lblId.Text = estoque[0].id_Estoque.ToString();

            txtFornecedor.Text = produtos.nm_Fornecedor;
            txtNomeUsuario.Text = UserSession.UsuarioLogado.nm_Usuario;
            txtProduto.Text = produtos.nm_Produto;
            txtQntAtual.Text = estoque[0].qnt_Produto.ToString();
            txtVlCompra.Text = produtos.vl_Compra.ToString();
            txtEstMax.Text = estoque[0].num_Est_Max.ToString();
            txtEstMin.Text = estoque[0].num_Est_Min.ToString();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                int id_User = ValidarUsuario(txtNomeUsuario.Text, txtSenha.Text);

                if (id_User == 0)
                    throw new ArgumentException("Usuário não autenticado!");

                int qntProdutoAtual = Convert.ToInt32(txtQntAtual.Text);
                int qntProdutoRetirada = Convert.ToInt32(txtQntRetirada.Text);

                if (qntProdutoRetirada > qntProdutoAtual)
                    throw new ArgumentException("Não há produtos suficientes!");

                EstoqueDTO dto = new EstoqueDTO();
                dto.id_Estoque = Convert.ToInt32(lblId.Text);
                dto.num_Est_Max = Convert.ToInt32(txtEstMax.Text);
                dto.num_Est_Min = Convert.ToInt32(txtEstMin.Text);
                dto.qnt_Produto = qntProdutoAtual - qntProdutoRetirada;

                EstoqueBusiness business = new EstoqueBusiness();
                business.AlterarEstoque(dto);

                MessageBox.Show("Baixa no estoque dada com sucesso!", "Black Fit LTDA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
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

        private int ValidarUsuario(string nome, string senha)
        {
            LoginBusiness business = new LoginBusiness();
            UsuarioDTO user = business.Autenticar(nome, senha);

            return user.id_Usuario;
        }
    }
}
