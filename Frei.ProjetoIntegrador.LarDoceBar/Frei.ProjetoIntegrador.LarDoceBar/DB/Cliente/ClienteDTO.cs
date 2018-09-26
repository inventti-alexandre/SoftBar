using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.ProjetoIntegrador.LarDoceBar.DB.Cliente
{
    class ClienteDTO
    {
        public string id_Cliente { get; set; }
        public string nm_Nome { get; set; }
        public int ds_CPF { get; set; }
        public int ds_CEP { get; set; }
        public int ds_Logradouro { get; set; }
        public string ds_Bairro { get; set; }
        public int ds_UF { get; set; }
        public string ds_Complemento { get; set; }
        public string ds_Situacao { get; set; }
        public int num_Telefone { get; set; }
        public int num_Celular { get; set; }
        public string ds_Email { get; set; }
        public string dt_Cadastro { get; set; }
        
    }
}

  
