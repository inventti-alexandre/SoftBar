using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.ProjetoIntegrador.LarDoceBar.DB.FolhaPgmt
{
    class FolhaPgmtDTO
    {
        public int id_Folha_Pgmt { get; set; }
        public DateTime dt_Pgmt { get; set; }
        public decimal vl_Pgmt { get; set; }
        public decimal vl_Descontos { get; set; }
        public string ds_Observacoes { get; set; }
        public int fk_FolhaPgmt_Func { get; set; }
    }
}
