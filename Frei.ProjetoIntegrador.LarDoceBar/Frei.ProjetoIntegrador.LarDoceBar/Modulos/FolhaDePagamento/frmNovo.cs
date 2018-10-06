using Frei.ProjetoIntegrador.Academia.DB.FolhaPgmt;
using Frei.ProjetoIntegrador.Academia.DB.Funcionario;
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
    public partial class frmNovo : Form
    {
        public frmNovo()
        {
            InitializeComponent();
        }

        view_Func_Usua_Filial funcionario = new view_Func_Usua_Filial();

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Academia.Validacoes.CPF validar = new Academia.Validacoes.CPF();
                validar.ValidarCPF(txtCPF.Text);

                FuncionarioBusiness business = new FuncionarioBusiness();
                List<view_Func_Usua_Filial> funcionarios = business.ConsultarPorCPF(txtCPF.Text);

                funcionario = funcionarios.ElementAt(0);
                txtNome.Text = funcionario.nm_NomeFunc;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Black Fit LTDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro não identificado: " + ex.Message, "Black Fit LTDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            try
            {
                FolhaPgmtDTO dto = new FolhaPgmtDTO();
                dto.ds_Cargo = txtCargo.Text;
                dto.ds_DiasTrabalhados = txtDias.Text == string.Empty ? 0 : Convert.ToInt32(txtDias.Text);
                dto.ds_HoraE100 = txtHorasE100.Text == string.Empty ? 0 : Convert.ToInt32(txtHorasE100.Text);
                dto.ds_HoraE50 = txtHorasE50.Text == string.Empty ? 0 : Convert.ToInt32(txtHorasE50.Text);
                dto.ds_Mensagem = txtMensagem.Text;
                dto.dt_Registro = DateTime.Now;
                dto.fk_FolhaPgmt_Func = funcionario.id_Funcionario;
                dto.vl_SalarioBruto = txtSalarioBruto.Text == string.Empty ? 0 : Convert.ToDecimal(txtSalarioBruto.Text);

                FolhaPgmtBusiness business = new FolhaPgmtBusiness();
                business.SalvarFolha(dto);

                MessageBox.Show("Folha de Pagamento criada com sucesso!", "Black Fit LTDA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Black Fit LTDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro não identificado: " + ex.Message, "Black Fit LTDA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
