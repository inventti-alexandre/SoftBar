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

            decimal mes_valor = Mes_Valor(folha.vl_SalarioBruto, 31, folha.ds_DiasTrabalhados);
            decimal valor_trab_50 = Valor_Trab_50(folha.ds_HoraE50, Valor_Hora_50(Convert.ToDouble(Valor_Hora(folha.vl_SalarioBruto))));
            decimal valor_trab_100 = Valor_Trab_100(folha.ds_HoraE100, Valor_Hora_100(Convert.ToDouble(Valor_Hora(folha.vl_SalarioBruto))));
            decimal deducao_ir = Deducao_IR(folha.vl_SalarioBruto);

            decimal totalDeProventos = Math.Round(mes_valor + valor_trab_50 + valor_trab_100 + deducao_ir, 2);
            lblVencimentos.Text = totalDeProventos.ToString();

            decimal totalDeDescontos = Math.Round(ValorINSS(folha.vl_SalarioBruto) + ValorFGTS(folha.vl_SalarioBruto) + ValorFinar_IR(ValorIR(folha.vl_SalarioBruto), Deducao_IR(folha.vl_SalarioBruto)) + ValorIR(folha.vl_SalarioBruto) + ValorVR(folha.vl_SalarioBruto) + ValorVT(folha.vl_SalarioBruto), 2);
            lblDescontos.Text = totalDeDescontos.ToString();

            decimal totalLiquido = Math.Round(totalDeProventos - totalDeDescontos, 2);
            lblReceber.Text = totalLiquido.ToString();

            lblValeTransporte.Text = Math.Round(ValorVT(folha.vl_SalarioBruto), 2).ToString();
            lblValeRefeicao.Text = Math.Round(ValorVR(folha.vl_SalarioBruto), 2).ToString();
            lblINSS.Text = Math.Round(ValorINSS(folha.vl_SalarioBruto), 2).ToString();
            //lblHoraE50.Text = Math.Round(Valor_Hora_50(Convert.ToDouble(Valor_Hora(folha.vl_SalarioBruto))), 2).ToString();
            lblHoraE50.Text = folha.ds_HoraE50.ToString();
            //lblHoraE100.Text = Math.Round(Valor_Hora_100(Convert.ToDouble(Valor_Hora(folha.vl_SalarioBruto))), 2).ToString();
            lblHoraE50.Text = folha.ds_HoraE100.ToString();
            lblMensagem.Text = folha.ds_Mensagem;

            lblSalarioBase.Text = Math.Round(folha.vl_SalarioBruto, 2).ToString();
            lblINSSBase.Text = Math.Round(ValorINSS(folha.vl_SalarioBruto), 2).ToString();
            lblFGTSBase.Text = Math.Round(ValorFGTS(folha.vl_SalarioBruto), 2).ToString();
            lblFGTSMes.Text = Math.Round(ValorFGTS(folha.vl_SalarioBruto), 2).ToString();
            lblBaseIRRF.Text = Math.Round(ValorIR(folha.vl_SalarioBruto), 2).ToString();
            lblFaixaIRRF.Text = Math.Round(Deducao_IR(folha.vl_SalarioBruto), 2).ToString();
        }

        private decimal Mes_Valor(decimal SalarioBruto, int DiasMesAtual, int DiasMesTrabalhado)
        {
            decimal resultado = (SalarioBruto / DiasMesAtual) * DiasMesTrabalhado;
            return resultado;
        }

        private decimal Valor_Hora(decimal SalarioBruto)
        {
            decimal resultado = SalarioBruto / 220;
            return resultado;
        }

        private decimal Valor_Hora_50(double ValorHora)
        {
            double resultado = ValorHora + (ValorHora * 0.5);
            return Convert.ToDecimal(resultado);
        }

        private decimal Valor_Hora_100(double ValorHora)
        {
            double resultado = ValorHora + (ValorHora * 1);
            return Convert.ToDecimal(resultado);
        }

        private decimal Valor_Trab_50(decimal HorasTrab50, decimal ValorHora50)
        {
            decimal resultado = HorasTrab50 * ValorHora50;
            return resultado;
        }

        private decimal Valor_Trab_100(decimal HorasTrab100, decimal ValorHora100)
        {
            decimal resultado = HorasTrab100 * ValorHora100;
            return resultado;
        }

        private decimal ValorINSS(decimal SalarioBase)
        {
            FolhaPgmtDatabase db = new FolhaPgmtDatabase();
            decimal taxa = db.TaxaINSS(SalarioBase);

            decimal resultado = (taxa / 100) * SalarioBase;
            return Math.Round(resultado, 2);
        }

        private decimal ValorIR(decimal SalarioBase)
        {
            FolhaPgmtDatabase db = new FolhaPgmtDatabase();
            decimal taxa = db.TaxaIR(SalarioBase);

            decimal resultado = (taxa / 100) * SalarioBase;
            return Math.Round(resultado, 2);
        }

        private decimal Deducao_IR(decimal SalarioBase)
        {
            FolhaPgmtDatabase db = new FolhaPgmtDatabase();
            decimal resultado = Math.Round(db.DeducaoIR(SalarioBase), 2);
            return resultado;
        }

        private decimal ValorFinar_IR(decimal ValorIR, decimal DecucaoIR)
        {
            decimal resultado = ValorIR - DecucaoIR;
            return resultado;
        }

        private decimal ValorFGTS(decimal SalarioBase)
        {
            FolhaPgmtDatabase db = new FolhaPgmtDatabase();
            List<Descontos_DTO> taxas = db.Descontos();
            Descontos_DTO taxa = taxas.ElementAt(2);

            decimal resultado = SalarioBase * taxa.ds_Porcentagem / 100;
            return resultado;
        }

        private decimal ValorVR(decimal SalarioBase)
        {
            FolhaPgmtDatabase db = new FolhaPgmtDatabase();
            List<Descontos_DTO> taxas = db.Descontos();
            Descontos_DTO taxa = taxas.ElementAt(1);

            decimal resultado = SalarioBase * taxa.ds_Porcentagem / 100;
            return resultado;
        }

        private decimal ValorVT(decimal SalarioBase)
        {
            FolhaPgmtDatabase db = new FolhaPgmtDatabase();
            List<Descontos_DTO> taxas = db.Descontos();
            Descontos_DTO taxa = taxas.ElementAt(0);

            decimal resultado = SalarioBase * taxa.ds_Porcentagem / 100;
            return resultado;
        }
    }
}
