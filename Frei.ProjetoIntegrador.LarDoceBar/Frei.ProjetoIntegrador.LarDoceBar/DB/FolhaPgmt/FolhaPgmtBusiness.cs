using Blibioteca.Developers.Validacao.ER;
using Frei.ProjetoIntegrador.Academia.Criptografia;
using Frei.ProjetoIntegrador.Academia.Validacoes;
using Frei.ProjetoIntegrador.LarDoceBar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.ProjetoIntegrador.Academia.DB.FolhaPgmt
{
    class FolhaPgmtBusiness
    {
        public void SalvarFolha(FolhaPgmtDTO dto)
        {
            ValidarNumero regexNum = new ValidarNumero();
            regexNum.ValidarDinheiro(dto.vl_SalarioBruto.ToString());

            int dM = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);

            if (dto.ds_Cargo == string.Empty)
                throw new ArgumentException("O cargo não pode ser nulo.");

            if (dto.ds_DiasTrabalhados > dM)
                throw new ArgumentException("Impossivél trabalhar essa quantidade de dias no mês decorrente!");

            FolhaPgmtDatabase db = new FolhaPgmtDatabase();
            int idFolha = db.SalvarFolha(dto);

            Folha_Pgmt calcular = new Folha_Pgmt();
            FolhaPgmtDTO folha = calcular.Folha(idFolha.ToString(), dto);

            dto.id_Folha_Pgmt = idFolha;
            db.AlterarFolha(dto);
        }

        public int AlterarFolha(FolhaPgmtDTO dto)
        {
            //exReg regex = new exReg();
            //regex.ValidarSalario(dto.vl_SalarioBruto.ToString());

            if (dto.ds_Cargo == string.Empty)
                throw new ArgumentException("O cargo não pode ser nulo.");

            FolhaPgmtDatabase db = new FolhaPgmtDatabase();
            return db.AlterarFolha(dto);
        }

        public int RemoverFolha(int idFolha)
        {
            FolhaPgmtDatabase db = new FolhaPgmtDatabase();
            return db.RemoverFolha(idFolha);
        }

        public List<view_func_folha> Consultar()
        {
            FolhaPgmtDatabase db = new FolhaPgmtDatabase();
            List<view_func_folha> funcionario = db.Consultar();

            if (funcionario.Count != 0)
            {
                List<view_func_folha> funcDescripto = new List<view_func_folha>();
                DESCripto cripto = new DESCripto();
                foreach (view_func_folha func in funcionario)
                {
                    func.nm_NomeFunc = cripto.Descriptografar(Program.chave, func.nm_NomeFunc);
                    func.ds_CPF = cripto.Descriptografar(Program.chave, func.ds_CPF);

                    funcDescripto.Add(func);
                }

                return funcDescripto;
            }
            else
                return funcionario;
        }

        public view_func_folha ConsultarPorId(string id)
        {
            FolhaPgmtDatabase db = new FolhaPgmtDatabase();
            view_func_folha funcionario = db.ConsultarPorId(id);

            if (funcionario.nm_NomeFunc != string.Empty)
            {
                DESCripto cripto = new DESCripto();

                funcionario.nm_NomeFunc = cripto.Descriptografar(Program.chave, funcionario.nm_NomeFunc);
                funcionario.ds_CPF = cripto.Descriptografar(Program.chave, funcionario.ds_CPF);

                return funcionario;
            }
            else
                return funcionario;
        }

        public List<view_func_folha> ConsultarPorFilial(string filial)
        {
            FolhaPgmtDatabase db = new FolhaPgmtDatabase();
            List<view_func_folha> funcionario = db.ConsultarPorFilial(filial);

            if (funcionario.Count != 0)
            {
                List<view_func_folha> funcDescripto = new List<view_func_folha>();
                DESCripto cripto = new DESCripto();
                foreach (view_func_folha func in funcionario)
                {
                    func.nm_NomeFunc = cripto.Descriptografar(Program.chave, func.nm_NomeFunc);
                    func.ds_CPF = cripto.Descriptografar(Program.chave, func.ds_CPF);

                    funcDescripto.Add(func);
                }

                return funcDescripto;
            }
            else
                return funcionario;
        }

        public view_func_folha ConsultarPorCPF(string CPF)
        {
            DESCripto cripto = new DESCripto();
            CPF = cripto.Criptografar(Program.chave, CPF);

            FolhaPgmtDatabase db = new FolhaPgmtDatabase();
            view_func_folha funcionario = db.ConsultarPorCPF(CPF);

            if (funcionario.nm_NomeFunc != string.Empty)
            {
                funcionario.nm_NomeFunc = cripto.Descriptografar(Program.chave, funcionario.nm_NomeFunc);
                funcionario.ds_CPF = cripto.Descriptografar(Program.chave, funcionario.ds_CPF);

                return funcionario;
            }
            else
                return funcionario;
        }
    }
}
