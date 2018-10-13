using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.ProjetoIntegrador.Academia.DB.ProdutoCompra
{
    class ProdutoCompraDTO
    {
        public int id_Produto { get; set; }
        public string nm_Produto { get; set; }
        public decimal vl_Compra { get; set; }
        public string ds_Produto { get; set; }
        public DateTime dt_Validade { get; set; }
        public int fk_ProdutoCompra_Fornecedor { get; set; }
        public int fk_produtoCompra_Filial { get; set; }

    }
}
