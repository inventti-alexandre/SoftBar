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

            PedidoItemVendaDatabase db = new PedidoItemVendaDatabase();
            foreach (PedidoItemVendaDTO itens in carrinho)
            {
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
