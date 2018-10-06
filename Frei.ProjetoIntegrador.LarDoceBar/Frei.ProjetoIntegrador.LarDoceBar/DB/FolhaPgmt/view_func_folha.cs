using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.ProjetoIntegrador.Academia.DB.FolhaPgmt
{
    class view_func_folha
    {
        public int id_Folha_Pgmt { get; set; }
        public DateTime dt_Registro { get; set; }
        public decimal vl_SalarioBruto { get; set; }
        public int ds_DiasTrabalhados { get; set; }
        public string ds_Cargo { get; set; }
        public int ds_HoraE50 { get; set; }
        public int ds_HoraE100 { get; set; }
        public string ds_Mensagem { get; set; }
        public int fk_FolhaPgmt_Func { get; set; }

        public string nm_NomeFunc { get; set; }
        public string ds_CPF { get; set; }
    }
}
