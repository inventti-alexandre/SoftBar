using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.ProjetoIntegrador.Academia.DB.PedidoVenda
{
    class view_PedidoVenda
    {
        public int id_Pedido_Venda { get; set; }
        public int qnt_Produto { get; set; }
        public decimal vl_Total { get; set; }
        public DateTime dt_Pedido { get; set; }
    }
}
