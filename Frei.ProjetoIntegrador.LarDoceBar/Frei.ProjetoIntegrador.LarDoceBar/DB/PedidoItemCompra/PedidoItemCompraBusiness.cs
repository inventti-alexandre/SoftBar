using Frei.ProjetoIntegrador.Academia.DB.Estoque;
using Frei.ProjetoIntegrador.Academia.DB.PedidoCompra;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.ProjetoIntegrador.Academia.DB.PedidoItemCompra
{
    class PedidoItemCompraBusiness
    {
        public void RegistrarProduto(PedidoCompraDTO dto, BindingList<PedidoItemCompraDTO> carrinho)
        {
            PedidoCompraBusiness business = new PedidoCompraBusiness();
            int idCompra = business.RegistrarCompra(dto);

            PedidoItemCompraDatabase db = new PedidoItemCompraDatabase();
            foreach (PedidoItemCompraDTO itens in carrinho)
            {
                EstoqueBusiness esBusiness = new EstoqueBusiness();
                List<view_Estoque> estoque = esBusiness.ConsultarViewPorNome(itens.nm_Produto);

                if(estoque.Count > 0)
                {
                    EstoqueDTO dtoEstoque = new EstoqueDTO();
                    dtoEstoque.id_Estoque = estoque[0].id_Estoque;
                    dtoEstoque.qnt_Produto = estoque[0].qnt_Produto + itens.qnt_Produto;
                    dtoEstoque.fk_Estoque_Produto = estoque[0].fk_Estoque_Produto;

                    esBusiness.AlterarEstoque(dtoEstoque);
                }
                else
                {
                    EstoqueDTO dtoEstoque = new EstoqueDTO();
                    dtoEstoque.num_Est_Max = 2000;
                    dtoEstoque.num_Est_Min = 1;
                    dtoEstoque.qnt_Produto = itens.qnt_Produto;
                    dtoEstoque.fk_Estoque_Produto = itens.fk_PedidoItemCompra_Produto;

                    esBusiness.CriarEstoque(dtoEstoque);
                }

                itens.fk_PedidoItemCompra_PedidoCompra = idCompra;
                db.RegistrarProduto(itens);
            }
        }

        public int AlterarProdutoLista(PedidoItemCompraDTO dto)
        {
            PedidoItemCompraDatabase db = new PedidoItemCompraDatabase();
            return db.AlterarProdutoLista(dto);
        }

        public int RemoverProdutoLista(int idProduto)
        {
            PedidoItemCompraDatabase db = new PedidoItemCompraDatabase();
            return db.RemoverProdutoLista(idProduto);
        }

    }
}
