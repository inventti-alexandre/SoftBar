using Frei.ProjetoIntegrador.Academia.Validacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.ProjetoIntegrador.Academia.DB.FolhaPgmt
{
    class FolhaPgmtBusiness
    {
        public int SalvarFolha(FolhaPgmtDTO dto)
        {
            exReg regex = new exReg();
            regex.ValidarSalario(dto.vl_SalarioBruto.ToString());

            if (dto.ds_Cargo == string.Empty)
                throw new ArgumentException("O cargo não pode ser nulo.");

            FolhaPgmtDatabase db = new FolhaPgmtDatabase();
            return db.SalvarFolha(dto);
        }

        public int AlterarFolha(FolhaPgmtDTO dto)
        {
            exReg regex = new exReg();
            regex.ValidarSalario(dto.vl_SalarioBruto.ToString());

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
            return db.Consultar();
        }

        public view_func_folha ConsultarPorId(string id)
        {
            FolhaPgmtDatabase db = new FolhaPgmtDatabase();
            return db.ConsultarPorId(id);
        }

        public List<view_func_folha> ConsultarPorFilial(string filial)
        {
            FolhaPgmtDatabase db = new FolhaPgmtDatabase();
            return db.ConsultarPorFilial(filial);
        }

        public view_func_folha ConsultarPorCPF(string CPF)
        {
            FolhaPgmtDatabase db = new FolhaPgmtDatabase();
            return db.ConsultarPorCPF(CPF);
        }
    }
}
