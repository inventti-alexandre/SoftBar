using Blibioteca.Developers.Validacao.ER;
using Frei.ProjetoIntegrador.Academia.Criptografia;
using Frei.ProjetoIntegrador.Academia.Validacoes;
using Frei.ProjetoIntegrador.LarDoceBar;
using System;
using System.Collections.Generic;

namespace Frei.ProjetoIntegrador.Academia.DB.Funcionario
{
    class FuncionarioBusiness
    {
        public int CadastrarFuncionario(FuncionarioDTO dto)
        {
            ValidarNumero regexNum = new ValidarNumero();
            ValidarTexto regexTxt = new ValidarTexto();
            regexTxt.ValidarEmail(dto.ds_Email);
            regexTxt.ValidarNome(dto.nm_NomeFunc);
            regexNum.ValidarTelefoneFixo(dto.num_Telefone);
            regexNum.ValidarTelefoneCelular(dto.num_Celular);

            Email email = new Email();
            email.Validar(dto.ds_Email, dto.nm_NomeFunc);

            CPF validar = new CPF();
            validar.ValidarCPF(dto.ds_CPF);

            decimal idade = DateTime.Now.Year - dto.dt_Nasc.Year;
            if (idade < 18)
                throw new ArgumentException("Não é possível cadastrar funcionários menores de 18 anos.");

            if(dto.ds_Logradouro == string.Empty)
                throw new ArgumentException("Logradouro não pode ser nulo.");

            if (dto.ds_Bairro == string.Empty)
                throw new ArgumentException("Bairro não pode ser nulo.");

            if (dto.ds_UF == string.Empty)
                throw new ArgumentException("UF não pode ser nula.");

            if (dto.num_Residencia == string.Empty)
                throw new ArgumentException("Número de residencia não pode ser nulo.");

            DESCripto cripto = new DESCripto();
            dto.nm_NomeFunc = cripto.Criptografar(Program.chave, dto.nm_NomeFunc);
            dto.ds_CPF = cripto.Criptografar(Program.chave, dto.ds_CPF);
            dto.num_Celular = cripto.Criptografar(Program.chave, dto.num_Celular);
            dto.num_Telefone = cripto.Criptografar(Program.chave, dto.num_Telefone);
            dto.ds_Email = cripto.Criptografar(Program.chave, dto.ds_Email);

            FuncionarioDatabase db = new FuncionarioDatabase();
            return db.CadastrarFuncionario(dto);
        }

        public int AlterarFuncionario(FuncionarioDTO dto)
        {
            ValidarNumero regexNum = new ValidarNumero();
            ValidarTexto regexTxt = new ValidarTexto();
            regexTxt.ValidarEmail(dto.ds_Email);
            regexTxt.ValidarNome(dto.nm_NomeFunc);
            regexNum.ValidarTelefoneFixo(dto.num_Telefone);
            regexNum.ValidarTelefoneCelular(dto.num_Celular);

            Email email = new Email();
            email.Validar(dto.ds_Email, dto.nm_NomeFunc);

            CPF validar = new CPF();
            validar.ValidarCPF(dto.ds_CPF);

            decimal idade = DateTime.Now.Year - dto.dt_Nasc.Year;
            if (idade < 18)
                throw new ArgumentException("Não é possível cadastrar funcionários menores de 18 anos.");

            if (dto.ds_Logradouro == string.Empty)
                throw new ArgumentException("Logradouro não pode ser nulo.");

            if (dto.ds_Bairro == string.Empty)
                throw new ArgumentException("Bairro não pode ser nulo.");

            if (dto.ds_UF == string.Empty)
                throw new ArgumentException("UF não pode ser nula.");

            if (dto.num_Residencia == string.Empty)
                throw new ArgumentException("Número de residencia não pode ser nulo.");

            DESCripto cripto = new DESCripto();
            dto.nm_NomeFunc = cripto.Criptografar(Program.chave, dto.nm_NomeFunc);
            dto.ds_CPF = cripto.Criptografar(Program.chave, dto.ds_CPF);
            dto.num_Celular = cripto.Criptografar(Program.chave, dto.num_Celular);
            dto.num_Telefone = cripto.Criptografar(Program.chave, dto.num_Telefone);
            dto.ds_Email = cripto.Criptografar(Program.chave, dto.ds_Email);

            FuncionarioDatabase db = new FuncionarioDatabase();
            return db.AlterarFuncionario(dto);
        }

        public int RemoverFuncionario(int idFuncionario)
        {
            FuncionarioDatabase db = new FuncionarioDatabase();
            return db.RemoverFuncionario(idFuncionario);
        }

        public List<view_Func_Usua_Filial> Consultar()
        {
            FuncionarioDatabase db = new FuncionarioDatabase();
            List<view_Func_Usua_Filial> funcionario = db.Consultar();

            if (funcionario.Count != 0)
            {
                List<view_Func_Usua_Filial> funcDescripto = new List<view_Func_Usua_Filial>();
                DESCripto cripto = new DESCripto();
                foreach (view_Func_Usua_Filial func in funcionario)
                {
                    func.nm_NomeFunc = cripto.Descriptografar(Program.chave, func.nm_NomeFunc);
                    func.ds_CPF = cripto.Descriptografar(Program.chave, func.ds_CPF);
                    func.num_Celular = cripto.Descriptografar(Program.chave, func.num_Celular);
                    func.num_Telefone = cripto.Descriptografar(Program.chave, func.num_Telefone);
                    func.ds_Email = cripto.Descriptografar(Program.chave, func.ds_Email);

                    funcDescripto.Add(func);
                }

                return funcDescripto;
            }
            else
                return funcionario;
        }

        public List<view_Func_Usua_Filial> ConsultarPorNome(string nome)
        {
            DESCripto cripto = new DESCripto();
            nome = cripto.Criptografar(Program.chave, nome);

            FuncionarioDatabase db = new FuncionarioDatabase();
            List<view_Func_Usua_Filial> funcionario = db.ConsultarPorNome(nome);

            if (funcionario.Count != 0)
            {
                List<view_Func_Usua_Filial> funcDescripto = new List<view_Func_Usua_Filial>();
                foreach (view_Func_Usua_Filial func in funcionario)
                {
                    func.nm_NomeFunc = cripto.Descriptografar(Program.chave, func.nm_NomeFunc);
                    func.ds_CPF = cripto.Descriptografar(Program.chave, func.ds_CPF);
                    func.num_Celular = cripto.Descriptografar(Program.chave, func.num_Celular);
                    func.num_Telefone = cripto.Descriptografar(Program.chave, func.num_Telefone);
                    func.ds_Email = cripto.Descriptografar(Program.chave, func.ds_Email);

                    funcDescripto.Add(func);
                }

                return funcDescripto;
            }
            else
                return funcionario;
        }

        public view_Func_Usua_Filial ConsultarPorId(int id)
        {
            DESCripto cripto = new DESCripto();

            FuncionarioDatabase db = new FuncionarioDatabase();
            view_Func_Usua_Filial funcionario = db.ConsultarPorId(id);

            if (funcionario.id_Funcionario != 0)
            {
                funcionario.nm_NomeFunc = cripto.Descriptografar(Program.chave, funcionario.nm_NomeFunc);
                funcionario.ds_CPF = cripto.Descriptografar(Program.chave, funcionario.ds_CPF);
                funcionario.num_Celular = cripto.Descriptografar(Program.chave, funcionario.num_Celular);
                funcionario.num_Telefone = cripto.Descriptografar(Program.chave, funcionario.num_Telefone);
                funcionario.ds_Email = cripto.Descriptografar(Program.chave, funcionario.ds_Email);

                return funcionario;
            }
            else
                return funcionario;
        }

        public List<view_Func_Usua_Filial> ConsultarPorCPF(string cpf)
        {
            DESCripto cripto = new DESCripto();
            cpf = cripto.Criptografar(Program.chave, cpf);

            FuncionarioDatabase db = new FuncionarioDatabase();
            List<view_Func_Usua_Filial> funcionario = db.ConsultarPorCPF(cpf);

            if (funcionario.Count != 0)
            {
                List<view_Func_Usua_Filial> funcDescripto = new List<view_Func_Usua_Filial>();
                foreach (view_Func_Usua_Filial func in funcionario)
                {
                    func.nm_NomeFunc = cripto.Descriptografar(Program.chave, func.nm_NomeFunc);
                    func.ds_CPF = cripto.Descriptografar(Program.chave, func.ds_CPF);
                    func.num_Celular = cripto.Descriptografar(Program.chave, func.num_Celular);
                    func.num_Telefone = cripto.Descriptografar(Program.chave, func.num_Telefone);
                    func.ds_Email = cripto.Descriptografar(Program.chave, func.ds_Email);

                    funcDescripto.Add(func);
                }

                return funcDescripto;
            }
            else
                return funcionario;
        }

        public List<view_Func_Usua_Filial> ConsultarPorFilial(int idFilial)
        {
            DESCripto cripto = new DESCripto();
            FuncionarioDatabase db = new FuncionarioDatabase();
            List<view_Func_Usua_Filial> funcionario = db.ConsultarPorFilial(idFilial);

            if (funcionario.Count != 0)
            {
                List<view_Func_Usua_Filial> funcDescripto = new List<view_Func_Usua_Filial>();
                foreach (view_Func_Usua_Filial func in funcionario)
                {
                    func.nm_NomeFunc = cripto.Descriptografar(Program.chave, func.nm_NomeFunc);
                    func.ds_CPF = cripto.Descriptografar(Program.chave, func.ds_CPF);
                    func.num_Celular = cripto.Descriptografar(Program.chave, func.num_Celular);
                    func.num_Telefone = cripto.Descriptografar(Program.chave, func.num_Telefone);
                    func.ds_Email = cripto.Descriptografar(Program.chave, func.ds_Email);

                    funcDescripto.Add(func);
                }

                return funcDescripto;
            }
            else
                return funcionario;
        }

        public List<view_Func_Usua_Filial> ConsultarPorNome_Filial(int idFilial, string nome)
        {
            DESCripto cripto = new DESCripto();
            nome = cripto.Criptografar(Program.chave, nome);
            FuncionarioDatabase db = new FuncionarioDatabase();
            List<view_Func_Usua_Filial> funcionario = db.ConsultarPorNome_Filial(idFilial, nome);

            if (funcionario.Count != 0)
            {
                List<view_Func_Usua_Filial> funcDescripto = new List<view_Func_Usua_Filial>();
                foreach (view_Func_Usua_Filial func in funcionario)
                {
                    func.nm_NomeFunc = cripto.Descriptografar(Program.chave, func.nm_NomeFunc);
                    func.ds_CPF = cripto.Descriptografar(Program.chave, func.ds_CPF);
                    func.num_Celular = cripto.Descriptografar(Program.chave, func.num_Celular);
                    func.num_Telefone = cripto.Descriptografar(Program.chave, func.num_Telefone);
                    func.ds_Email = cripto.Descriptografar(Program.chave, func.ds_Email);

                    funcDescripto.Add(func);
                }

                return funcDescripto;
            }
            else
                return funcionario;
        }
    }
}
