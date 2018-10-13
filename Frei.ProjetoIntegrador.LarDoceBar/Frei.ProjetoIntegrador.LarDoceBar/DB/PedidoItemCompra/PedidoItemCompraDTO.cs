using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.ProjetoIntegrador.Academia.DB.PedidoItemCompra
{
    class PedidoItemCompraDTO
    {
        public string nm_Produto { get; set; }

        public int id_Pedido_Item_Compra { get; set; }
        public int fk_PedidoItemCompra_Produto { get; set; }
        public int qnt_Produto { get; set; }
        public int fk_PedidoItemCompra_PedidoCompra { get; set; }
    }
}
