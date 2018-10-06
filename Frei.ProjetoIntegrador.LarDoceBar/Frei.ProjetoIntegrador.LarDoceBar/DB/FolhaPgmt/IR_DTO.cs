using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.ProjetoIntegrador.Academia.DB.FolhaPgmt
{
    class IR_DTO
    {
        public int id_IR { get; set; }
        public decimal ds_Salario { get; set; }
        public decimal ds_Aliquota { get; set; }
        public decimal ds_Deduzir { get; set; }
    }
}
