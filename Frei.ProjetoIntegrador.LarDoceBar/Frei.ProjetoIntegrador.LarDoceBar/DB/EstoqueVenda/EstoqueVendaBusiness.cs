using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.ProjetoIntegrador.Academia.DB.EstoqueVenda
{
    class EstoqueVendaBusiness
    {
        public void CriarEstoque(EstoqueVendaDTO dto, string nmProduto)
        {
            EstoqueVendaDatabase db = new EstoqueVendaDatabase();
            List<view_EstoqueVenda> estoque = db.ConsultarViewPorNome(nmProduto);

            if (estoque.Count > 0)
            {
                dto.id_Estoque = estoque[0].id_Estoque;
                dto.qnt_Produto = estoque[0].qnt_Produto + dto.qnt_Produto;
                db.AlterarEstoque(dto);
            }
            else
                db.CriarEstoque(dto);
        }

        public int AlterarEstoque(EstoqueVendaDTO dto)
        {
            EstoqueVendaDatabase db = new EstoqueVendaDatabase();
            return db.AlterarEstoque(dto);
        }

        public int RemoverProdutos(EstoqueVendaDTO dto)
        {
            EstoqueVendaDatabase db = new EstoqueVendaDatabase();
            return db.RemoverProdutos(dto);
        }

        public int ApagarEstoque(int idEstoque)
        {
            EstoqueVendaDatabase db = new EstoqueVendaDatabase();
            return db.ApagarEstoque(idEstoque);
        }

        public List<EstoqueVendaDTO> Consultar()
        {
            EstoqueVendaDatabase db = new EstoqueVendaDatabase();
            return db.Consultar();
        }

        public List<view_EstoqueVenda> ConsultarView()
        {
            EstoqueVendaDatabase db = new EstoqueVendaDatabase();
            return db.ConsultarView();
        }

        public List<view_EstoqueVenda> ConsultarViewPorNome(string nome)
        {
            EstoqueVendaDatabase db = new EstoqueVendaDatabase();
            return db.ConsultarViewPorNome(nome);
        }
    }
}
