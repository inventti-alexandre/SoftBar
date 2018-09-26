using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.ProjetoIntegrador.LarDoceBar.DB.FluxoDeCaixa
{
    class FluxoDeCaixaDTO
    {
        public int id_Fluxo_Caixa { get; set; }
        public int fk_FluxoCaixa_PedidoCompra { get; set; }
        public int fk_FluxoCaixa_PedidoVenda { get; set; }
    }
}
