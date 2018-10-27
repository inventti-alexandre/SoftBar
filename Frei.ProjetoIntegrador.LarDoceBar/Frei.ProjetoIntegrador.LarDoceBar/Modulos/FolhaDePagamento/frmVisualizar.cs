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
    public partial class frmVisualizar : Form
    {
        public frmVisualizar()
        {
            InitializeComponent();
        }

        public void CarregarCampos(string id)
        {
            lblCod.Text = id;

            FolhaPgmtBusiness business = new FolhaPgmtBusiness();
            view_func_folha folha = business.ConsultarPorId(id);

            lblNome.Text = folha.nm_NomeFunc;
            lblFuncao.Text = folha.ds_Cargo;
            lblDiasTrabalhados.Text = folha.ds_DiasTrabalhados.ToString();
            lblSalario.Text = Math.Round(folha.vl_SalarioBruto, 2).ToString();
            lblVencimentos.Text = folha.vl_Proventos.ToString();
            lblDescontos.Text = folha.vl_Descontos.ToString();
            lblReceber.Text = folha.vl_Liquido.ToString();

            lblValeTransporte.Text = folha.vl_VT.ToString();
            lblValeRefeicao.Text = folha.vl_VR.ToString();
            lblINSS.Text = folha.vl_INSS.ToString();
            lblHoraE50.Text = folha.vl_HoraE50.ToString();
            lblHoraE100.Text = folha.vl_HoraE100.ToString();
            lblMensagem.Text = folha.ds_Mensagem;

            lblSalarioBase.Text = folha.vl_SalarioBruto.ToString();
            lblINSSBase.Text = folha.vl_BaseINSS.ToString();
            lblFGTSBase.Text = folha.vl_BaseFGTS.ToString();
            lblFGTSMes.Text = folha.vl_FGTSmes.ToString();
            lblBaseIRRF.Text = folha.vl_BaseIRRF.ToString();
            lblFaixaIRRF.Text = folha.vl_FaixaIRRF.ToString();
        }
    }
}
