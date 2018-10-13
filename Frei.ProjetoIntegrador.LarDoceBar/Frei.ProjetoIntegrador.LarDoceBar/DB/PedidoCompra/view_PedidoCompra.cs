using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.ProjetoIntegrador.Academia.DB.PedidoCompra
{
    class view_PedidoCompra
    {
        public int id_Pedido_Compra { get; set; }
        public string nm_Usuario { get; set; }
        public DateTime dt_Pedido { get; set; }
        public decimal vl_Total { get; set; }
        public string nm_Nome { get; set; }
        public int qnt_Produto { get; set; }
    }
}
