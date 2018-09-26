using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.ProjetoIntegrador.LarDoceBar.DB.Funcionario
{
    class FuncionarioDTO
    {
        public int id_Funcionario { get; set; }
        public string nm_Nome { get; set; }
        public string ds_Sexo { get; set; }
        public int ds_CPF { get; set; }
        public int ds_CEP { get; set; }
        public string ds_Bairro { get; set; }
        public int ds_Logradouro { get; set; }
        public int ds_UF { get; set; }
        public int ds_Complemento { get; set; }
        public int num_Celular { get; set; }
        public int num_Telefone { get; set; }
        public int num_Residencia { get; set; }
        public string ds_Email { get; set; }
        public DateTime dt_Admissao { get; set; }
        public DateTime dt_Demissao { get; set; }
        public DateTime dt_Nasc { get; set; }
        public int fk_Func_Usuario { get; set; }
    }
}
