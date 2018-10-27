using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.ProjetoIntegrador.Academia.DB.FluxoDeCaixa
{
    class FluxoDeCaixaDTO
    {
        public DateTime dt_referencia { get; set; }
        public decimal vlVendas { get; set; }
        public decimal vlCompras { get; set; }
        public decimal vlFollha { get; set; }
        public decimal vlGerais { get; set; }
    }
}
