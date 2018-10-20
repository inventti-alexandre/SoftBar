using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.ProjetoIntegrador.Academia.DB.ProdutoVenda
{
    class ProdutoVendaDTO
    {
        public int id_produtoVenda { get; set; }
        public string nm_Produto { get; set; }
        public string ds_Produto { get; set; }
        public decimal vl_Venda { get; set; }
        public DateTime dt_Validade { get; set; }
        public int fk_ProdutoVenda_Filial { get; set; }
    }
}
