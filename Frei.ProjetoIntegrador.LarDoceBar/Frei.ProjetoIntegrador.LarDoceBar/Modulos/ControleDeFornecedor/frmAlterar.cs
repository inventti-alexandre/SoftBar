using Frei.ProjetoIntegrador.LarDoceBar.DB.Fornecedor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frei.ProjetoIntegrador.LarDoceBar.Modulos.ControleDeFornecedor
{
    public partial class frmAlterar : Form
    {
        public frmAlterar()
        {
            InitializeComponent();
        }

        public void CarregarCampos(int idFornecedor)
        {
            lblId.Text = idFornecedor.ToString();

            FornecedorBusiness business = new FornecedorBusiness();
            FornecedorDTO dto = business.ConsultarPorId(idFornecedor);

            txtNome.Text = dto.nm_Fornecedor;
            txtCNPJ.Text = dto.ds_CNPJ;
            txtCEP.Text = dto.ds_CEP;
            txtLogradouro.Text = dto.ds_Logradouro;
            txtBairro.Text = dto.ds_Bairro;
            txtUF.Text = dto.ds_UF;
            txtComplemento.Text = dto.ds_Complemento;
            txtEmail.Text = dto.ds_Email;
            txtNTelefone.Text = dto.num_Telefone;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                FornecedorDTO dto = new FornecedorDTO();
                dto.nm_Fornecedor = txtNome.Text;
                dto.id_Fornecedor = Convert.ToInt32(lblId.Text);
                dto.ds_CNPJ = txtCNPJ.Text;
                dto.ds_CEP = txtCEP.Text;
                dto.ds_Logradouro = txtLogradouro.Text;
                dto.ds_Bairro = txtBairro.Text;
                dto.ds_UF = txtUF.Text;
                dto.ds_Complemento = txtComplemento.Text;
                dto.ds_Email = txtEmail.Text;
                dto.num_Telefone = txtNTelefone.Text;

                FornecedorDatabase business = new FornecedorDatabase();
                business.AlterarFornecedor(dto);

                MessageBox.Show("Alterações salvas com sucesso!", "Black Fit LTDA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Black Fit LTDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Black Fit LTDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
