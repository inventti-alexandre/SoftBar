using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.ProjetoIntegrador.LarDoceBar.DB.Funcionario
{
    class FuncionarioBusiness
    {
        public int CadastrarFuncionario(FuncionarioDTO dto)
        {
            FuncionarioDatabase db = new FuncionarioDatabase();
            return db.CadastrarFuncionario(dto);
        }

        public int AlterarFuncionario(FuncionarioDTO dto)
        {
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
