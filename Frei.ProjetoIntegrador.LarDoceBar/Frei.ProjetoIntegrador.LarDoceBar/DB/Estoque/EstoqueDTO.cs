using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.ProjetoIntegrador.LarDoceBar.DB.Estoque
{
    class EstoqueDTO
    {
        public int id_Estoque { get; set; }
        public int qnt_Produto { get; set; }
        public int num_Est_Min { get; set; }
        public int num_Est_Max { get; set; }
        
       
    }
}
