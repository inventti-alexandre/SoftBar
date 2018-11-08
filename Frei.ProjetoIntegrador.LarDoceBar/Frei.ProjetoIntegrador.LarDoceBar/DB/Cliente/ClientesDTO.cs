using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.ProjetoIntegrador.Academia.DB.Clientes
{
    class ClientesDTO
    {
        public int id_Cliente { get; set; }
        public string nm_Nome { get; set; }
        public string ds_CPF { get; set; }
        public string ds_CEP { get; set; }
        public string ds_Logradouro { get; set; }
        public string ds_Bairro { get; set; }
        public string ds_UF { get; set; }
        public string ds_Complemento { get; set; }
        public bool ds_Situacao { get; set; }
        public string num_Telefone { get; set; }
        public string num_Celular { get; set; }
        public string ds_Email { get; set; }
        public DateTime dt_Cadastro { get; set; }
        public int fk_Cliente_Filial { get; set; }
    }
}

  
