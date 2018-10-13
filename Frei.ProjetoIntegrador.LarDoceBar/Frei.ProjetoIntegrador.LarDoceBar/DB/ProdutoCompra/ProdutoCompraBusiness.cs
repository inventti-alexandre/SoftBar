using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.ProjetoIntegrador.Academia.DB.ProdutoCompra
{
    class ProdutoCompraBusiness
    {
        public int CadatrarProduto(ProdutoCompraDTO dto)
        {
            ProdutoCompraDatabase db = new ProdutoCompraDatabase();
            return db.CadatrarProduto(dto);
        }

        public int AlterarProduto(ProdutoCompraDTO dto)
        {
            ProdutoCompraDatabase db = new ProdutoCompraDatabase();
            return db.AlterarProduto(dto);
        }

        public int RemoverProduto(int idProduto)
        {
            ProdutoCompraDatabase db = new ProdutoCompraDatabase();
            return db.RemoverProduto(idProduto);
        }

        public List<view_produtoCompra_Forn_Filial> Consultar()
        {
            ProdutoCompraDatabase db = new ProdutoCompraDatabase();
            return db.Consultar();
        }

        public view_produtoCompra_Forn_Filial ConsultarPorId(int idProduto)
        {
            ProdutoCompraDatabase db = new ProdutoCompraDatabase();
            return db.ConsultarPorId(idProduto);
        }

        public List<view_produtoCompra_Forn_Filial> ConsultarPorNome(string nmProduto)
        {
            ProdutoCompraDatabase db = new ProdutoCompraDatabase();
            return db.ConsultarPorNome(nmProduto);
        }

        public List<view_produtoCompra_Forn_Filial> ConsultarPorFornecedor(string nmFornecedor)
        {
            ProdutoCompraDatabase db = new ProdutoCompraDatabase();
            return db.ConsultarPorFornecedor(nmFornecedor);
        }

        public List<view_produtoCompra_Forn_Filial> ConsultarPorFilial(string nmFilial)
        {
            ProdutoCompraDatabase db = new ProdutoCompraDatabase();
            return db.ConsultarPorFilial(nmFilial);
        }

        public List<view_produtoCompra_Forn_Filial> ConsultarPorNome_Fornecedor(string nmProduto, string nmFornecedor)
        {
            ProdutoCompraDatabase db = new ProdutoCompraDatabase();
            return db.ConsultarPorNome_Fornecedor(nmProduto, nmFornecedor);
        }

    }
}
