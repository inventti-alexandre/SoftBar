using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.ProjetoIntegrador.Academia.DB.Fornecedor
{
    class FornecedorBusiness
    {
        public int CadastrarFornecedor(FornecedorDTO dto)
        {
            FornecedorDatabase db = new FornecedorDatabase();
            return db.CadastrarFornecedor(dto);
        }
        public int AlterarFornecedor(FornecedorDTO dto)
        {
            FornecedorDatabase db = new FornecedorDatabase();
            return db.AlterarFornecedor(dto);
        }
        public int RemoverFornecedor(int idFornecedor)
        {
            FornecedorDatabase db = new FornecedorDatabase();
            return db.RemoverFornecedor(idFornecedor);
        }

        public List<FornecedorDTO> Consultar()
        {
            FornecedorDatabase db = new FornecedorDatabase();
            return db.Consultar();
        }
    
        public List<FornecedorDTO> ConsultarPorNome(string nome)
        {
            FornecedorDatabase db = new FornecedorDatabase();
            return db.ConsultarPorNome(nome);
        }

        public List<FornecedorDTO> ConsultarPorSituacao(bool situacao)
        {
            FornecedorDatabase db = new FornecedorDatabase();
            return db.ConsultarPorSituacao(situacao);
        }

        public List<FornecedorDTO> ConsultarPorNome_Situacao(string nome, bool situacao)
        {
            FornecedorDatabase db = new FornecedorDatabase();
            return db.ConsultarPorNome_Situacao(nome, situacao);
        }

        public List<FornecedorDTO> ConsultarPorFilial(int idFilial)
        {
            FornecedorDatabase db = new FornecedorDatabase();
            return db.ConsultarPorFilial(idFilial);
        }

        public FornecedorDTO ConsultarPorId(int idFornecedor)
        {
            FornecedorDatabase db = new FornecedorDatabase();
            return db.ConsultarPorId(idFornecedor);
        }
    }
}
