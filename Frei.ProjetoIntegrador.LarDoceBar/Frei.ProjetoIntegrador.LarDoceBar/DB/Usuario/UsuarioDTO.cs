using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.ProjetoIntegrador.LarDoceBar.DB.Usuario
{
    class UsuarioDTO
    {
        public int id_Usuario { get; set; }
        public string nm_Usuario { get; set; }
        public string ds_Senha { get; set; }
        public string Cod_Perm { get; set; }
        public bool ds_Situacao { get; set; }
        public int fk_Usuario_Filial { get; set; }     
    }
}
