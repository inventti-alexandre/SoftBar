using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.ProjetoIntegrador.Academia.DB.FolhaPgmt
{
    class Descontos_DTO
    {
        public int id_Descontos { get; set; }
        public string ds_Tipo { get; set; }
        public decimal ds_Porcentagem { get; set; }
    }
}
