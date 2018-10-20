using Frei.ProjetoIntegrador.Academia.APIs.Correio;
using Frei.ProjetoIntegrador.Academia.DB.Clientes;
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
    public partial class frmAlterar : Form
    {
        public frmAlterar()
        {
            InitializeComponent();
        }

        public void CarregarCampos(int idCliente)
        {
            lblId.Text = idCliente.ToString();

            ClientesBusiness business = new ClientesBusiness();
            ClientesDTO cliente = business.ConsultarPorId(idCliente);

            txtNome.Text = cliente.nm_Nome;
            txtCPF.Text = cliente.ds_CPF;
            txtCEP.Text = cliente.ds_CEP;
            txtLogradouro.Text = cliente.ds_Logradouro;
            txtBairro.Text = cliente.ds_Bairro;
            txtComplemento.Text = cliente.ds_Complemento;
            txtUF.Text = cliente.ds_UF;
            txtEmail.Text = cliente.ds_Email;
            txtNCelular.Text = cliente.num_Celular;
            txtNTelefone.Text = cliente.num_Telefone;
        }

        private void btnSearchCEP_Click(object sender, EventArgs e)
        {
            try
            {
                CorreioModel correio = new CorreioModel();
                CorreioResponse response = correio.Endereco(txtCEP.Text);

                txtLogradouro.Text = response.Logradouro;
                txtComplemento.Text = response.Complemento;
                txtBairro.Text = response.Bairro;
                txtUF.Text = response.UF;
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ClientesDTO dto = new ClientesDTO();
                dto.nm_Nome = txtNome.Text;
                dto.ds_CPF = txtCPF.Text;
                dto.ds_CEP = txtCEP.Text;
                dto.ds_Logradouro = txtLogradouro.Text;
                dto.ds_Bairro = txtBairro.Text;
                dto.ds_UF = txtUF.Text;
                dto.ds_Complemento = txtComplemento.Text;
                dto.ds_Email = txtEmail.Text;
                dto.num_Celular = txtNCelular.Text;
                dto.num_Telefone = txtNTelefone.Text;

                ClientesBusiness business = new ClientesBusiness();
                business.AlterarCliente(dto);

                MessageBox.Show("Cliente cadastrado com sucesso!", "Black Fit LTDA", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
