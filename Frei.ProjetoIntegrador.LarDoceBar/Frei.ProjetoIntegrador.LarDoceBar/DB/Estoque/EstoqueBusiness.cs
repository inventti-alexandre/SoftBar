using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.ProjetoIntegrador.Academia.DB.Estoque
{
    class EstoqueBusiness
    {
        public int CriarEstoque(EstoqueDTO dto)
        {
            EstoqueDatabase db = new EstoqueDatabase();
            return db.CriarEstoque(dto);
        }

        public int AlterarEstoque(EstoqueDTO dto)
        {
            EstoqueDatabase db = new EstoqueDatabase();
            return db.AlterarEstoque(dto);
        }

        public int AdicionarProdutos(EstoqueDTO dto)
        {
            EstoqueDatabase db = new EstoqueDatabase();
            return db.AdicionarProdutos(dto);
        }

        public int ApagarEstoque(int idEstoque)
        {
            EstoqueDatabase db = new EstoqueDatabase();
            return db.ApagarEstoque(idEstoque);
        }

        public List<EstoqueDTO> Consultar()
        {
            EstoqueDatabase db = new EstoqueDatabase();
            return db.Consultar();
        }

        public List<view_Estoque> ConsultarView()
        {
            EstoqueDatabase db = new EstoqueDatabase();
            return db.ConsultarView();
        }

        public List<view_Estoque> ConsultarViewPorNome(string nome)
        {
            EstoqueDatabase db = new EstoqueDatabase();
            return db.ConsultarViewPorNome(nome);
        }
    }
}
