using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.ProjetoIntegrador.LarDoceBar.DB.Produto
{
    class ProdutoDTO
    {
        public int id_Produto { get; set; }
        public string nm_Produto { get; set; }
        public int vl_Compra { get; set; }
        public int vl_Venda { get; set; }
        public string ds_Produto { get; set; }
        public string fk_Produto_Fornecedor { get; set; }
    }
}
