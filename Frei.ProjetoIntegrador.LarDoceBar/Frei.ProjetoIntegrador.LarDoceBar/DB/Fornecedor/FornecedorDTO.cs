using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.ProjetoIntegrador.Academia.DB.Fornecedor
{
    class FornecedorDTO
    {
        public int id_Fornecedor { get; set; }
        public string nm_Fornecedor { get; set; }
        public string num_Telefone { get; set; }
        public string ds_CEP { get; set; }
        public string ds_Logradouro { get; set; }
        public string ds_Bairro { get; set; }
        public string ds_UF { get; set; }
        public string ds_Complemento { get; set; }
        public string ds_CNPJ { get; set; }
        public string ds_Email { get; set; }
        public DateTime dt_Cadastro { get; set; }
        public bool ds_Situacao { get; set; }
        public int fk_Fornecedor_Filial { get; set; }
    }
}
