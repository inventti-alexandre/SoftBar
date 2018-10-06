using Frei.ProjetoIntegrador.Academia.DB.FolhaPgmt;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frei.ProjetoIntegrador.LarDoceBar.Modulos.FolhaDePagamento
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
            FolhaPgmtBusiness business = new FolhaPgmtBusiness();
            List<view_func_folha> folhas = business.Consultar();

            dgvFolha.AutoGenerateColumns = false;
            dgvFolha.DataSource = folhas;
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            view_func_folha data = dgvFolha.CurrentRow.DataBoundItem as view_func_folha;

            frmVisualizar frm = new frmVisualizar();
            Hide();
            frm.CarregarCampos(data.id_Folha_Pgmt.ToString());
            frm.ShowDialog();
            Show();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            try
            {
                view_func_folha data = dgvFolha.CurrentRow.DataBoundItem as view_func_folha;

                FolhaPgmtBusiness business = new FolhaPgmtBusiness();
                business.RemoverFolha(data.id_Folha_Pgmt);

                CarregarGrid();

                MessageBox.Show("Folha de Pagamento Removido com Sucesso!", "Black Fit LTDA", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                FolhaPgmtBusiness business = new FolhaPgmtBusiness();
                List<view_func_folha> funcionarios = new List<view_func_folha>();

                if (txtCPF.Text == string.Empty)
                {
                    funcionarios = business.Consultar();
                }
                else
                    funcionarios.Add(business.ConsultarPorCPF(txtCPF.Text));


                dgvFolha.AutoGenerateColumns = false;
                dgvFolha.DataSource = funcionarios;
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

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                view_func_folha data = dgvFolha.CurrentRow.DataBoundItem as view_func_folha;

                frmAlterar frm = new frmAlterar();
                Hide();
                frm.CarregarCampos(data.id_Folha_Pgmt.ToString());
                frm.ShowDialog();
                Show();
                CarregarGrid();
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

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmNovo frm = new frmNovo();
            Hide();
            frm.ShowDialog();
            Show();
            CarregarGrid();
        }
    }
}
