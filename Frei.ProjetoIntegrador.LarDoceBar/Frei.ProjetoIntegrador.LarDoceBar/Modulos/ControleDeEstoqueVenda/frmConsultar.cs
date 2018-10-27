using Frei.ProjetoIntegrador.Academia.DB.EstoqueVenda;
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
    public partial class frmConsultar : Form
    {
        public frmConsultar()
        {
            InitializeComponent();
            CarregarGrid();
        }

        private void CarregarGrid()
        {
            EstoqueVendaBusiness business = new EstoqueVendaBusiness();
            List<view_EstoqueVenda> estoque = business.ConsultarView();

            dgvEstoque.AutoGenerateColumns = false;
            dgvEstoque.DataSource = estoque;
        }

        private void btnAlterar_Click_1(object sender, EventArgs e)
        {
            frmAdicionar frm = new frmAdicionar();
            Hide();
            frm.ShowDialog();
            Show();
            CarregarGrid();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            ControleDeVenda.frmNovo frm = new ControleDeVenda.frmNovo();
            Hide();
            frm.ShowDialog();
            Show();
            CarregarGrid();
        }
    }
}
