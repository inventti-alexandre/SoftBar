using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.ProjetoIntegrador.Academia.DB.PedidoCompra
{
    class PedidoCompraBusiness
    {
        public int RegistrarCompra(PedidoCompraDTO dto)
        {
            PedidoCompraDatabase db = new PedidoCompraDatabase();
            return db.RegistrarCompra(dto);
        }

        public int AlterarCompra(PedidoCompraDTO dto)
        {
            PedidoCompraDatabase db = new PedidoCompraDatabase();
            return db.AlterarCompra(dto);
        }

        public int ApagarCompra(int idCompra)
        {
            PedidoCompraDatabase db = new PedidoCompraDatabase();
            return db.ApagarCompra(idCompra);
        }

        public List<view_PedidoCompra> Consultar()
        {
            PedidoCompraDatabase db = new PedidoCompraDatabase();
            return db.Consultar();
        }
    }
}
