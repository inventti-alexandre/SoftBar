using Frei.ProjetoIntegrador.Academia.DB.Estoque;
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
    public partial class frmConsultar : Form
    {
        public frmConsultar()
        {
            InitializeComponent();
            CarregarGrid();
        }

        private void CarregarGrid()
        {
            EstoqueBusiness business = new EstoqueBusiness();
            List<view_Estoque> estoque = business.ConsultarView();

            dgvEstoque.AutoGenerateColumns = false;
            dgvEstoque.DataSource = estoque;
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            ControleDeCompra.frmNovo frm = new ControleDeCompra.frmNovo();
            Hide();
            frm.ShowDialog();
            Show();
            CarregarGrid();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            view_Estoque estoque = dgvEstoque.CurrentRow.DataBoundItem as view_Estoque;

            frmAlterar frm = new frmAlterar();
            Hide();
            frm.CarregarCampos(estoque.fk_Estoque_Produto.ToString());
            frm.ShowDialog();
            Show();
            CarregarGrid();
        }
    }
}
