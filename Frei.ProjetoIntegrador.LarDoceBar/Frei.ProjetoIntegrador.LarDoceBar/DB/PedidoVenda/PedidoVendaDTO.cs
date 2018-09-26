using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.ProjetoIntegrador.LarDoceBar.DB.PedidoVenda
{
    class PedidoVendaDTO
    {
        public int id_Pedido_Venda { get; set; }
        public DateTime dt_Pedido { get; set; }
        public int fk_PedidoVenda_Usuario { get; set; }
        public int fk_PedidoVenda_Cliente { get; set; }
        public int fk_PedidoVenda_Filial { get; set; }
    }
}
