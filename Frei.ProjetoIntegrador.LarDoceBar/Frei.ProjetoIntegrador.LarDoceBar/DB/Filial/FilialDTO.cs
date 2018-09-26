using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.ProjetoIntegrador.LarDoceBar.DB.Filial
{
    class FilialDTO
    {
        public int id_Filial { get; set; }
        public string nm_Nome { get; set; }
        public string ds_CEP { get; set; }
        public string ds_Logradouro { get; set; }
        public string ds_Bairro { get; set; }
        public string ds_UF { get; set; }
        public string ds_Complemento { get; set; }
    }
}
