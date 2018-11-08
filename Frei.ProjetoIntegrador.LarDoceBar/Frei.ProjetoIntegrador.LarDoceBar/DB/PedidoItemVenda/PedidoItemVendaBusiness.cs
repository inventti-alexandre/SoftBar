using Frei.ProjetoIntegrador.Academia.DB.EstoqueVenda;
using Frei.ProjetoIntegrador.Academia.DB.PedidoVenda;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.ProjetoIntegrador.Academia.DB.PedidoItemVenda
{
    class PedidoItemVendaBusiness
    {
        public void AdicionarCarrinho(PedidoVendaDTO dto, BindingList<PedidoItemVendaDTO> carrinho)
        {
            PedidoVendaBusiness business = new PedidoVendaBusiness();
            int idVenda = business.RegistrarVenda(dto);

            EstoqueVendaBusiness esBusiness = new EstoqueVendaBusiness();

            PedidoItemVendaDatabase db = new PedidoItemVendaDatabase();
            foreach (PedidoItemVendaDTO itens in carrinho)
            {
                List<view_EstoqueVenda> estoque = esBusiness.ConsultarViewPorNome(itens.nm_Produto);

                if (estoque[0].qnt_Produto < itens.qnt_Produto)
                    throw new ArgumentException("Não há produtos suficientes para serem vendidos!");

                EstoqueVendaDTO esDTO = new EstoqueVendaDTO();
                esDTO.id_Estoque = estoque[0].id_Estoque;
                esDTO.qnt_Produto = estoque[0].qnt_Produto - itens.qnt_Produto;

                esBusiness.RemoverProdutos(esDTO);

                itens.fk_PedidoItemVenda_PedidoVenda = idVenda;
                db.AdicionarCarrinho(itens);
            }
        }

        public int AlterarCarrinho(PedidoItemVendaDTO dto)
        {
            PedidoItemVendaDatabase db = new PedidoItemVendaDatabase();
            return db.AlterarCarrinho(dto);
        }

        public int RemoverCarrinho(int idCarrinho)
        {
            PedidoItemVendaDatabase db = new PedidoItemVendaDatabase();
            return db.RemoverCarrinho(idCarrinho);
        }

        public List<PedidoItemVendaDTO> Consultar()
        {
            PedidoItemVendaDatabase db = new PedidoItemVendaDatabase();
            return db.Consultar();
        }

        public PedidoItemVendaDTO ConsultarPorId(int idCarrinho)
        {
            PedidoItemVendaDatabase db = new PedidoItemVendaDatabase();
            return db.ConsultarPorId(idCarrinho);
        }
    }
}
