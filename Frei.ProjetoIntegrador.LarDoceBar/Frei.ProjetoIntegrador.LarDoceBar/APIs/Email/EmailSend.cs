using Frei.ProjetoIntegrador.Academia.Criptografia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Blibioteca.Developers.APIs.Email
{
    class EmailSend
    {
        public void EnviarEmail(EmailDTO dto)
        {
            var smtp = new SmtpClient("smtp.gmail.com");

            smtp.EnableSsl = true; // GMail requer SSL
            smtp.Port = 587;       // porta para SSL
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network; // modo de envio
            smtp.UseDefaultCredentials = false; // vamos utilizar credencias especificas

            // seu usuário e senha para autenticação
            smtp.Credentials = new NetworkCredential(EmailDTO.RemetenteEmail, dto.RemetenteSenha);

            MailMessage mail = new MailMessage();

            //mail.Sender = new MailAddress(dto.ReceptorEmail, EmailDTO.remetente);
            mail.From = new MailAddress(EmailDTO.RemetenteEmail, EmailDTO.RemetenteNome);
            mail.To.Add(new MailAddress(dto.DestinatarioEmail, dto.DestinatarioNome));
            mail.Subject = dto.Assunto;
            mail.Body = dto.Mensagem;
            mail.IsBodyHtml = true;
            mail.Priority = MailPriority.High;

            try
            {
                // envia o e-mail
                smtp.Send(mail);
            }
            catch (Exception erro)
            {
                throw new ArgumentException($"Ocorreu um erro: {erro.Message}");
            }
            finally
            {
                mail = null;
            }
        }

        public int CodEmailVerificar(EmailDTO dto)
        {
            Random codigo = new Random();
            int cod = codigo.Next(111111, 999999);

            DESCripto cripto = new DESCripto();
            dto.RemetenteSenha = cripto.Descriptografar("camaleao", EmailDTO.Senha);

            EnviarEmail(dto, cod);
            return cod;
        }

        private void EnviarEmail(EmailDTO dto, int CodVerificacao)
        {
            var smtp = new SmtpClient("smtp.gmail.com");

            smtp.EnableSsl = true; // GMail requer SSL
            smtp.Port = 587;       // porta para SSL
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network; // modo de envio
            smtp.UseDefaultCredentials = false; // vamos utilizar credencias especificas

            // seu usuário e senha para autenticação
            smtp.Credentials = new NetworkCredential(EmailDTO.RemetenteEmail, dto.RemetenteSenha);

            MailMessage mail = new MailMessage();

            //mail.Sender = new MailAddress(dto.ReceptorEmail, EmailDTO.remetente);
            mail.From = new MailAddress(EmailDTO.RemetenteEmail, EmailDTO.RemetenteNome);
            mail.To.Add(new MailAddress(dto.DestinatarioEmail, dto.DestinatarioNome));
            mail.Subject = $"Codigo de Verificação - {EmailDTO.RemetenteNome}";
            mail.Body = bodyEmailVerificacao(CodVerificacao, dto.DestinatarioNome);
            mail.IsBodyHtml = true;
            mail.Priority = MailPriority.High;

            try
            {
                // envia o e-mail
                smtp.Send(mail);
            }
            catch (Exception erro)
            {
                throw new ArgumentException($"Ocorreu um erro: {erro.Message}");
            }
            finally
            {
                mail = null;
            }
        }

        private string bodyEmailVerificacao(int cod, string nome)
        {
            string body = $@"
<CENTER>
    <h1>PB Technology ©<h1>
</CENTER>
<font>
    <br>
    <p>Olá {nome}, Você está cadastrando-se em nosso sistema, para finalizar seu cadastro informe o código abaixo.</p>
    <p>Seu código de verificação é: {cod}.</p>
    <p>Caso não tenha feito isso, desconsidere este email!</p>
    <br>
    <p>Cordialmente,</p>
    <p>CEO - Pedro Henrique Moreira Martins da Silva</p>
    <p>Program Boys Technology LTDA</p>
</font>";
            return body;
        }
    }
}
