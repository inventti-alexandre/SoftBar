using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.ProjetoIntegrador.Academia.DB.Usuario
{
    class view_Usuario_Filial
    {
        public int id_Usuario { get; set; }
        public string nm_Usuario { get; set; }
        public string ds_Senha { get; set; }
        public string Cod_Perm { get; set; }
        public bool ds_Situacao { get; set; }
        public int fk_Usuario_Filial { get; set; }

        public string nm_Nome { get; set; }
        public string ds_CEP { get; set; }
    }
}
