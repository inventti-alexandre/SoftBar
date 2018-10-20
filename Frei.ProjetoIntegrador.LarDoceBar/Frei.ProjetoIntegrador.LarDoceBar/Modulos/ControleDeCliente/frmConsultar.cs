using Frei.ProjetoIntegrador.Academia.DB.Clientes;
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

namespace Frei.ProjetoIntegrador.LarDoceBar.Modulos.ControleDeCliente
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
            ClientesBusiness business = new ClientesBusiness();
            List<ClientesDTO> clientes = business.Consultar();

            dgvClientes.AutoGenerateColumns = false;
            dgvClientes.DataSource = clientes;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmNovo frm = new frmNovo();
            Hide();
            frm.ShowDialog();
            Show();
            CarregarGrid();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioDTO user = UserSession.UsuarioLogado;

                UsuarioPermissoes chamar = new UsuarioPermissoes();
                UsuarioPermissoes permissoes = chamar.Permissoes(user.Cod_Perm);

                if (permissoes.Cliente.Substring(0, 1) == "0")
                {
                    if (permissoes.Cliente.Substring(4, 1) == "0")
                        throw new ArgumentException("Você não tem autorização para fazer isto!");
                }

                ClientesDTO data = dgvClientes.CurrentRow.DataBoundItem as ClientesDTO;

                ClientesBusiness business = new ClientesBusiness();
                business.RemoverCliente(data.id_Cliente);

                MessageBox.Show("Cliente Removido com Sucesso!", "Black Fit LTDA", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                UsuarioDTO user = UserSession.UsuarioLogado;
                UsuarioPermissoes chamar = new UsuarioPermissoes();
                UsuarioPermissoes permissoes = chamar.Permissoes(user.Cod_Perm);

                if (permissoes.Cliente.Substring(0, 1) == "0")
                {
                    if (permissoes.Cliente.Substring(3, 1) == "0")
                        throw new ArgumentException("Você não tem autorização para fazer isto!");
                }

                ClientesDTO data = dgvClientes.CurrentRow.DataBoundItem as ClientesDTO;

                frmAlterar frm = new frmAlterar();
                Hide();
                frm.CarregarCampos(data.id_Cliente);
                frm.ShowDialog();
                Show();
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
