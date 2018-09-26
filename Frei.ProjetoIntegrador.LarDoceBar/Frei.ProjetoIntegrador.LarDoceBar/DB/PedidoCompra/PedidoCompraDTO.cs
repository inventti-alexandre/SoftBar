using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.ProjetoIntegrador.LarDoceBar.DB.PedidoCompra
{
    class PedidoCompraDTO
    {
        public int id_Pedido_Compra { get; set; }
        public DateTime dt_Pedido { get; set; }
        public int fk_PedidoCompra_Usuario { get; set; }
    }
}
