using Frei.ProjetoIntegrador.Academia.Criptografia;
using Frei.ProjetoIntegrador.LarDoceBar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frei.ProjetoIntegrador.Academia.DB.Usuario
{
    class LoginBusiness
    {
        public UsuarioDTO Autenticar(string nome, string senha)
        {
            if (nome == string.Empty)
                throw new ArgumentException("O nome não pode ficar em branco.");

            if (senha == string.Empty)
                throw new ArgumentException("A senha não pode ficar em branco.");

            DESCripto cripto = new DESCripto();
            senha = cripto.Criptografar(Program.chave, senha);

            LoginDatabase db = new LoginDatabase();
            return db.Autenticar(nome, senha);
        }
    }
}
