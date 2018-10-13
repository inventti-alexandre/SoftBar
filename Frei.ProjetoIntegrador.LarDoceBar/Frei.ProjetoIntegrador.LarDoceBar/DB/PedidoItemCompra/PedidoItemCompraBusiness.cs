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
