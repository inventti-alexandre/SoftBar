using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.ProjetoIntegrador.Academia.DB.Funcionario
{
    class view_Func_Usua_Filial
    {
        public int id_Funcionario { get; set; }
        public string nm_NomeFunc { get; set; }
        public string ds_Sexo { get; set; }
        public string ds_CPF { get; set; }
        public string ds_CEPFunc { get; set; }
        public string ds_Bairro { get; set; }
        public string ds_Logradouro { get; set; }
        public string ds_UF { get; set; }
        public string ds_Complemento { get; set; }
        public string num_Celular { get; set; }
        public string num_Telefone { get; set; }
        public string num_Residencia { get; set; }
        public string ds_Email { get; set; }
        public DateTime dt_Admissao { get; set; }
        public DateTime dt_Demissao { get; set; }
        public DateTime dt_Nasc { get; set; }
        public int fk_Func_Usuario { get; set; }
        public int fk_Func_Filial { get; set; }

        public string nm_Usuario { get; set; }
        public bool ds_Situacao { get; set; }

        public string nm_Nome { get; set; }
        public string ds_CEP { get; set; }
    }
}
