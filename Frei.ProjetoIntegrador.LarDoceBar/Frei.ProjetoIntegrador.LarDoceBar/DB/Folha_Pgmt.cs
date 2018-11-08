using Frei.ProjetoIntegrador.Academia.DB.FolhaPgmt;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.ProjetoIntegrador.Academia.DB
{
    class Folha_Pgmt
    {
        public FolhaPgmtDTO Folha(string id, FolhaPgmtDTO dto)
        {
            FolhaPgmtDatabase business = new FolhaPgmtDatabase();
            view_func_folha folha = business.ConsultarPorIdCalc(id);

            int dM = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);

            decimal mes_valor = Mes_Valor(folha.vl_SalarioBruto, dM, folha.ds_DiasTrabalhados);
            decimal valor_trab_50 = Valor_Trab_50(folha.ds_HoraE50, Valor_Hora_50(Convert.ToDouble(Valor_Hora(folha.vl_SalarioBruto))));
            decimal valor_trab_100 = Valor_Trab_100(folha.ds_HoraE100, Valor_Hora_100(Convert.ToDouble(Valor_Hora(folha.vl_SalarioBruto))));
            decimal deducao_ir = Deducao_IR(folha.vl_SalarioBruto);

            decimal totalDeProventos = Math.Round(mes_valor + valor_trab_50 + valor_trab_100 + deducao_ir, 2);

            decimal totalDeDescontos = Math.Round(ValorINSS(folha.vl_SalarioBruto) + ValorFGTS(folha.vl_SalarioBruto) + ValorFinar_IR(ValorIR(folha.vl_SalarioBruto), Deducao_IR(folha.vl_SalarioBruto)) + ValorIR(folha.vl_SalarioBruto) + ValorVR(folha.vl_SalarioBruto) + ValorVT(folha.vl_SalarioBruto), 2);

            decimal totalLiquido = Math.Round(totalDeProventos - totalDeDescontos, 2);

            decimal vlValeTransporte = Math.Round(ValorVT(folha.vl_SalarioBruto), 2);
            decimal vlValeRefeicao = Math.Round(ValorVR(folha.vl_SalarioBruto), 2);
            decimal vlINSS = Math.Round(ValorINSS(folha.vl_SalarioBruto), 2);
            decimal vlHoraE50 = Math.Round(Valor_Hora_50(Convert.ToDouble(Valor_Hora(folha.vl_SalarioBruto))), 2);
            decimal vlHoraE100 = Math.Round(Valor_Hora_100(Convert.ToDouble(Valor_Hora(folha.vl_SalarioBruto))), 2);

            decimal vlBaseINSS = Math.Round(ValorINSS(folha.vl_SalarioBruto), 2);
            decimal vlBaseFGTS = Math.Round(ValorFGTS(folha.vl_SalarioBruto), 2);
            decimal vlMesFGTS = Math.Round(ValorFGTS(folha.vl_SalarioBruto), 2);
            decimal vlBaseIRRF= Math.Round(ValorIR(folha.vl_SalarioBruto), 2);
            decimal vlFaixaIRRF= Math.Round(Deducao_IR(folha.vl_SalarioBruto), 2);

            dto.vl_BaseFGTS = vlBaseFGTS;
            dto.vl_BaseINSS = vlBaseINSS;
            dto.vl_BaseIRRF = vlBaseIRRF;
            dto.vl_Descontos = totalDeDescontos;
            dto.vl_FaixaIRRF = vlFaixaIRRF;
            dto.vl_FGTSmes = vlMesFGTS;
            dto.vl_HoraE100 = vlHoraE100;
            dto.vl_HoraE50 = vlHoraE50;
            dto.vl_INSS = vlINSS;
            dto.vl_Liquido = totalLiquido;
            dto.vl_Proventos = totalDeProventos;
            dto.vl_VR = ValorVR(folha.vl_SalarioBruto);
            dto.vl_VT = ValorVT(folha.vl_SalarioBruto);
            dto.vl_mesSalario = mes_valor;
            dto.vl_DedIR = deducao_ir;
            dto.vl_IR = ValorIR(folha.vl_SalarioBruto);
            dto.vl_ValorIR = ValorFinar_IR(ValorIR(folha.vl_SalarioBruto), Deducao_IR(folha.vl_SalarioBruto));
            dto.vl_ValorFGTS = ValorFGTS(folha.vl_SalarioBruto);

            return dto;
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
