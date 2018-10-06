using Frei.ProjetoIntegrador.Academia.Validacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.ProjetoIntegrador.Academia.DB.Funcionario
{
    class FuncionarioBusiness
    {
        public int CadastrarFuncionario(FuncionarioDTO dto)
        {
            exReg regex = new exReg();
            regex.ValidarEmail(dto.ds_Email);
            regex.ValidarNome(dto.nm_NomeFunc);
            regex.ValidarTelefoneFixo(dto.num_Telefone);
            regex.ValidarTelefoneCelular(dto.num_Celular);

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

            FuncionarioDatabase db = new FuncionarioDatabase();
            return db.CadastrarFuncionario(dto);
        }

        public int AlterarFuncionario(FuncionarioDTO dto)
        {
            exReg regex = new exReg();
            regex.ValidarEmail(dto.ds_Email);
            regex.ValidarNome(dto.nm_NomeFunc);
            regex.ValidarTelefoneFixo(dto.num_Telefone);
            regex.ValidarTelefoneCelular(dto.num_Celular);

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
            return db.Consultar();
        }

        public List<view_Func_Usua_Filial> ConsultarPorNome(string nome)
        {
            FuncionarioDatabase db = new FuncionarioDatabase();
            return db.ConsultarPorNome(nome);
        }

        public view_Func_Usua_Filial ConsultarPorId(int id)
        {
            FuncionarioDatabase db = new FuncionarioDatabase();
            return db.ConsultarPorId(id);
        }

        public List<view_Func_Usua_Filial> ConsultarPorCPF(string cpf)
        {
            FuncionarioDatabase db = new FuncionarioDatabase();
            return db.ConsultarPorCPF(cpf);
        }

        public List<view_Func_Usua_Filial> ConsultarPorFilial(int idFilial)
        {
            FuncionarioDatabase db = new FuncionarioDatabase();
            return db.ConsultarPorFilial(idFilial);
        }

        public List<view_Func_Usua_Filial> ConsultarPorNome_Filial(int idFilial, string nome)
        {
            FuncionarioDatabase db = new FuncionarioDatabase();
            return db.ConsultarPorNome_Filial(idFilial, nome);
        }
    }
}
