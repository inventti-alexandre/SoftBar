using Frei.ProjetoIntegrador.LarDoceBar.DB.Usuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frei.ProjetoIntegrador.LarDoceBar
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            Permissoes();
        }

        private void Permissoes()
        {
            UsuarioDTO user = UserSession.UsuarioLogado;
            lblBV.Text = $"Bem vindo, {user.nm_Usuario}";

            UsuarioPermissoes chamar = new UsuarioPermissoes();
            UsuarioPermissoes permissoes = chamar.Permissoes(user.Cod_Perm);

            if (permissoes.Cliente.Substring(0, 1) == "0")
            {
                if (permissoes.Cliente.Substring(1, 1) == "0")
                {
                    cadastrarToolStripMenuItem6.Enabled = false;
                }

                if (permissoes.Cliente.Substring(2, 1) == "0")
                {
                    novoToolStripMenuItem2.Enabled = false;
                }
            }

            if (permissoes.Funcionario.Substring(0, 1) == "0")
            {
                if (permissoes.Funcionario.Substring(1, 1) == "0")
                {
                    cadastrarToolStripMenuItem7.Enabled = false;
                }

                if (permissoes.Funcionario.Substring(2, 1) == "0")
                {
                    consultarToolStripMenuItem8.Enabled = false;
                }
            }

            if (permissoes.Usuario.Substring(0, 1) == "0")
            {
                if (permissoes.Usuario.Substring(1, 1) == "0")
                {
                    cadastarToolStripMenuItem.Enabled = false;
                }

                if (permissoes.Usuario.Substring(2, 1) == "0")
                {
                    consultarToolStripMenuItem9.Enabled = false;
                }
            }

            if (permissoes.Cardapio.Substring(0, 1) == "0")
            {

                if (permissoes.Cardapio.Substring(1, 1) == "0")
                {
                    cadastrarToolStripMenuItem4.Enabled = false;
                }

                if (permissoes.Cardapio.Substring(2, 1) == "0")
                {
                    consultarToolStripMenuItem6.Enabled = false;
                }
            }

            if (permissoes.Produto.Substring(0, 1) == "0")
            {
                if (permissoes.Produto.Substring(1, 1) == "0")
                {
                    cadastrarToolStripMenuItem.Enabled = false;
                }

                if (permissoes.Produto.Substring(2, 1) == "0")
                {
                    consultarToolStripMenuItem.Enabled = false;
                }
            }

            if (permissoes.Compra.Substring(0, 1) == "0")
            {
                if (permissoes.Compra.Substring(1, 1) == "0")
                {
                    cadastrarToolStripMenuItem1.Enabled = false;
                }

                if (permissoes.Compra.Substring(2, 1) == "0")
                {
                    consultarToolStripMenuItem1.Enabled = false;
                }
            }

            if (permissoes.Venda.Substring(0, 1) == "0")
            {
                if (permissoes.Venda.Substring(1, 1) == "0")
                {
                    cadastrarToolStripMenuItem2.Enabled = false;
                }

                if (permissoes.Venda.Substring(2, 1) == "0")
                {
                    consultarToolStripMenuItem2.Enabled = false;
                }
            }

            if (permissoes.Estoque.Substring(0, 1) == "0")
            {
                if (permissoes.Estoque.Substring(1, 1) == "0")
                {
                    cadastrarToolStripMenuItem3.Enabled = false;
                }

                if (permissoes.Estoque.Substring(2, 1) == "0")
                {
                    consultarToolStripMenuItem3.Enabled = false;
                }
            }

            if (permissoes.Fornecedor.Substring(0, 1) == "0")
            {
                if (permissoes.Fornecedor.Substring(1, 1) == "0")
                {
                    cadastrarToolStripMenuItem5.Enabled = false;
                }

                if (permissoes.Fornecedor.Substring(2, 1) == "0")
                {
                    consultarToolStripMenuItem7.Enabled = false;
                }
            }

            if (permissoes.FluxoDeCaixa.Substring(0, 1) == "0")
            {
                if (permissoes.FluxoDeCaixa.Substring(1, 1) == "0")
                {
                    novoToolStripMenuItem.Enabled = false;
                }

                if (permissoes.FluxoDeCaixa.Substring(2, 1) == "0")
                {
                    consultarToolStripMenuItem4.Enabled = false;
                }
            }

            if (permissoes.FolhaDePgmt.Substring(0, 1) == "0")
            {
                if (permissoes.FolhaDePgmt.Substring(1, 1) == "0")
                {
                    novoToolStripMenuItem1.Enabled = false;
                }

                if (permissoes.FolhaDePgmt.Substring(2, 1) == "0")
                {
                    consultarToolStripMenuItem5.Enabled = false;
                }
            }

        }

        private void btnEventos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Não há eventos disponiveis.", "Lar Doce Bar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cadastrarToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Modulos.ControleDeFuncionario.frmNovo frm = new Modulos.ControleDeFuncionario.frmNovo();
            Hide();
            frm.ShowDialog();
            Show();
        }

        private void consultarToolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Modulos.ControleDeFuncionario.frmConsultar frm = new Modulos.ControleDeFuncionario.frmConsultar();
            Hide();
            frm.ShowDialog();
            Show();
        }

        private void cadastarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modulos.ControleDeUsuario.frmNovo frm = new Modulos.ControleDeUsuario.frmNovo();
            Hide();
            frm.ShowDialog();
            Show();
        }

        private void consultarToolStripMenuItem9_Click(object sender, EventArgs e)
        {
            Modulos.ControleDeUsuario.frmConsultar frm = new Modulos.ControleDeUsuario.frmConsultar();
            Hide();
            frm.ShowDialog();
            Show();
        }

        private void novoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Modulos.FolhaDePagamento.frmNovo frm = new Modulos.FolhaDePagamento.frmNovo();
            Hide();
            frm.ShowDialog();
            Show();
        }

        private void consultarToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Modulos.FolhaDePagamento.frmConsultar frm = new Modulos.FolhaDePagamento.frmConsultar();
            Hide();
            frm.ShowDialog();
            Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Modulos.ControleDeFuncionario.frmConsultar frm = new Modulos.ControleDeFuncionario.frmConsultar();
            Hide();
            frm.ShowDialog();
            Show();
        }
    }
}
