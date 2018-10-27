using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.ProjetoIntegrador.Academia.DB.Estoque
{
    class view_Estoque
    {
        public int id_Estoque { get; set; }
        public int qnt_Produto { get; set; }
        public int num_Est_Min { get; set; }
        public int num_Est_Max { get; set; }
        public int fk_Estoque_Produto { get; set; }
        public string nm_Produto { get; set; }
        public string ds_Produto { get; set; }
    }
}
