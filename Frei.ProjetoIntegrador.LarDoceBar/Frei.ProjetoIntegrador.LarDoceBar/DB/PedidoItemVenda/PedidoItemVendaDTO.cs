using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.ProjetoIntegrador.Academia.DB.PedidoItemVenda
{
    class PedidoItemVendaDTO
    {
        public string nm_Produto { get; set; }

        public int id_Pedido_Item_Venda { get; set; }
        public int fk_PedidoItemVenda_ProdutoVenda { get; set; }
        public int qnt_Produto { get; set; }
        public int fk_PedidoItemVenda_PedidoVenda { get; set; }
    }
}
