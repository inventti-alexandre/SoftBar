using Frei.ProjetoIntegrador.Academia.Validacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.ProjetoIntegrador.Academia.DB.ProdutoVenda
{
    class ProdutoVendaBusiness
    {
        public int CadastrarProduto(ProdutoVendaDTO dto)
        {

            ProdutoVendaDatabase db = new ProdutoVendaDatabase();
            return db.CadastrarProduto(dto);
        }

        public int AlterarProduto(ProdutoVendaDTO dto)
        {
            ProdutoVendaDatabase db = new ProdutoVendaDatabase();
            return db.AlterarProduto(dto);
        }

        public int RemoverProduto(int idProduto)
        {
            ProdutoVendaDatabase db = new ProdutoVendaDatabase();
            return db.RemoverProduto(idProduto);
        }

        public List<ProdutoVendaDTO> Consultar()
        {
            ProdutoVendaDatabase db = new ProdutoVendaDatabase();
            return db.Consultar();
        }

        public ProdutoVendaDTO ConsultarPorId(int idProduto)
        {
            ProdutoVendaDatabase db = new ProdutoVendaDatabase();
            return db.ConsultarPorId(idProduto);
        }

        public view_Produto ConsultarFilialPorId(int idFilial)
        {
            ProdutoVendaDatabase db = new ProdutoVendaDatabase();
            return db.ConsultarFilialPorId(idFilial);
        }
    }
}
