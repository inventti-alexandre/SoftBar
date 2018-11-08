using Frei.ProjetoIntegrador.Academia.APIs.Correio;
using Frei.ProjetoIntegrador.Academia.DB.Fornecedor;
using System;
using System.Windows.Forms;

namespace Frei.ProjetoIntegrador.LarDoceBar.Modulos.ControleDeFornecedor
{
    public partial class frmNovo : Form
    {
        public frmNovo()
        {
            InitializeComponent();
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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                FornecedorDTO dto = new FornecedorDTO();
                dto.nm_Fornecedor = txtNome.Text;
                dto.ds_CNPJ = txtCNPJ.Text;
                dto.ds_CEP = txtCEP.Text;
                dto.ds_Logradouro = txtLogradouro.Text;
                dto.ds_Bairro = txtBairro.Text;
                dto.ds_UF = txtUF.Text;
                dto.ds_Complemento = txtComplemento.Text;
                dto.ds_Email = txtEmail.Text;
                dto.num_Telefone = txtNTelefone.Text;
                dto.fk_Fornecedor_Filial = Program.id_Filial;

                FornecedorDatabase business = new FornecedorDatabase();
                business.CadastrarFornecedor(dto);

                MessageBox.Show("Fornecedor cadastrado com sucesso!", "Black Fit LTDA", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pnEndereco_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnDadosPessoais_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void pnContato_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
