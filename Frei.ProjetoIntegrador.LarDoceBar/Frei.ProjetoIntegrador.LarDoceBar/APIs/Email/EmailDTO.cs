using Frei.ProjetoIntegrador.Academia.Criptografia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blibioteca.Developers.APIs.Email
{
    class EmailDTO
    {
        //Ative o modo de envio de email para terceiros na sua conta Gmail, antes de usá-la
        //para enviar emails de verificação.

        //Seu Email
        static public string RemetenteEmail = "pb.technology.ltda@gmail.com";
        //Sua Senha
        static public string Senha = "qZ3ITTGVzu0kdIPfsbDJWQ==";
        //Seu nome ou nome da Empresa
        static public string RemetenteNome = "PB Technology ©";

        public string Assunto { get; set; }
        public string RemetenteSenha { get; set; }
        public string DestinatarioNome { get; set; }
        public string DestinatarioEmail { get; set; }
        public string Mensagem { get; set; }
    }
}
